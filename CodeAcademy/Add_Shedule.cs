using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeAcademy
{
    public partial class Add_Shedule : Form
    {
        Code_Academy_DbEntities db = new Code_Academy_DbEntities();
        Group_schedule selectedSchedule;
        public Add_Shedule()
        {
            InitializeComponent();
            fillSchedule();
        }

        private void addSchedule_Click(object sender, EventArgs e)
        {
            var item = new Group_schedule();
            item.group_schedule_name = scheduleName.Text;
            item.group_begin_time = Convert.ToDateTime(beginTime.Text);
            item.group_end_time = Convert.ToDateTime(endTime.Text);
            db.Group_schedule.Add(item);
            db.SaveChanges();
            fillSchedule();
        }
        public void fillSchedule()
        {

            var t = 0;
            dataGridSchedule.Rows.Clear();
            List<Group_schedule> list = db.Group_schedule.ToList();
            foreach (var item in list)
            {
                dataGridSchedule.Rows.Add();
                dataGridSchedule.Rows[t].Cells[0].Value = item.id;
                dataGridSchedule.Rows[t].Cells[1].Value = item.group_schedule_name;
                dataGridSchedule.Rows[t].Cells[2].Value = item.group_begin_time;
                dataGridSchedule.Rows[t].Cells[3].Value = item.group_end_time;
                t++;
            }

        }

        

        private void update_Click(object sender, EventArgs e)
        {
            selectedSchedule.group_schedule_name = scheduleName.Text;
            selectedSchedule.group_begin_time = Convert.ToDateTime(beginTime.Text);
            selectedSchedule.group_end_time = Convert.ToDateTime(endTime.Text);
            db.SaveChanges();
            fillSchedule();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (db.Group_schedule.FirstOrDefault(g => g.id == selectedSchedule.id) == null)
            {
                MessageBox.Show("Message");
            }
            else
            {
                db.Group_schedule.Remove(selectedSchedule);
                db.SaveChanges();
                fillSchedule();
            }
        }

        private void dataGridSchedule_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dataGridSchedule.Rows[e.RowIndex].Cells[0].Value);
            selectedSchedule = db.Group_schedule.Find(id);
            scheduleName.Text = selectedSchedule.group_schedule_name;
            beginTime.Value = selectedSchedule.group_begin_time;
            endTime.Value = selectedSchedule.group_end_time;
        }

        private void Add_Shedule_Load(object sender, EventArgs e)
        {

        }
    }
}
