using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace lan
{
    public partial class ql_dancu : Form
    {
        public ql_dancu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-77VKD1S\SQLEXPRESS;Initial Catalog=DO_AN;Integrated Security=True");
        DataSet dgg = new DataSet();
        SqlDataAdapter da;
        private void ketnoicsdl()
        {
            cnn.Open();
            string sql = "select * from dancu";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            datadancu.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void ql_dancu_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            them n = new them();
            n.ShowDialog();
            n.Hide();
        }
    }
}
