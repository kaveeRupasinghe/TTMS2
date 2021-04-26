using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace TTMS2
{
    public partial class Form1 : Form
    {
        LocationEntities db;
         
        public Form1()
        {
            InitializeComponent();
        }

        private void tbRefresh_Click(object sender, EventArgs e)
        {
            buildingBindingSource.DataSource = db.Buildings.ToList();
            foreach (DbEntityEntry entry in db.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case System.Data.Entity.EntityState.Added:
                        entry.State = System.Data.Entity.EntityState.Detached;
                        break;
                    case System.Data.Entity.EntityState.Modified:
                        entry.State = System.Data.Entity.EntityState.Unchanged;
                        break;
                    case System.Data.Entity.EntityState.Deleted:
                        entry.Reload();
                        break;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new LocationEntities();
            buildingBindingSource.DataSource = db.Buildings.ToList();
        }

        private async void tbAdd_Click(object sender, EventArgs e)
        {
            using (frmBuildingInfo frm = new frmBuildingInfo(new Building()))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        buildingBindingSource.Add(frm.BuildingInfo);
                        db.Buildings.Add(frm.BuildingInfo);
                        await db.SaveChangesAsync();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void tbEdit_Click(object sender, EventArgs e)
        {
            Building obj = buildingBindingSource.Current as Building;
            if (obj != null)
            {

                using (frmBuildingInfo frm = new frmBuildingInfo(obj))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            buildingBindingSource.EndEdit();
                            await db.SaveChangesAsync();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

        }

        private void tbDelete_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Are you sure to delete this record ?","Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //for(int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                //{
                //    db.Building.Remove(dataGridView1.SelectedRows[i].DataBoundItem as Building);
                //    buildingBindingSource.RemoveAt(dataGridView1.SelectedRows[i].Index);
                //}
                int count = dataGridView1.RowCount;
                for (int i = count - 1; i >= 0; i--)
                {
                    if (dataGridView1.Rows[i].Selected)
                    {
                        db.Buildings.Remove(dataGridView1.Rows[i].DataBoundItem as Building);
                        buildingBindingSource.RemoveAt(dataGridView1.Rows[i].Index);

                    }
                }
            }
        }

        private async void tbSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save the changes ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    buildingBindingSource.EndEdit();
                    await db.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnclose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using(SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using(DataTable dt = new DataTable("Building"))
                    {
                        using(SqlCommand cmd = new SqlCommand("select *from Building where BuildingNumber=@BuildingNumber or BuildingNames like @BuildingNames", cn))
                        {
                            cmd.Parameters.AddWithValue("BuildingNumber", txtSearch.Text);
                            cmd.Parameters.AddWithValue("BuildingNames", String.Format("%{0}%", txtSearch.Text));
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) //enter
                btnSearch.PerformClick();
        }
    }

    
}
  