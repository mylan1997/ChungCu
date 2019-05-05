namespace lan
{
    partial class frmDangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangnhap));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_email = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_pass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btn_login = new DevComponents.DotNetBar.ButtonX();
            this.btn_thoat = new DevComponents.DotNetBar.ButtonX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.FontBold = true;
            this.labelX1.ForeColor = System.Drawing.Color.Red;
            this.labelX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.labelX1.Location = new System.Drawing.Point(149, 175);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(233, 50);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "ĐĂNG NHẬP";
            this.labelX1.Click += new System.EventHandler(this.labelX1_Click_1);
            // 
            // txt_email
            // 
            // 
            // 
            // 
            this.txt_email.Border.Class = "TextBoxBorder";
            this.txt_email.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_email.Location = new System.Drawing.Point(168, 231);
            this.txt_email.Name = "txt_email";
            this.txt_email.PreventEnterBeep = true;
            this.txt_email.Size = new System.Drawing.Size(234, 20);
            this.txt_email.TabIndex = 1;
            // 
            // txt_pass
            // 
            // 
            // 
            // 
            this.txt_pass.Border.Class = "TextBoxBorder";
            this.txt_pass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_pass.Location = new System.Drawing.Point(168, 274);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.PreventEnterBeep = true;
            this.txt_pass.Size = new System.Drawing.Size(234, 20);
            this.txt_pass.TabIndex = 2;
            this.txt_pass.TextChanged += new System.EventHandler(this.textBoxX2_TextChanged);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(56, 228);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(106, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Tên đăng nhập :";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(56, 271);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(106, 23);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "Mật khẩu :";
            // 
            // btn_login
            // 
            this.btn_login.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_login.BackColor = System.Drawing.Color.White;
            this.btn_login.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Image = ((System.Drawing.Image)(resources.GetObject("btn_login.Image")));
            this.btn_login.Location = new System.Drawing.Point(85, 330);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(141, 45);
            this.btn_login.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.TextColor = System.Drawing.Color.Black;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_thoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.Location = new System.Drawing.Point(314, 330);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(141, 45);
            this.btn_thoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextColor = System.Drawing.Color.Black;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmDangnhap
            // 
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(526, 426);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.labelX1);
            this.Name = "frmDangnhap";
            this.Text = "frmDangnhap";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_email;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_pass;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX btn_login;
        private DevComponents.DotNetBar.ButtonX btn_thoat;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}