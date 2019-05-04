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
    public partial class ql_canho : Form
    {
        public ql_canho()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datacanho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-77VKD1S\SQLEXPRESS;Initial Catalog=DO_AN;Integrated Security=True");
        DataSet dgg = new DataSet();
        SqlDataAdapter da;
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
            dtach.DataSource = dt; //đổ dữ liệu vào datagridview
        }
        //public void LoadDataMonDaGoi(string maban)
        //{
        //    try
        //    {
        //        if (conn.State == ConnectionState.Closed)
        //            conn.Open();
        //        dgg = new DataSet();
        //        string selectString = "Select * from canho  where ";
        //        da = new SqlDataAdapter(selectString, conn);
        //        da.Fill(dgg, "canho");
        //        dtach.DataSource = dgg.Tables["canho"];
        //    }
        //    catch { }
        //}
        private void ql_canho_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Sua_tt n = new Sua_tt();
            n.ShowDialog();
            n.Hide();
        }

        private void Ban8_Click(object sender, EventArgs e)
        {
            ketnoicsdl();
        }
    }
}
