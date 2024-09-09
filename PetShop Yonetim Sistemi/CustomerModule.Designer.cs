namespace PetShop_Yonetim_Sistemi
{
    partial class CustomerModule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerModule));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            btnClose = new Guna.UI2.WinForms.Guna2Button();
            txtPhone = new TextBox();
            label4 = new Label();
            txtAddress = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnCancel = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            lblcid = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 172, 220);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 21);
            panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.CustomizableEdges = customizableEdges1;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.FillColor = Color.Transparent;
            btnClose.Font = new Font("Segoe UI", 9F);
            btnClose.ForeColor = Color.White;
            btnClose.HoverState.BorderColor = Color.Transparent;
            btnClose.HoverState.FillColor = Color.Transparent;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(739, 20);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnClose.Size = new Size(52, 40);
            btnClose.TabIndex = 17;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(260, 180);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(465, 30);
            txtPhone.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(3, 180);
            label4.Name = "label4";
            label4.Size = new Size(84, 21);
            label4.TabIndex = 16;
            label4.Text = "Telefon :";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(260, 131);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(465, 30);
            txtAddress.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(3, 131);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 15;
            label3.Text = "Adres :";
            // 
            // txtName
            // 
            txtName.Location = new Point(260, 80);
            txtName.Name = "txtName";
            txtName.Size = new Size(465, 30);
            txtName.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(3, 80);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 14;
            label2.Text = "İsim :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(3, 172, 220);
            label1.Location = new Point(3, 33);
            label1.Name = "label1";
            label1.Size = new Size(165, 27);
            label1.TabIndex = 12;
            label1.Text = "Müşteri Kaydı";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.Silver;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(626, 245);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(138, 42);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdate.Enabled = false;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(445, 245);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(138, 42);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(3, 172, 220);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(266, 245);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 42);
            btnSave.TabIndex = 18;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // lblcid
            // 
            lblcid.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblcid.AutoSize = true;
            lblcid.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblcid.Location = new Point(9, 247);
            lblcid.Name = "lblcid";
            lblcid.Size = new Size(37, 21);
            lblcid.TabIndex = 21;
            lblcid.Text = "cid";
            lblcid.Visible = false;
            // 
            // CustomerModule
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(782, 299);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(lblcid);
            Controls.Add(btnClose);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(txtAddress);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "CustomerModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerModule";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        public TextBox txtPhone;
        private Label label4;
        public TextBox txtAddress;
        private Label label3;
        public TextBox txtName;
        private Label label2;
        private Label label1;
        private Button btnCancel;
        public Button btnUpdate;
        public Button btnSave;
        public Label lblcid;
    }
}