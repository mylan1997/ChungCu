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
    public partial class hoa_don : Form
    {
        public hoa_don()
        {
            InitializeComponent();
        }

        private void hoa_don_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DO_ANDataSet.hoadon' table. You can move, or remove it, as needed.
            this.hoadonTableAdapter.Fill(this.DO_ANDataSet.hoadon);

            this.reportViewer1.RefreshReport();
        }
    }
}
