using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTMS2
{
    public partial class Form2 : Form
    {
        LocationEntities2 db;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            db = new LocationEntities2();
            roomBindingSource.DataSource = db.Rooms.ToList();
        }

        private void tbRefresh_Click(object sender, EventArgs e)
        {
            roomBindingSource.DataSource = db.Rooms.ToList();
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
            using(frmRoomInfo frm = new frmRoomInfo(new Room()))
            {
                if(frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        roomBindingSource.Add(frm.RoomInfo);
                        db.Rooms.Add(frm.RoomInfo);
                        await db.SaveChangesAsync();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                   
            }
        }

        private async void tbEdit_Click(object sender, EventArgs e)
        {
            Room obj = roomBindingSource.Current as Room;
            if (obj != null)
            {

                using (frmRoomInfo frm = new frmRoomInfo(obj))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            roomBindingSource.EndEdit();
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
                int count = dataGridView2.RowCount;
                for (int i = count - 1; i >= 0; i--)
                {
                    if (dataGridView2.Rows[i].Selected)
                    {
                        db.Rooms.Remove(dataGridView2.Rows[i].DataBoundItem as Room);
                        roomBindingSource.RemoveAt(dataGridView2.Rows[i].Index);

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
                    roomBindingSource.EndEdit();
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
    }
}
