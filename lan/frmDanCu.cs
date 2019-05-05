using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.SqlClient;
using System.Linq;


namespace lan
{
    public partial class frmDanCu : DevComponents.DotNetBar.RibbonForm
    {
        DataCCDataContext data = new DataCCDataContext();

        public frmDanCu()
        {
            InitializeComponent();
        }
        public void load()
        {
            grd_dancu.DataSource = data.nhankhaus.ToList();
        }
        private void frmDanCu_Load(object sender, EventArgs e)
        {
            load();
        }

        private void frmDanCu_Load_1(object sender, EventArgs e)
        {

        }
    }
}