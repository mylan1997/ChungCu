using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace lan
{
    public partial class RibbonForm1 : DevComponents.DotNetBar.RibbonForm
    {
        public RibbonForm1()
        {
            InitializeComponent();
        }

        private void btn_canho_Click(object sender, EventArgs e)
        {
            frmCanHo frm = new frmCanHo();

            frm.MdiParent = this;
            frm.Show();
            frm.Dock = DockStyle.Fill;
        }

        private void btn_dsnv_Click(object sender, EventArgs e)
        {
            frmNhanvien frm = new frmNhanvien();

            frm.MdiParent = this;
            frm.Show();
            frm.Dock = DockStyle.Fill;
        }

        private void btn_dancu_Click(object sender, EventArgs e)
        {
            frmDanCu frm = new frmDanCu();
            frm.MdiParent = this;
            frm.Show();
            frm.Dock = DockStyle.Fill;
        }
    }
}