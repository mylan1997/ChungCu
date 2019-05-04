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
    public partial class Sua_tt : Form
    {
        public Sua_tt()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thông Tin mới đã được lưu");
            this.Close();
        }
    }
}
