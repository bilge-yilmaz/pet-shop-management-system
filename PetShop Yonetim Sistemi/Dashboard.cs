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

namespace PetShop_Yonetim_Sistemi
{
    public partial class Dashboard : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DbConnect dbcon = new DbConnect();
        string title = "Pet Shop Yönetim Sistemi";
        public Dashboard()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.connection());
        }
        #region method
        public int extractData(string str)
        {
            int data = 0;
            try
            {
                cn.Open();
                cm = new SqlCommand("SELECT ISNULL(SUM(pqty),0) AS qty FROM tbProduct WHERE pcategory='" + str + "'", cn);
                data = int.Parse(cm.ExecuteScalar().ToString());
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title);
            }
            return data;
        }

        #endregion method

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblDog.Text = extractData("Köpek").ToString();
            lblCat.Text = extractData("Kedi").ToString();
            lblBird.Text = extractData("Kuş").ToString();
            lblFish.Text = extractData("Balık").ToString();
            UpdateProgressBar("Kedi", lblCat, progressBarCat);
            UpdateProgressBar("Kuş", lblBird, progressBarBird);
            UpdateProgressBar("Balık", lblFish, progressBarFish);
            UpdateProgressBar("Köpek", lblDog, progressBarDog);
        }
        private void UpdateProgressBar(string category, Label label, ProgressBar progressBar)
        {
            int data = extractData(category);
            label.Text = data.ToString();
            int progressBarValue = (data * 100) / 1000; 
            progressBar.Value = progressBarValue;
        }
    }
}
