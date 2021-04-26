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
    public partial class frmBuildingInfo : Form
    {
        public Building BuildingInfo
        {
            get
            {
                return buildingBindingSource.Current as Building;
            }
        }
        public frmBuildingInfo(Building obj)
        {
            InitializeComponent();
            buildingBindingSource.DataSource = obj;
        }

        private void frmBuildingInfo_Load(object sender, EventArgs e)
        {
             
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            buildingBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }
    }
}
