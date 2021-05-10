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
    public partial class Form11 : Form
    {
        LocationEntities11 db;
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            db = new LocationEntities11();
            subjectBindingSource.DataSource = db.Subjects.ToList();

        }

        private void tbRefresh_Click(object sender, EventArgs e)
        {
            subjectBindingSource.DataSource = db.Subjects.ToList();
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
            using (frmSubjectsInfo frm = new frmSubjectsInfo(new Subject()))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        subjectBindingSource.Add(frm.subjectInfo);
                        db.Subjects.Add(frm.subjectInfo);
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
            Subject obj = subjectBindingSource.Current as Subject;
            if (obj != null)
            {

                using (frmSubjectsInfo frm = new frmSubjectsInfo(obj))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            subjectBindingSource.EndEdit();
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
                int count = dataGridView11.RowCount;
                for (int i = count - 1; i >= 0; i--)
                {
                    if (dataGridView11.Rows[i].Selected)
                    {
                        db.Subjects.Remove(dataGridView11.Rows[i].DataBoundItem as Subject);
                        subjectBindingSource.RemoveAt(dataGridView11.Rows[i].Index);

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
                    subjectBindingSource.EndEdit();
                    await db.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (DataTable dt = new DataTable("Subjects"))
                    {
                        using (SqlCommand cmd = new SqlCommand("select *from Subjects where SubCode=@SubCode or SubName like @SubName", cn))
                        {
                            cmd.Parameters.AddWithValue("SubCode", txtSearch.Text);
                            cmd.Parameters.AddWithValue("SubName", String.Format("%{0}%", txtSearch.Text));
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);
                            dataGridView11.DataSource = dt;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
