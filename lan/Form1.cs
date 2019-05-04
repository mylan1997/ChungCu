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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
                MessageBox.Show("Bạn chưa nhập username!", "erro");
            else if (txtpassword.Text == "")
                MessageBox.Show("Bạn chưa nhập password !", "erro");
            else
            {
                if (txtuser.Text == "admin" && txtpassword.Text == "admin")
                {
                    Form_danh_muc frm = new Form_danh_muc();
                    frm.ShowDialog();
                    //frm.Hide();

                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng vui lòng nhập lại !", "Erro");
                    txtpassword.Clear();
                    txtuser.Focus();
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
