using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Linq;

namespace lan
{
    public partial class frmCanHo : DevComponents.DotNetBar.RibbonForm
    {
        DataCCDataContext data = new DataCCDataContext();

        public frmCanHo()
        {
            InitializeComponent();
        }
        public void load()
        {
            grd_canho.DataSource = data.canhos.ToList();
        }
        private void frm_Load(object sender, EventArgs e)
        {
            load();
        }
        private void buttonX2_Click(object sender, EventArgs e)
        {

        }

        private void frmCanHo_Load(object sender, EventArgs e)
        {

        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }
    }
}