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
    public partial class Form10 : Form
    {
        LocationEntities10 db;

        public Form10()
        {
            InitializeComponent();
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
            using (frmSubjectInfo frm = new frmSubjectInfo(new Subject()))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        subjectBindingSource.Add(frm.SubjectInfo);
                        db.Subjects.Add(frm.SubjectInfo);
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

                using (frmSubjectInfo frm = new frmSubjectInfo(obj))
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
                int count = dataGridView10.RowCount;
                for (int i = count - 1; i >= 0; i--)
                {
                    if (dataGridView10.Rows[i].Selected)
                    {
                        db.Subjects.Remove(dataGridView10.Rows[i].DataBoundItem as Subject);
                        subjectBindingSource.RemoveAt(dataGridView10.Rows[i].Index);

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

        private void button1_Click(object sender, EventArgs e)
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
                    using (DataTable dt = new DataTable("Subject"))
                    {
                        using (SqlCommand cmd = new SqlCommand("select *from Subject where Scode=@Scode or Sname like @Sname", cn))
                        {
                            cmd.Parameters.AddWithValue("Scode", txtSearch.Text);
                            cmd.Parameters.AddWithValue("Sname", String.Format("%{0}%", txtSearch.Text));
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);
                            dataGridView10.DataSource = dt;
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

        private void Form10_Load(object sender, EventArgs e)
        {
            db = new LocationEntities10();
            subjectBindingSource.DataSource = db.Subjects.ToList();
        }
    }
}
