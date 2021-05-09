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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            chartLecturer.Series["Categories"].Points.AddXY("Professor", 5);
            chartLecturer.Series["Categories"].Points.AddXY("Assistant Professor", 9);
            chartLecturer.Series["Categories"].Points.AddXY("Senior Lecturer(HG)", 10);
            chartLecturer.Series["Categories"].Points.AddXY("Senior Lecturer", 15);
            chartLecturer.Series["Categories"].Points.AddXY("Assistant Lecturer", 20);

            using (LocationEntities db = new LocationEntities())
            {
                chartBuilding.DataSource = db.Buildings.ToList();

                chartBuilding.Series["Building"].XValueMember = "BuildingNames";
                chartBuilding.Series["Building"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                chartBuilding.Series["Building"].YValueMembers = "NumberOfRooms";
                chartBuilding.Series["Building"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void chartBuilding_Click(object sender, EventArgs e)
        {

        }
    }
}
