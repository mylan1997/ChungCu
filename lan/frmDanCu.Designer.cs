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
            this.btn_Thoat = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_maCH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txt_TenDC = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txt_Ngaysinh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txt_Quequan = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.grd_dancu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(206, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH DÂN CƯ";
            // 
            // grd_dancu
            // 
            this.grd_dancu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_dancu.Location = new System.Drawing.Point(56, 243);
            this.grd_dancu.Name = "grd_dancu";
            this.grd_dancu.Size = new System.Drawing.Size(762, 244);
            this.grd_dancu.TabIndex = 2;
            // 
            // btn_Timkiem
            // 
            this.btn_Timkiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Timkiem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Timkiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_Timkiem.Image")));
            this.btn_Timkiem.Location = new System.Drawing.Point(590, 123);
            this.btn_Timkiem.Name = "btn_Timkiem";
            this.btn_Timkiem.Size = new System.Drawing.Size(103, 59);
            this.btn_Timkiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Timkiem.TabIndex = 4;
            this.btn_Timkiem.Text = "Tìm kiếm";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Thoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.Image")));
            this.btn_Thoat.Location = new System.Drawing.Point(720, 123);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(98, 59);
            this.btn_Thoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Thoat.TabIndex = 4;
            this.btn_Thoat.Text = "Thoát";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(56, 110);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "Mã căn hộ :";
            // 
            // txt_maCH
            // 
            // 
            // 
            // 
            this.txt_maCH.Border.Class = "TextBoxBorder";
            this.txt_maCH.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_maCH.Location = new System.Drawing.Point(137, 110);
            this.txt_maCH.Name = "txt_maCH";
            this.txt_maCH.PreventEnterBeep = true;
            this.txt_maCH.Size = new System.Drawing.Size(396, 20);
            this.txt_maCH.TabIndex = 6;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(56, 136);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "Tên dân cư :";
            // 
            // txt_TenDC
            // 
            // 
            // 
            // 
            this.txt_TenDC.Border.Class = "TextBoxBorder";
            this.txt_TenDC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_TenDC.Location = new System.Drawing.Point(137, 136);
            this.txt_TenDC.Name = "txt_TenDC";
            this.txt_TenDC.PreventEnterBeep = true;
            this.txt_TenDC.Size = new System.Drawing.Size(396, 20);
            this.txt_TenDC.TabIndex = 6;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(56, 162);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "Ngày sinh :";
            // 
            // txt_Ngaysinh
            // 
            // 
            // 
            // 
            this.txt_Ngaysinh.Border.Class = "TextBoxBorder";
            this.txt_Ngaysinh.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Ngaysinh.Location = new System.Drawing.Point(137, 162);
            this.txt_Ngaysinh.Name = "txt_Ngaysinh";
            this.txt_Ngaysinh.PreventEnterBeep = true;
            this.txt_Ngaysinh.Size = new System.Drawing.Size(396, 20);
            this.txt_Ngaysinh.TabIndex = 6;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(56, 188);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 5;
            this.labelX4.Text = "Quê quán :";
            // 
            // txt_Quequan
            // 
            // 
            // 
            // 
            this.txt_Quequan.Border.Class = "TextBoxBorder";
            this.txt_Quequan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Quequan.Location = new System.Drawing.Point(137, 188);
            this.txt_Quequan.Name = "txt_Quequan";
            this.txt_Quequan.PreventEnterBeep = true;
            this.txt_Quequan.Size = new System.Drawing.Size(396, 20);
            this.txt_Quequan.TabIndex = 6;
            // 
            // frmDanCu
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(845, 510);
            this.Controls.Add(this.txt_Quequan);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txt_TenDC);
            this.Controls.Add(this.txt_Ngaysinh);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txt_maCH);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btn_Thoat);
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
        private DevComponents.DotNetBar.ButtonX btn_Thoat;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_maCH;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_TenDC;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Ngaysinh;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Quequan;
    }
}