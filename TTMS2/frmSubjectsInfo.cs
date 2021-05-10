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
    public partial class frmSubjectsInfo : Form
    {
        public Subject subjectInfo
        {
            get { return subjectBindingSource.Current as Subject; }
        }
        public frmSubjectsInfo(Subject obj)
        {
            InitializeComponent();
            subjectBindingSource.DataSource = obj;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmSubjectsInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            subjectBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }
    }
}
