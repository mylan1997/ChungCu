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
    public partial class tracuu : Form
    {
        public tracuu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-77VKD1S\SQLEXPRESS;Initial Catalog=DO_AN;Integrated Security=True");
        private void ketnoicsdl()
        {
            cnn.Open();
            string sql = "select * from canho";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            datatracuu.DataSource = dt; //đổ dữ liệu vào datagridview
        }
        private void tracuu_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }
    }
}
