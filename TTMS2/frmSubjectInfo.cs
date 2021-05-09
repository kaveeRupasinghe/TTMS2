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
    public partial class frmSubjectInfo : Form
    {
        public Subject SubjectInfo
        {
            get { return subjectBindingSource.Current as Subject; }
        }
        public frmSubjectInfo(Subject obj)
        {
            InitializeComponent();
            subjectBindingSource.DataSource = obj;
        }

        private void frmSubjectInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            subjectBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }
    }
}
