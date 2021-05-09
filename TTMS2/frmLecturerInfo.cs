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
    public partial class frmLecturerInfo : Form
    {
        public Lecturer LecturerInfo
        {
            get { return lecturerBindingSource.Current as Lecturer; }
        }
        public frmLecturerInfo(Lecturer obj)
        {
            InitializeComponent();
            lecturerBindingSource.DataSource = obj;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void frmLecturerInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lecturerBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
