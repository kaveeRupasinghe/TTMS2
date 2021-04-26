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
    public partial class frmRoomInfo : Form
    {
        public Room RoomInfo
        {
            get { return roomBindingSource.Current as Room; }
        }
        public frmRoomInfo(Room obj)
        {
            InitializeComponent();
            roomBindingSource.DataSource = obj;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtRoomName_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRoomInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnsaveR_Click(object sender, EventArgs e)
        {
            roomBindingSource.EndEdit();
            DialogResult = DialogResult.OK;
        }

        private void txtRoomType_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
