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
    public partial class frmDanCu : DevComponents.DotNetBar.RibbonForm
    {
        DataCCDataContext data = new DataCCDataContext();

        public frmDanCu()
        {
            InitializeComponent();
        }
        public void load()
        {
            grd_dancu.DataSource = data.nhankhaus.ToList();
        }
        //private void frmDanCu_Load(object sender, EventArgs e)
        //{
         //   load();
        //}

        private void frmDanCu_Load_1(object sender, EventArgs e)
        {
            load();
        }

        private void grd_dancu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_madc.Text = grd_dancu.CurrentRow.Cells["mank"].Value.ToString();
            txt_tendc.Text = grd_dancu.CurrentRow.Cells["hoten"].Value.ToString();
            txt_cmnd.Text = grd_dancu.CurrentRow.Cells["cmnd"].Value.ToString();
            txt_diachi.Text = grd_dancu.CurrentRow.Cells["diachi"].Value.ToString();
            txt_sdt.Text = grd_dancu.CurrentRow.Cells["sdt"].Value.ToString();
            dt_ngaysinh.Text = grd_dancu.CurrentRow.Cells["ngaysinh"].Value.ToString();
            var check = grd_dancu.CurrentRow.Cells["gioitinh"].Value.ToString();
            if (check == "Nam")
            {
                rb_nam.Checked = true;
            }
            else
            {
                rb_nu.Checked = true;
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            nhankhau dc = new nhankhau();
          //  dc.mank = int.Parse(txt_madc.Text);
            dc.hoten = txt_tendc.Text;
            dc.diachi = txt_diachi.Text;
            dc.sdt = txt_sdt.Text;
            dc.ngaysinh = dt_ngaysinh.Value.Date;
            dc.cmnd = txt_cmnd.Text;
            if (rb_nam.Checked)
            {
                dc.gioitinh = "Nam";
            }
            else
            {
                dc.gioitinh = "Nữ";
            }

            data.nhankhaus.InsertOnSubmit(dc);

            data.SubmitChanges();
            load();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            nhankhau dc = data.nhankhaus.Where(x => x.mank == int.Parse(txt_madc.Text)).First();

            dc.hoten = txt_tendc.Text;
            dc.diachi = txt_diachi.Text;
            dc.sdt = txt_sdt.Text;
            dc.ngaysinh = dt_ngaysinh.Value.Date;
            dc.cmnd = txt_cmnd.Text;

            if (rb_nam.Checked)
            {
                dc.gioitinh = "Nam";
            }
            else
            {
                dc.gioitinh = "Nữ";
            }

            data.SubmitChanges();
            load();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            nhankhau dc = data.nhankhaus.Where(x => x.mank == int.Parse(txt_madc.Text)).First();

            data.nhankhaus.DeleteOnSubmit(dc);
            data.SubmitChanges();

            load();
        }
    }
}