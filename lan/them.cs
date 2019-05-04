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
    public partial class them : Form
    {
        public them()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nhankhau_phieu a = new nhankhau_phieu();
            a.ShowDialog();
            a.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vang m = new vang();
            m.ShowDialog();
            m.Hide();
        }
    }
}
