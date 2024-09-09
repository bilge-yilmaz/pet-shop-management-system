namespace PetShop_Yonetim_Sistemi
{
    partial class ProductModule
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductModule));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            btnClose = new Guna.UI2.WinForms.Guna2Button();
            btnCancel = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            lblPcode = new Label();
            txtPrice = new TextBox();
            lblPass = new Label();
            label5 = new Label();
            label4 = new Label();
            txtType = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtQty = new TextBox();
            cbCategory = new ComboBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 172, 220);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 21);
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
            btnClose.Location = new Point(748, 27);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnClose.Size = new Size(52, 40);
            btnClose.TabIndex = 29;
            btnClose.Click += btnClose_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.Silver;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(623, 391);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(138, 42);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdate.Enabled = false;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(442, 391);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(138, 42);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(3, 172, 220);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(263, 391);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 42);
            btnSave.TabIndex = 24;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblPcode
            // 
            lblPcode.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPcode.AutoSize = true;
            lblPcode.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblPcode.Location = new Point(6, 391);
            lblPcode.Name = "lblPcode";
            lblPcode.Size = new Size(70, 21);
            lblPcode.TabIndex = 32;
            lblPcode.Text = "pcode";
            lblPcode.Visible = false;
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtPrice.Location = new Point(263, 338);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(465, 30);
            txtPrice.TabIndex = 23;
            txtPrice.KeyPress += txtPrice_KeyPress_1;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblPass.Location = new Point(6, 338);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(62, 21);
            lblPass.TabIndex = 31;
            lblPass.Text = "Fiyat :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(6, 280);
            label5.Name = "label5";
            label5.Size = new Size(66, 21);
            label5.TabIndex = 28;
            label5.Text = "Adet :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(6, 221);
            label4.Name = "label4";
            label4.Size = new Size(94, 21);
            label4.TabIndex = 25;
            label4.Text = "Kategori :";
            // 
            // txtType
            // 
            txtType.Location = new Point(263, 162);
            txtType.Name = "txtType";
            txtType.Size = new Size(465, 30);
            txtType.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(6, 162);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 22;
            label3.Text = "Tür :";
            // 
            // txtName
            // 
            txtName.Location = new Point(263, 103);
            txtName.Name = "txtName";
            txtName.Size = new Size(465, 30);
            txtName.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(6, 103);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 18;
            label2.Text = "İsim :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(3, 172, 220);
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(134, 27);
            label1.TabIndex = 16;
            label1.Text = "Ürün Kaydı";
            // 
            // txtQty
            // 
            txtQty.Location = new Point(263, 280);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(465, 30);
            txtQty.TabIndex = 33;
            txtQty.KeyPress += txtQty_KeyPress_1;
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { "Kedi", "Köpek", "Kuş", "Balık", "Mama / Yem" });
            cbCategory.Location = new Point(263, 221);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(465, 29);
            cbCategory.TabIndex = 34;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // ProductModule
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(cbCategory);
            Controls.Add(txtQty);
            Controls.Add(btnClose);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(lblPcode);
            Controls.Add(txtPrice);
            Controls.Add(lblPass);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtType);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProductModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductModule";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Button btnCancel;
        public Button btnUpdate;
        public Button btnSave;
        public ComboBox cbRole;
        public Label lblPcode;
        public TextBox txtPrice;
        private Label lblPass;
        private Label label5;
        private Label label4;
        public TextBox txtType;
        private Label label3;
        public TextBox txtName;
        private Label label2;
        private Label label1;
        public TextBox txtQty;
        public ComboBox cbCategory;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}