namespace lan
{
    partial class frmNhanvien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanvien));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txt_manv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_cmnd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_hoten = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_diachi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_sdt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dt_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.rb_nam = new System.Windows.Forms.RadioButton();
            this.rb_nu = new System.Windows.Forms.RadioButton();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.grd_nhanvien = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btn_them = new DevComponents.DotNetBar.ButtonX();
            this.btn_sua = new DevComponents.DotNetBar.ButtonX();
            this.btn_xoa = new DevComponents.DotNetBar.ButtonX();
            this.btn_huy = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.grd_nhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Red;
            this.labelX1.Location = new System.Drawing.Point(228, 23);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(387, 36);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(343, 87);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(67, 29);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Họ và Tên :";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(343, 137);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(67, 29);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "Địa Chỉ :";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(28, 87);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(78, 29);
            this.labelX4.TabIndex = 1;
            this.labelX4.Text = "Mã nhân viên :";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(28, 134);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(94, 29);
            this.labelX5.TabIndex = 1;
            this.labelX5.Text = "CMND/Passport :";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(28, 189);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(88, 29);
            this.labelX6.TabIndex = 1;
            this.labelX6.Text = "Số điện thoại :";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(339, 188);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(67, 29);
            this.labelX7.TabIndex = 1;
            this.labelX7.Text = "Ngày sinh :";
            // 
            // txt_manv
            // 
            // 
            // 
            // 
            this.txt_manv.Border.Class = "TextBoxBorder";
            this.txt_manv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_manv.Enabled = false;
            this.txt_manv.Location = new System.Drawing.Point(122, 93);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.PreventEnterBeep = true;
            this.txt_manv.Size = new System.Drawing.Size(199, 20);
            this.txt_manv.TabIndex = 2;
            // 
            // txt_cmnd
            // 
            // 
            // 
            // 
            this.txt_cmnd.Border.Class = "TextBoxBorder";
            this.txt_cmnd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_cmnd.Location = new System.Drawing.Point(122, 140);
            this.txt_cmnd.Name = "txt_cmnd";
            this.txt_cmnd.PreventEnterBeep = true;
            this.txt_cmnd.Size = new System.Drawing.Size(199, 20);
            this.txt_cmnd.TabIndex = 2;
            // 
            // txt_hoten
            // 
            // 
            // 
            // 
            this.txt_hoten.Border.Class = "TextBoxBorder";
            this.txt_hoten.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_hoten.Location = new System.Drawing.Point(403, 93);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.PreventEnterBeep = true;
            this.txt_hoten.Size = new System.Drawing.Size(271, 20);
            this.txt_hoten.TabIndex = 1;
            // 
            // txt_diachi
            // 
            // 
            // 
            // 
            this.txt_diachi.Border.Class = "TextBoxBorder";
            this.txt_diachi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_diachi.Location = new System.Drawing.Point(403, 143);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.PreventEnterBeep = true;
            this.txt_diachi.Size = new System.Drawing.Size(271, 20);
            this.txt_diachi.TabIndex = 3;
            // 
            // txt_sdt
            // 
            // 
            // 
            // 
            this.txt_sdt.Border.Class = "TextBoxBorder";
            this.txt_sdt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_sdt.Location = new System.Drawing.Point(122, 195);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.PreventEnterBeep = true;
            this.txt_sdt.Size = new System.Drawing.Size(199, 20);
            this.txt_sdt.TabIndex = 4;
            // 
            // dt_ngaysinh
            // 
            this.dt_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngaysinh.Location = new System.Drawing.Point(403, 193);
            this.dt_ngaysinh.Name = "dt_ngaysinh";
            this.dt_ngaysinh.Size = new System.Drawing.Size(101, 20);
            this.dt_ngaysinh.TabIndex = 3;
            // 
            // rb_nam
            // 
            this.rb_nam.AutoSize = true;
            this.rb_nam.Checked = true;
            this.rb_nam.Location = new System.Drawing.Point(581, 196);
            this.rb_nam.Name = "rb_nam";
            this.rb_nam.Size = new System.Drawing.Size(47, 17);
            this.rb_nam.TabIndex = 4;
            this.rb_nam.TabStop = true;
            this.rb_nam.Text = "Nam";
            this.rb_nam.UseVisualStyleBackColor = true;
            // 
            // rb_nu
            // 
            this.rb_nu.AutoSize = true;
            this.rb_nu.Location = new System.Drawing.Point(634, 196);
            this.rb_nu.Name = "rb_nu";
            this.rb_nu.Size = new System.Drawing.Size(39, 17);
            this.rb_nu.TabIndex = 4;
            this.rb_nu.Text = "Nữ";
            this.rb_nu.UseVisualStyleBackColor = true;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(523, 189);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(67, 29);
            this.labelX8.TabIndex = 1;
            this.labelX8.Text = "Giới tính :";
            // 
            // grd_nhanvien
            // 
            this.grd_nhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_nhanvien.DefaultCellStyle = dataGridViewCellStyle3;
            this.grd_nhanvien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grd_nhanvien.Location = new System.Drawing.Point(43, 259);
            this.grd_nhanvien.Name = "grd_nhanvien";
            this.grd_nhanvien.Size = new System.Drawing.Size(747, 220);
            this.grd_nhanvien.TabIndex = 5;
            this.grd_nhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_nhanvien_CellClick);
            // 
            // btn_them
            // 
            this.btn_them.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_them.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.Location = new System.Drawing.Point(695, 93);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(95, 26);
            this.btn_them.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_them.TabIndex = 6;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_sua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.Location = new System.Drawing.Point(695, 128);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(95, 26);
            this.btn_sua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_sua.TabIndex = 7;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_xoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.Location = new System.Drawing.Point(695, 170);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(95, 26);
            this.btn_xoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_xoa.TabIndex = 8;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_huy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_huy.Image = ((System.Drawing.Image)(resources.GetObject("btn_huy.Image")));
            this.btn_huy.Location = new System.Drawing.Point(695, 214);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(95, 26);
            this.btn_huy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_huy.TabIndex = 9;
            this.btn_huy.Text = "Hủy";
            // 
            // frmNhanvien
            // 
            this.ClientSize = new System.Drawing.Size(817, 496);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.grd_nhanvien);
            this.Controls.Add(this.rb_nu);
            this.Controls.Add(this.rb_nam);
            this.Controls.Add(this.dt_ngaysinh);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_cmnd);
            this.Controls.Add(this.txt_hoten);
            this.Controls.Add(this.txt_manv);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Name = "frmNhanvien";
            this.Text = "frmNhanvien";
            this.Load += new System.EventHandler(this.frmNhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_nhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_manv;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_cmnd;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_hoten;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_diachi;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_sdt;
        private System.Windows.Forms.DateTimePicker dt_ngaysinh;
        private System.Windows.Forms.RadioButton rb_nam;
        private System.Windows.Forms.RadioButton rb_nu;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.DataGridViewX grd_nhanvien;
        private DevComponents.DotNetBar.ButtonX btn_them;
        private DevComponents.DotNetBar.ButtonX btn_sua;
        private DevComponents.DotNetBar.ButtonX btn_xoa;
        private DevComponents.DotNetBar.ButtonX btn_huy;
    }
}