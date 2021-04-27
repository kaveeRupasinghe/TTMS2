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
    public partial class Form4 : Form
    {
        LocationEntities3 db;
        public Form4()
        {
            InitializeComponent();
        }

        //--------------------

        //-------------


        private void Form4_Load(object sender, EventArgs e)
        {
            db = new LocationEntities3();
            tagBindingSource.DataSource = db.Tags.ToList();
        }

        private void tbRefresh_Click(object sender, EventArgs e)
        {
            tagBindingSource.DataSource = db.Tags.ToList();
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
            using (frmTagInfo frm = new frmTagInfo(new Tag()))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        tagBindingSource.Add(frm.TagInfo);
                        db.Tags.Add(frm.TagInfo);
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
            Tag obj = tagBindingSource.Current as Tag;
            if (obj != null)
            {

                using (frmTagInfo frm = new frmTagInfo(obj))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            tagBindingSource.EndEdit();
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
                int count = dataGridView3.RowCount;
                for (int i = count - 1; i >= 0; i--)
                {
                    if (dataGridView3.Rows[i].Selected)
                    {
                        db.Tags.Remove(dataGridView3.Rows[i].DataBoundItem as Tag);
                        tagBindingSource.RemoveAt(dataGridView3.Rows[i].Index);

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
                    tagBindingSource.EndEdit();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (DataTable dt = new DataTable("Tags"))
                    {
                        using (SqlCommand cmd = new SqlCommand("select *from Tags where TagID=@TagID or TagName like @TagName", cn))
                        {
                            cmd.Parameters.AddWithValue("TagID", txtSearch.Text);
                            cmd.Parameters.AddWithValue("TagName", String.Format("%{0}%", txtSearch.Text));
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);
                            dataGridView3.DataSource = dt;
                            //lblTotal.Text = $"Total Records: {dataGridView6.RowCount}";
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
