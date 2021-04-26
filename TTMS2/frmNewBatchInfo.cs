﻿using System;
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
    public partial class frmNewBatchInfo : Form
    {
        public NewBatch BatchInfo
        {
            get { return newBatchBindingSource.Current as NewBatch; }
        }
        public frmNewBatchInfo(NewBatch obj)
        {
            InitializeComponent();
            newBatchBindingSource.DataSource = obj;

        }

        private void frmNewBatchInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            newBatchBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            String AcademicYrSemester = comboAYS.Text;
            String ProgrammeID = comboProID.Text;
            int groupNumber = Convert.ToInt32(numericUpDown1.Value);
            int subGroupNumber = Convert.ToInt32(numericUpDown2.Value);

            txtGID.Text = AcademicYrSemester + ProgrammeID + groupNumber;
            txtSGID.Text = AcademicYrSemester + ProgrammeID + groupNumber + "." + subGroupNumber;
        }
    }
}
