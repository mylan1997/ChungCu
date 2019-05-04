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
    public partial class thongke : Form
    {
        public thongke()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //form_baocao_thu a = new form_baocao_thu();
            //a.ShowDialog();
            //a.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bao_cao b = new bao_cao();
            b.ShowDialog();
            b.Hide();
        }
    }
}
