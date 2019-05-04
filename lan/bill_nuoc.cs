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
    public partial class bill_nuoc : Form
    {
        public bill_nuoc()
        {
            InitializeComponent();
        }

        private void bill_nuoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DO_ANDataSet.nuoc' table. You can move, or remove it, as needed.
            this.nuocTableAdapter.Fill(this.DO_ANDataSet.nuoc);

            this.reportViewer1.RefreshReport();
        }
    }
}
