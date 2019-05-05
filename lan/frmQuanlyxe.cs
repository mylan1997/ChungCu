using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Linq;

namespace lan
{
    public partial class frmQuanlyxe : DevComponents.DotNetBar.RibbonForm
    {
        DataCCDataContext data = new DataCCDataContext();
        public frmQuanlyxe()
        {
            InitializeComponent();
        }

        private void frmQuanlyxe_Load(object sender, EventArgs e)
        {
            load();
        }

        public void load()
        {
            grd_xe.DataSource = data.QL_Xes.ToList();
        }

        private void grd_xe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mathe.Text = grd_xe.CurrentRow.Cells["ID"].Value.ToString();            
            txt_bienso.Text = grd_xe.CurrentRow.Cells["BienSoXe"].Value.ToString();
            txt_dongia.Text = grd_xe.CurrentRow.Cells["DonGia"].Value.ToString();
            comb_loaixe.Text = grd_xe.CurrentRow.Cells["LoaiXe"].Value.ToString();
            txt_hten.Text = grd_xe.CurrentRow.Cells["TenChuXe"].Value.ToString();
            txt_tenxe.Text = grd_xe.CurrentRow.Cells["TenXe"].Value.ToString();
            date.Text = grd_xe.CurrentRow.Cells["NgayKichHoat"].Value.ToString();

            var madc = grd_xe.CurrentRow.Cells["MaDanCu"].Value;
            if (madc != null)
            {
                txt_madc.Text = grd_xe.CurrentRow.Cells["MaDanCu"].Value.ToString();
            }
            var check = grd_xe.CurrentRow.Cells["KichHoat"].Value.ToString();
            if (check == "Có")
            {
               check_co.Checked = true;
            }
            else
            {
               check_co.Checked = false;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
             QL_Xe a = new QL_Xe();

            a.BienSoXe = txt_bienso.Text;
            a.DonGia = int.Parse(txt_dongia.Text);
            a.LoaiXe = comb_loaixe.Text;
            a.NgayKichHoat = date.Value.Date;
            a.TenChuXe = txt_hten.Text;
            a.TenXe = txt_tenxe.Text;
            a.MaDanCu = int.Parse(txt_madc.Text) ;
            if (check_co.Checked)
            {
               a.KichHoat = "Có";
            }
            else
            {
              a.KichHoat = "Không";
            }

            data.QL_Xes.InsertOnSubmit(a);

            data.SubmitChanges();
            load();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            QL_Xe xe = data.QL_Xes.Where(x => x.ID == int.Parse(txt_mathe.Text)).FirstOrDefault();

            xe.BienSoXe = txt_bienso.Text;
            xe.DonGia = int.Parse(txt_dongia.Text);
            xe.LoaiXe = comb_loaixe.Text;
            xe.NgayKichHoat = date.Value.Date;
            xe.TenChuXe = txt_hten.Text;
            xe.TenXe = txt_tenxe.Text;
           
            if (txt_madc.Text != "")
            {
                xe.MaDanCu = int.Parse(txt_madc.Text);
            }

            if (check_co.Checked)
            {
              xe.KichHoat = "Có";
            }
            else
            {
                xe.KichHoat = "Không";
            }

            data.SubmitChanges();
            load();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
           QL_Xe Xe = data.QL_Xes.Where(x => x.ID == int.Parse(txt_mathe.Text)).First();

            data.QL_Xes.DeleteOnSubmit(Xe);
            data.SubmitChanges();

            load();
        }

        private void comb_loaixe_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comb_loaixe.Text)
            {
                case "Xe Đạp Điện":
                    txt_dongia.Text = "50000";
                    break;
                case "Xe Hơi":
                    txt_dongia.Text = "350000";
                    break;
                case "Xe Ga":
                    txt_dongia.Text = "250000";
                    break;
                case "Xe Số":
                    txt_dongia.Text = "250000";
                    break;
                case "Xe Đạp ":
                    txt_dongia.Text = "50000";
                    break;
                default:
                    break;
            }
        }
    }
}
