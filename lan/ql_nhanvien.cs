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
    public partial class ql_nhanvien : Form
    {
         private static ql_nhanvien _instance;
         public static ql_nhanvien Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ql_nhanvien();
                return _instance;
            }
         }
        private void dgrvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        SqlConnection conn;
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        public ql_nhanvien()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-BHVD8RR\SQLEXPRESS;Initial Catalog=DO_AN;Integrated Security=True");
            InitializeComponent();
        }
         public void Loaddulieu_Nhanvien()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string load = "select * from NhanVien";
            da = new SqlDataAdapter(load, conn);
            da.Fill(ds, "NhanVien");
            dtanhanvien.DataSource = ds.Tables["NhanVien"];
        }
        public bool KiemtraPrimarykeyNhanVien(string dieukien)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string select = "select count(*) from NhanVien where MaNhanVien='" + dieukien + "'";
            SqlCommand cmd = new SqlCommand(select, conn);
            int count = (int)cmd.ExecuteScalar();
            if (count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }


        }
        public int Kiemtrarong()
        {
            if (txtHoten.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên !", "erro");
                return 1;
            }
            else if (txtManhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên !", "erro");
                return 1;
            }
            else if (txtNgaysinh.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào ngày sinh !", "erro");
                return 1;
            }
            else if (txtSoDienThoai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại !", "erro");
                return 1;
            }
                 else if (txtdiachi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ !", "erro");
                return 1;
            }
            else
            {
                return 0;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            if (txtHoten.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên !", "erro");
            }
            else if (txtManhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên !", "erro");
            }
            else if (txtNgaysinh.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập vào ngày sinh !", "erro");
            }
            else if (txtSoDienThoai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại !", "erro");
            }
            else
            {
                if (KiemtraPrimarykeyNhanVien(txtManhanvien.Text) == true)
                {
                    MessageBox.Show("Du lieu ban nhap da ton tai xin vui long nhap lai", "Loi nhap du lieu", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    txtManhanvien.Focus();

                }
                else
                {
                    DataRow dr = ds.Tables["NhanVien"].NewRow();
                    dr["MaNhanVien"] = txtManhanvien.Text;
                    dr["TenNhanVien"] = txtHoten.Text;
                    dr["NgaySinh"] = txtNgaysinh.Text;
                    if (rdoNam.Checked == true)
                    {
                        dr["GioiTinh"] = "Nam";
                    }
                    else
                    {
                        dr["GioiTinh"] = "Nu";
                    }
                    dr["SoDienThoai"] = txtSoDienThoai.Text;
                    ds.Tables["NhanVien"].Rows.Add(dr);
                    SqlCommandBuilder cb = new SqlCommandBuilder(da);
                    da.Update(ds, "NhanVien");
                    dtanhanvien.DataSource = ds.Tables["NhanVien"];
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgrvNhanVien_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-77VKD1S\SQLEXPRESS;Initial Catalog=DO_AN;Integrated Security=True");
        private void ketnoicsdl()
        {
            cnn.Open();
            string sql = "select * from nhanvien";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dtanhanvien.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ql_nhanvien_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }
        public void sinhmatudong()
        {
            //DataTable dt = new DataTable();
            //dt = nvMod.GetAllData();

        }
    }
}
