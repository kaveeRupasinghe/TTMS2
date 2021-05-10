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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //loading
            //sprint2
        }

        private void customizeDesign()
        {
            panelStudentSubmenu.Visible = false;
            panelLocationSubmenu.Visible = false;
            panelWorkingSubmenu.Visible = false;
            panelSessionSubmenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelStudentSubmenu.Visible == true)
                panelStudentSubmenu.Visible = false;
            if (panelLocationSubmenu.Visible == true)
                panelLocationSubmenu.Visible = false;
            if (panelWorkingSubmenu.Visible == true)
                panelWorkingSubmenu.Visible = false;
            if (panelSessionSubmenu.Visible == true)
                panelSessionSubmenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false; 
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildForm(new Form8());
            hideSubMenu();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            showSubMenu(panelStudentSubmenu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Form6());
            hideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form7());
            hideSubMenu();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideSubMenu();

        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            showSubMenu(panelLocationSubmenu);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openChildForm(new Form1());
            hideSubMenu();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            openChildForm(new Form5());
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnWorkings_Click(object sender, EventArgs e)
        {
            showSubMenu(panelWorkingSubmenu);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnSession_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSessionSubmenu);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnLecturer_Click(object sender, EventArgs e)
        {
            openChildForm(new Form9());

            hideSubMenu();

        }

        private void btnTag_Click(object sender, EventArgs e)
        {
            openChildForm(new Form4());
            hideSubMenu();

        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            openChildForm(new Form11());
            hideSubMenu();

        }

        private void btnTmetable_Click(object sender, EventArgs e)
        {
            //hideSubMenu();

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
