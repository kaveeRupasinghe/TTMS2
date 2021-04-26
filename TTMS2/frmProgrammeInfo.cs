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
    public partial class frmProgrammeInfo : Form
    {
        public Programme ProgrammeInfo
        {
            get { return programmeBindingSource.Current as Programme; }
        }
        public frmProgrammeInfo(Programme obj)
        {
            InitializeComponent();
            programmeBindingSource.DataSource = obj;
        }

        private void frmProgrammeInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            programmeBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }
    }
}
