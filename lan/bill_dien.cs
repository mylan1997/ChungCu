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
    public partial class bill_dien : Form
    {
        public bill_dien()
        {
            InitializeComponent();
        }

        private void bill_dien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DO_ANDataSet.dien' table. You can move, or remove it, as needed.
            this.dienTableAdapter.Fill(this.DO_ANDataSet.dien);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
