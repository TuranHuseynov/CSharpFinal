using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace CodeAcademy
{
    public partial class Add_Task : Form
    {

        Code_Academy_DbEntities db = new Code_Academy_DbEntities();
        Task selectedTask;
        public Add_Task()
        {
            InitializeComponent();
            fillTasks();
        }

        private void Add_Task_Load(object sender, EventArgs e)
        {
            foreach(var item in db.Task_types)
            {
                cmbTaskType.Items.Add(item.task_type_name);

            }

            foreach(var item in db.Groups)
            {
                cmbTaskGroup.Items.Add(item.group_name);
            }

            foreach (var item in db.Students)
            {
                cmbTaskStudent.Items.Add(item.student_name);
            }

            

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            var newTask = new Task();
            newTask.task_type_id = db.Task_types.FirstOrDefault(t => t.task_type_name == this.cmbTaskType.Text).id;
            newTask.task_start_date = Convert.ToDateTime(this.dateTaskStart.Value);
            newTask.task_end_date = Convert.ToDateTime( this.dateTaskEnd.Value);
            newTask.task_point = Convert.ToDouble(this.txtTaskPoint.Text);
            newTask.task_source = this.txtsourche.Text;
            newTask.task_note = this.txttask.Text;
            var grp = db.Groups.FirstOrDefault(g => g.group_name == this.cmbTaskGroup.Text);
            var std = db.Students.FirstOrDefault(s => s.student_name == this.cmbTaskStudent.Text);
            if (grp != null)
            {
                newTask.task_group_id = grp.id;
            }
            else
            {
                newTask.task_group_id = null;
            }

            if (std != null)
            {
                newTask.task_student_id = std.id;
            }
            else
            {
                newTask.task_student_id = null;
            }



            db.Tasks.Add(newTask);
            db.SaveChanges();
            fillTasks();
        }


        public void fillTasks()
        {

            var t = 0;
            datagridTask.Rows.Clear();
            List<Task> list = db.Tasks.ToList();
            foreach (Task item in list)
            {
                datagridTask.Rows.Add();
                datagridTask.Rows[t].Cells[0].Value = item.id;
                datagridTask.Rows[t].Cells[1].Value = item.Task_types.task_type_name;
                datagridTask.Rows[t].Cells[2].Value = item.task_start_date;
                datagridTask.Rows[t].Cells[3].Value = item.task_end_date;
                datagridTask.Rows[t].Cells[4].Value = item.task_source;
                datagridTask.Rows[t].Cells[5].Value = item.task_note;
                datagridTask.Rows[t].Cells[6].Value = item.task_point;
                t++;

            }

        }

        private void update_Click(object sender, EventArgs e)
        {
            selectedTask.task_type_id = db.Task_types.FirstOrDefault(t => t.task_type_name == this.cmbTaskType.Text).id;
            selectedTask.task_start_date = dateTaskStart.Value;
            selectedTask.task_end_date = dateTaskEnd.Value;
            selectedTask.task_point = Convert.ToDouble(txtTaskPoint.Text);
            selectedTask.task_source = txtsourche.Text;
            selectedTask.task_note = txttask.Text;
            selectedTask.task_group_id = db.Groups.FirstOrDefault(g => g.group_name == this.cmbTaskGroup.Text).id;
            selectedTask.task_group_id = db.Students.FirstOrDefault(s => s.student_name == this.cmbTaskStudent.Text).id;
            db.SaveChanges();
            fillTasks();
        }

        private void delete_Click(object sender, EventArgs e)
        {

            if (db.Tasks.FirstOrDefault(m => m.id == selectedTask.id) == null)
            {
                MessageBox.Show("Message");
            }
            else
            {
                db.Tasks.Remove(selectedTask);
                db.SaveChanges();
                fillTasks();
            }
        }

        private void datagridTask_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(datagridTask.Rows[e.RowIndex].Cells[0].Value);
            selectedTask = db.Tasks.Find(id);
            dateTaskStart.Value = selectedTask.task_start_date;
            dateTaskEnd.Value = selectedTask.task_end_date;
            txtTaskPoint.Text = selectedTask.task_point.ToString();
            txtsourche.Text = selectedTask.task_source;
            txttask.Text = selectedTask.task_note;
            cmbTaskGroup.Text = selectedTask.Group.group_name;
            cmbTaskStudent.Text = selectedTask.Student.student_name;
        }

        private void export_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Extentions.Export_data(datagridTask, sfd.FileName);
            }
        }
    }
}
