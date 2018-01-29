using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeAcademy
{
    public partial class Add_Group : Form
    {
        Code_Academy_DbEntities db = new Code_Academy_DbEntities();
        Group selectgroup;
        public Add_Group()
        {
            InitializeComponent();
            fillGroups();
        }


        private void Add_Group_Load(object sender, EventArgs e)
        {
            foreach(var item in db.Group_types.ToList())
            {
                cmbTypeNumber.Items.Add(item.group_type_name);
            }

            foreach (var item in db.Teachers.ToList())
            {
                cmbTeacher.Items.Add(item.teacher_name);
            }

            foreach (var item in db.Mentors.ToList())
            {
                cmbMentor.Items.Add(item.mentor_name);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var typid = db.Group_types.FirstOrDefault(g => g.group_type_name == this.cmbTypeNumber.Text).id;
            var teacherid = db.Teachers.FirstOrDefault(g => g.teacher_name == this.cmbTeacher.Text).id;
            var grupid = db.Mentors.FirstOrDefault(g => g.mentor_name == this.cmbMentor.Text).id;
            var item = new Group();
            item.group_name = txtName.Text;
            item.group_type_id = typid;
            item.group_techer_id = teacherid;
            item.group_mentor_id = grupid;
            item.group_start_date = dateTimeStart.Value;
            db.Groups.Add(item);
            db.SaveChanges();
            fillGroups();
        }


        public void fillGroups()
        {

            var t = 0;
            dataGridGroup.Rows.Clear();
            List<Group> list = db.Groups.ToList();
            foreach (var item in list)
            {
                dataGridGroup.Rows.Add();
                dataGridGroup.Rows[t].Cells[0].Value = item.id;
                dataGridGroup.Rows[t].Cells[1].Value = item.group_name;
                dataGridGroup.Rows[t].Cells[2].Value = item.Group_types.group_type_name;
                dataGridGroup.Rows[t].Cells[3].Value = item.Teacher.teacher_name;
                dataGridGroup.Rows[t].Cells[4].Value = item.Mentor.mentor_name;
                dataGridGroup.Rows[t].Cells[5].Value = item.group_start_date;
                t++;

            }

        }

       



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var typid = db.Group_types.FirstOrDefault(g => g.group_type_name == this.cmbTypeNumber.Text).id;
            var teacherid = db.Teachers.FirstOrDefault(g => g.teacher_name == this.cmbTeacher.Text).id;
            var grupid = db.Mentors.FirstOrDefault(g => g.mentor_name == this.cmbMentor.Text).id;
            selectgroup.group_name = txtName.Text;
            selectgroup.group_type_id = typid;
            selectgroup.group_techer_id = teacherid;
            selectgroup.group_mentor_id = grupid;
            selectgroup.group_start_date = dateTimeStart.Value;
            db.SaveChanges();
            fillGroups();

        }

        private void dataGridGroup_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dataGridGroup.Rows[e.RowIndex].Cells[0].Value);
            selectgroup = db.Groups.Find(id);
            txtName.Text = selectgroup.group_name;
            cmbTypeNumber.Text = selectgroup.Group_types.group_type_name;
            cmbTeacher.Text = selectgroup.Teacher.teacher_name;
            cmbMentor.Text = selectgroup.Mentor.mentor_name;
            dateTimeStart.Value = selectgroup.group_start_date;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(db.Groups.FirstOrDefault(g=>g.id == selectgroup.id) == null)
            {
                MessageBox.Show("MEssage");
            }
            else
            {
                db.Groups.Remove(selectgroup);
                db.SaveChanges();
                fillGroups();
            }
        }

        private void groupTypes_Click(object sender, EventArgs e)
        {
            Add_Group_Types add_Group_Types = new Add_Group_Types();
            add_Group_Types.ShowDialog();
        }

        private void groupSchedule_Click(object sender, EventArgs e)
        {
            Add_Shedule add_Shedule = new Add_Shedule();
            add_Shedule.ShowDialog();
        }

        private void taskType_Click(object sender, EventArgs e)
        {
            AddTaskType addTaskType = new AddTaskType();
            addTaskType.ShowDialog();
        }
    }
}
