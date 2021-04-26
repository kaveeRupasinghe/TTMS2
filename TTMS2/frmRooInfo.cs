using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTMS2
{
    public partial class frmRooInfo : Form
    {
        public Roo RooInfo
        {
            get { return rooBindingSource.Current as Roo; }
        }
        public frmRooInfo(Roo obj)
        {
            InitializeComponent();
            rooBindingSource.DataSource = obj;
        }

        private void frmRooInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnsaveR_Click(object sender, EventArgs e)
        {
            rooBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }
    }
}
