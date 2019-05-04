using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lan
{
    public partial class Form_danh_muc : Form
    {
        DataCCDataContext data = new DataCCDataContext();

        public Form_danh_muc()
        {
            InitializeComponent();
        }
        int xLast;
        int yLast;
        bool isMouseDown = false;
        //Hàm di chuyển form trên màn hình 

        private void btNhanVien_Paint(object sender, PaintEventArgs e)
        {
            //ql_nhanvien frm =  new ql_nhanvien();
            ////frm.Show();
            //frm.ShowDialog();
            ////this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bnKho_Paint(object sender, PaintEventArgs e)
        {
          ql_dancu  frm = new ql_dancu();
            //frm.ShowDialog();
           // this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btBan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ql_nhanvien frm = new ql_nhanvien();
            frm.ShowDialog();
            frm.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ql_canho frm = new ql_canho();
            frm.ShowDialog();
            frm.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ql_dancu frm = new ql_dancu();
            frm.ShowDialog();
            frm.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            thongke a = new thongke();
            a.ShowDialog();
            a.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ql_dv a = new ql_dv();
            a.ShowDialog();
            a.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            form_dangnhap a = new form_dangnhap();
           a.ShowDialog();
            //a.Hide();
            this.Close();
        }

        private void Form_danh_muc_Load(object sender, EventArgs e)
        {
            var manhinh = data.CT_PhanQuyens.Where(x => x.id_PQ == BienToanCuc.bientoancuc.ID_PQ);
            foreach (var i in manhinh)
            {
                switch(i.MaManHinh) {
                    case "button2":
                        button2.Enabled = true;
                        break;
                    case "button3":
                        button3.Enabled = true;
                        break;
                    case "button4":
                        button4.Enabled = true;
                        break;
                    case "button5":
                        button5.Enabled = true;
                        break;
                    case "button6":
                        button6.Enabled = true;
                        break;
                    default:
                        MessageBox.Show("Not Error");
                        break;
                }
            }
        }
    }
}
