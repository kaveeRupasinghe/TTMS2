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
    public partial class Form5 : Form
    {
        LocationEntities5 db;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            db = new LocationEntities5();
            rooBindingSource.DataSource = db.Roos.ToList();
        }

        private void tbRefresh_Click(object sender, EventArgs e)
        {
            rooBindingSource.DataSource = db.Roos.ToList();
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

        private async void tbAdd_Click(object sender, EventArgs e)
        {
            using (frmRooInfo frm = new frmRooInfo(new Roo()))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        rooBindingSource.Add(frm.RooInfo);
                        db.Roos.Add(frm.RooInfo);
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
            Roo obj = rooBindingSource.Current as Roo;
            if (obj != null)
            {

                using (frmRooInfo frm = new frmRooInfo(obj))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            rooBindingSource.EndEdit();
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
            if (MessageBox.Show("Are you sure to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //for(int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                //{
                //    db.Building.Remove(dataGridView1.SelectedRows[i].DataBoundItem as Building);
                //    buildingBindingSource.RemoveAt(dataGridView1.SelectedRows[i].Index);
                //}
                int count = dataGridView5.RowCount;
                for (int i = count - 1; i >= 0; i--)
                {
                    if (dataGridView5.Rows[i].Selected)
                    {
                        db.Roos.Remove(dataGridView5.Rows[i].DataBoundItem as Roo);
                        rooBindingSource.RemoveAt(dataGridView5.Rows[i].Index);

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
                    rooBindingSource.EndEdit();
                    await db.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchRoom_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (DataTable dt = new DataTable("Roo"))
                    {
                        using (SqlCommand cmd = new SqlCommand("select *from Roo where RoomNumber=@RoomNumber or RoomName like @RoomName", cn))
                        {
                            cmd.Parameters.AddWithValue("RoomNumber", txtSearch.Text);
                            cmd.Parameters.AddWithValue("RoomName", String.Format("%{0}%", txtSearch.Text));
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);
                            dataGridView5.DataSource = dt;
                            //lblTotal.Text = $"Total Records: {dataGridView5.RowCount}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void btnSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnSearch.PerformClick();
        }
    }
}
