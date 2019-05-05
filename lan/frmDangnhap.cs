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
    public partial class frmDangnhap : Form
    {
        DataCCDataContext data = new DataCCDataContext();
        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxX2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelX1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Check();
        }
        public void Login()
        {
            var user = data.TaiKhoans.Where(tk => tk.TenDN == txt_email.Text && tk.MatKhau == txt_pass.Text).FirstOrDefault();

            if (user != null)
            {

                var user_pq = data.Taikhoan_PhanQuyens.Where(x => x.id_ND == user.id).FirstOrDefault();

                if (user_pq.Gioihan != false)
                {
                    MessageBox.Show("Bạn đã bị chặn !!! Hãy liên hệ admin để giải quyết");
                }
                else
                {
                    BienToanCuc.bientoancuc.ID_PQ = user_pq.id_PQ;

                   RibbonForm1 frm = new RibbonForm1();
                    frm.ShowDialog();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng đăng nhập lại !!!");
            }
        }
        public void Check()
        {
            if (txt_email.Text == "")
                MessageBox.Show(" Vui lòng nhập lại Tên tài khoản");
            else if (txt_pass.Text == "")
                MessageBox.Show("Nhập lại mật khẩu");
            else
                Login();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}