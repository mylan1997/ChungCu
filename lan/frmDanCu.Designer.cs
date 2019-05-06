namespace lan
{
    partial class frmDanCu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanCu));
            this.label1 = new System.Windows.Forms.Label();
            this.grd_dancu = new System.Windows.Forms.DataGridView();
            this.btn_Timkiem = new DevComponents.DotNetBar.ButtonX();
            this.btn_huy = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_madc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txt_tendc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txt_sdt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txt_cmnd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txt_diachi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dt_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.rb_nu = new System.Windows.Forms.RadioButton();
            this.rb_nam = new System.Windows.Forms.RadioButton();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.btn_them = new DevComponents.DotNetBar.ButtonX();
            this.btn_sua = new DevComponents.DotNetBar.ButtonX();
            this.btn_xoa = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.grd_dancu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(256, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH DÂN CƯ";
            // 
            // grd_dancu
            // 
            this.grd_dancu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_dancu.Location = new System.Drawing.Point(31, 316);
            this.grd_dancu.Name = "grd_dancu";
            this.grd_dancu.Size = new System.Drawing.Size(746, 244);
            this.grd_dancu.TabIndex = 14;
            this.grd_dancu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_dancu_CellContentClick);
            this.grd_dancu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_dancu_CellContentClick);
            // 
            // btn_Timkiem
            // 
            this.btn_Timkiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Timkiem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Timkiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_Timkiem.Image")));
            this.btn_Timkiem.Location = new System.Drawing.Point(84, 248);
            this.btn_Timkiem.Name = "btn_Timkiem";
            this.btn_Timkiem.Size = new System.Drawing.Size(98, 39);
            this.btn_Timkiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Timkiem.TabIndex = 9;
            this.btn_Timkiem.Text = "Tìm kiếm";
            // 
            // btn_huy
            // 
            this.btn_huy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_huy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_huy.Image = ((System.Drawing.Image)(resources.GetObject("btn_huy.Image")));
            this.btn_huy.Location = new System.Drawing.Point(617, 248);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(98, 39);
            this.btn_huy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_huy.TabIndex = 13;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(31, 110);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "Mã dân cư :";
            // 
            // txt_madc
            // 
            // 
            // 
            // 
            this.txt_madc.Border.Class = "TextBoxBorder";
            this.txt_madc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_madc.Enabled = false;
            this.txt_madc.Location = new System.Drawing.Point(123, 116);
            this.txt_madc.Name = "txt_madc";
            this.txt_madc.PreventEnterBeep = true;
            this.txt_madc.Size = new System.Drawing.Size(276, 20);
            this.txt_madc.TabIndex = 1;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(424, 116);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "Tên dân cư :";
            // 
            // txt_tendc
            // 
            // 
            // 
            // 
            this.txt_tendc.Border.Class = "TextBoxBorder";
            this.txt_tendc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_tendc.Location = new System.Drawing.Point(488, 116);
            this.txt_tendc.Name = "txt_tendc";
            this.txt_tendc.PreventEnterBeep = true;
            this.txt_tendc.Size = new System.Drawing.Size(290, 20);
            this.txt_tendc.TabIndex = 2;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(424, 199);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "Ngày sinh :";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(32, 196);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 5;
            this.labelX4.Text = "Số điện thoại :";
            // 
            // txt_sdt
            // 
            // 
            // 
            // 
            this.txt_sdt.Border.Class = "TextBoxBorder";
            this.txt_sdt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_sdt.Location = new System.Drawing.Point(124, 202);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.PreventEnterBeep = true;
            this.txt_sdt.Size = new System.Drawing.Size(275, 20);
            this.txt_sdt.TabIndex = 5;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(31, 156);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(99, 23);
            this.labelX5.TabIndex = 5;
            this.labelX5.Text = "CMND/Passport :";
            // 
            // txt_cmnd
            // 
            // 
            // 
            // 
            this.txt_cmnd.Border.Class = "TextBoxBorder";
            this.txt_cmnd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_cmnd.Location = new System.Drawing.Point(123, 159);
            this.txt_cmnd.Name = "txt_cmnd";
            this.txt_cmnd.PreventEnterBeep = true;
            this.txt_cmnd.Size = new System.Drawing.Size(276, 20);
            this.txt_cmnd.TabIndex = 3;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(424, 156);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 5;
            this.labelX6.Text = "Địa chỉ :";
            // 
            // txt_diachi
            // 
            // 
            // 
            // 
            this.txt_diachi.Border.Class = "TextBoxBorder";
            this.txt_diachi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_diachi.Location = new System.Drawing.Point(488, 159);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.PreventEnterBeep = true;
            this.txt_diachi.Size = new System.Drawing.Size(290, 20);
            this.txt_diachi.TabIndex = 4;
            // 
            // dt_ngaysinh
            // 
            this.dt_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngaysinh.Location = new System.Drawing.Point(488, 198);
            this.dt_ngaysinh.Name = "dt_ngaysinh";
            this.dt_ngaysinh.Size = new System.Drawing.Size(101, 20);
            this.dt_ngaysinh.TabIndex = 6;
            // 
            // rb_nu
            // 
            this.rb_nu.AutoSize = true;
            this.rb_nu.Location = new System.Drawing.Point(739, 199);
            this.rb_nu.Name = "rb_nu";
            this.rb_nu.Size = new System.Drawing.Size(39, 17);
            this.rb_nu.TabIndex = 8;
            this.rb_nu.Text = "Nữ";
            this.rb_nu.UseVisualStyleBackColor = true;
            // 
            // rb_nam
            // 
            this.rb_nam.AutoSize = true;
            this.rb_nam.Checked = true;
            this.rb_nam.Location = new System.Drawing.Point(668, 199);
            this.rb_nam.Name = "rb_nam";
            this.rb_nam.Size = new System.Drawing.Size(47, 17);
            this.rb_nam.TabIndex = 7;
            this.rb_nam.TabStop = true;
            this.rb_nam.Text = "Nam";
            this.rb_nam.UseVisualStyleBackColor = true;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(595, 193);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(67, 29);
            this.labelX8.TabIndex = 8;
            this.labelX8.Text = "Giới tính :";
            // 
            // btn_them
            // 
            this.btn_them.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_them.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.Location = new System.Drawing.Point(219, 248);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(98, 39);
            this.btn_them.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_them.TabIndex = 10;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_sua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.Location = new System.Drawing.Point(347, 248);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(98, 39);
            this.btn_sua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_sua.TabIndex = 11;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_xoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.Location = new System.Drawing.Point(479, 248);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(98, 39);
            this.btn_xoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_xoa.TabIndex = 12;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // frmDanCu
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(813, 588);
            this.Controls.Add(this.rb_nu);
            this.Controls.Add(this.rb_nam);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.dt_ngaysinh);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.txt_cmnd);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txt_tendc);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txt_madc);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_Timkiem);
            this.Controls.Add(this.grd_dancu);
            this.Controls.Add(this.label1);
            this.Name = "frmDanCu";
            this.Text = "frmDanCu";
            this.Load += new System.EventHandler(this.frmDanCu_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.grd_dancu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grd_dancu;
        private DevComponents.DotNetBar.ButtonX btn_Timkiem;
        private DevComponents.DotNetBar.ButtonX btn_huy;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_madc;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_tendc;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_sdt;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_cmnd;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_diachi;
        private System.Windows.Forms.DateTimePicker dt_ngaysinh;
        private System.Windows.Forms.RadioButton rb_nu;
        private System.Windows.Forms.RadioButton rb_nam;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.ButtonX btn_them;
        private DevComponents.DotNetBar.ButtonX btn_sua;
        private DevComponents.DotNetBar.ButtonX btn_xoa;
    }
}