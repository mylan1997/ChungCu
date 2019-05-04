using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lan
{
    public partial class form_dangnhap : Form
    {
        SqlConnection con = new SqlConnection(@"data source=DESKTOP-77VKD1S\SQLEXPRESS;initial catalog=QL_Chungcu;persist security info=True;user id=sa;password=sa2012;MultipleActiveResultSets=True;App=EntityFramework");
        DataCCDataContext data = new DataCCDataContext();

        public form_dangnhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void form_danhchodancu_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            var user = data.TaiKhoans.Where(tk => tk.TenDN == txtuser.Text && tk.MatKhau == txtpassword.Text).First();

            if (user != null)
            {

                var user_pq = data.Taikhoan_PhanQuyens.Where(x => x.id_ND == user.id).First();

                if (user_pq.Gioihan != false)
                {
                    MessageBox.Show("Bạn đã bị chặn !!! Hãy liên hệ admin để giải quyết");
                }
                else 
                {
                    BienToanCuc.bientoancuc.ID_PQ = user_pq.id_PQ;

                    Form_danh_muc frm = new Form_danh_muc();
                    frm.ShowDialog();
                    this.Hide();
                }
            }
            else {
                MessageBox.Show("lan lan xinh dang nhap lai");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            tracuu a = new tracuu();
            a.ShowDialog();
            a.Hide();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        
       
        private void button2_Click_1(object sender, EventArgs e)
        {
            tracuu n = new tracuu();
            n.ShowDialog();
            n.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form_update_mk a = new form_update_mk();
            a.ShowDialog();
            a.Hide();
        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        
    }
}

