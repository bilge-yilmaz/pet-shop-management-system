using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace PetShop_Yonetim_Sistemi
{
    public partial class CashForm : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DbConnect dbcon = new DbConnect();
        SqlDataReader dr;
        string title = "Pet Shop Yönetim Sistemi";
        MainForm main;
        public CashForm(MainForm form)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());
            main = form;
            getTransno();
            loadCash();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            CashProduct product = new CashProduct(this);
            product.uname = main.lblUsername.Text;
            product.ShowDialog();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            CashCustomer customer = new CashCustomer(this);
            customer.ShowDialog();

            if (MessageBox.Show("Kasadan geçirmek istediğinize emin misiniz?", "Kasa İşlemleri", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                getTransno();
                main.loadDailySale();

                for (int i = 0; i < dgvCash.Rows.Count; i++)
                {
                    dbcon.executeQuery("UPDATE tbProduct SET pqty= pqty - " + int.Parse(dgvCash.Rows[i].Cells[4].Value.ToString()) + " WHERE pcode LIKE " + dgvCash.Rows[i].Cells[2].Value.ToString() + "");
                }
                dgvCash.Rows.Clear();
            }
        }

        private void dgvCash_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCash.Columns[e.ColumnIndex].Name;

        removeitem:
            if (colName == "Delete")
            {
                if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbcon.executeQuery("DELETE FROM tbCash WHERE cashid LIKE '" + dgvCash.Rows[e.RowIndex].Cells[1].Value.ToString() + "'");
                    MessageBox.Show("Kayıt başarıyla kaldırıldı!", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (colName == "Increase")
            {
                int i;
                if (int.TryParse(dgvCash.Rows[e.RowIndex].Cells[4].Value.ToString(), out i))
                {
                    int pqty = checkPqty(dgvCash.Rows[e.RowIndex].Cells[2].Value.ToString());
                    if (i < pqty)
                    {
                        dbcon.executeQuery("UPDATE tbCash SET qty = qty + " + 1 + " WHERE cashid LIKE '" + dgvCash.Rows[e.RowIndex].Cells[1].Value.ToString() + "'");
                    }
                    else
                    {
                        MessageBox.Show("Stok miktarı: " + pqty + "!", "Stok Uyarısı ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Dönüştürme hatası: " + dgvCash.Rows[e.RowIndex].Cells[4].Value.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (colName == "Decrease")
            {
                if (int.TryParse(dgvCash.Rows[e.RowIndex].Cells[4].Value.ToString(), out int i))
                {
                    if (i == 1)
                    {
                        colName = "Delete";
                        goto removeitem;
                    }
                    dbcon.executeQuery("UPDATE tbCash SET qty = qty - " + 1 + " WHERE cashid LIKE '" + dgvCash.Rows[e.RowIndex].Cells[1].Value.ToString() + "'");
                }
                else
                {
                    MessageBox.Show("Dönüştürme hatası: " + dgvCash.Rows[e.RowIndex].Cells[4].Value.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            loadCash();
        }
        #region method
        public void getTransno()
        {
            try
            {
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                int count;
                string transno;

                cn.Open();
                cm = new SqlCommand("SELECT TOP 1 transno FROM tbCash WHERE transno LIKE '" + sdate + "%' ORDER BY cashid DESC", cn);
                dr = cm.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    transno = dr[0].ToString();
                    count = int.Parse(transno.Substring(8, 4));
                    lblTransno.Text = sdate + (count + 1);
                }
                else
                {
                    transno = sdate + "1001";
                    lblTransno.Text = transno;
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title);
            }
        }


        public void loadCash()
        {
            try
            {
                int i = 0;
                decimal total = 0;
                dgvCash.Rows.Clear();

                cm = new SqlCommand("SELECT cashid, pcode, pname, qty, price, total, c.name, cashier FROM tbCash as cash LEFT JOIN tbCustomer c ON cash.cid = c.id WHERE transno LIKE '" + lblTransno.Text + "%'", cn);
                cn.Open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvCash.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
                    if (decimal.TryParse(dr[5].ToString(), out decimal price))
                    {
                        total += price;
                    }
                    else
                    {
                        MessageBox.Show("Dönüştürme hatası: " + dr[5].ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                dr.Close();
                cn.Close();
                lblTotal.Text = total.ToString("#,##0.00", CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title);
            }
        }
        public int checkPqty(string pcode)
        {
            int i = 0;
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT pqty FROM tbProduct WHERE pcode LIKE '" + pcode + "'", cn);
                i = int.Parse(cm.ExecuteScalar().ToString());
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title);
            }
            return i;
        }
        #endregion method



    }
}
