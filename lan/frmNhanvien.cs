using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.SqlClient;
using System.Linq;

namespace lan
{
    public partial class frmNhanvien : DevComponents.DotNetBar.RibbonForm
    {
        DataCCDataContext data = new DataCCDataContext();

        public frmNhanvien()
        {
            InitializeComponent();
        }

        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            nhanvien nv = new nhanvien();

            nv.hoten = txt_hoten.Text;
            nv.diachi = txt_diachi.Text;
            nv.SDT = txt_sdt.Text;
            nv.NgaySinh = dt_ngaysinh.Value.Date;
            nv.CMND = txt_cmnd.Text;
            if (rb_nam.Checked)
            {
                nv.gioitinh = "Nam";
            }
            else
            {
                nv.gioitinh = "Nữ";
            }

            data.nhanviens.InsertOnSubmit(nv);

            data.SubmitChanges();
            load();
        }

        public void load()
        {
            grd_nhanvien.DataSource = data.nhanviens.ToList();
        }

        private void grd_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_manv.Text = grd_nhanvien.CurrentRow.Cells["manv"].Value.ToString();
            txt_hoten.Text = grd_nhanvien.CurrentRow.Cells["hoten"].Value.ToString();
            txt_diachi.Text = grd_nhanvien.CurrentRow.Cells["diachi"].Value.ToString();
            txt_sdt.Text = grd_nhanvien.CurrentRow.Cells["SDT"].Value.ToString();
            txt_cmnd.Text = grd_nhanvien.CurrentRow.Cells["CMND"].Value.ToString();
            dt_ngaysinh.Text = grd_nhanvien.CurrentRow.Cells["NgaySinh"].Value.ToString();
            var check = grd_nhanvien.CurrentRow.Cells["gioitinh"].Value.ToString();
            if (check ==  "Nam")
            {
                rb_nam.Checked = true;
            }
            else
            {
                rb_nu.Checked = true;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            nhanvien nv = data.nhanviens.Where(x => x.manv == int.Parse(txt_manv.Text)).First();

            nv.hoten = txt_hoten.Text;
            nv.diachi = txt_diachi.Text;
            nv.SDT = txt_sdt.Text;
            nv.NgaySinh = dt_ngaysinh.Value.Date;
            nv.CMND = txt_cmnd.Text;

            if (rb_nam.Checked)
            {
                nv.gioitinh = "Nam";
            }
            else
            {
                nv.gioitinh = "Nữ";
            }

            data.SubmitChanges();
            load();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            nhanvien nv = data.nhanviens.Where(x => x.manv == int.Parse(txt_manv.Text)).First();

            data.nhanviens.DeleteOnSubmit(nv);
            data.SubmitChanges();

            load();
        }

        private void grd_nhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}