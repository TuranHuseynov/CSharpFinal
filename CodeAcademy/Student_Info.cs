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
    public partial class Student_Info : Form
    {
        Code_Academy_DbEntities db = new Code_Academy_DbEntities();

        Student selectedstud;

        public Student_Info(Student stu)
        {
            selectedstud = stu;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Student_Tasks metask = new Student_Tasks();

            metask.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Student_Tasks mytask = new Student_Tasks();
            mytask.Stud_Id = Convert.ToInt32(this.lblcagir.Text);
            mytask.ShowDialog();
        }

        private void Student_Info_Load(object sender, EventArgs e)
        {
            List<int> task_types = new List<int>();
            List<Task> tasks = db.Tasks.Where(t => t.task_student_id == selectedstud.id).ToList();


            foreach (Task item in tasks)
            {
                if (!task_types.Contains(item.task_type_id))
                {
                    task_types.Add(item.task_type_id);
                }
            }


            int count = 0;
            double sum = 0;
            double cap_point = 0;
            double rate = 0;
            double average = 0;
            foreach (int item in task_types)
            {
                count = tasks.Where(t => t.task_type_id == item).Count();
                sum = tasks.Where(t => t.task_type_id == item).Select(t => t.task_point).Sum();
                rate = db.Task_types.First(t => t.id == item).task_type_rate;
                average += (sum / count) * rate;
                cap_point = average * 0.05;
            }


            Student selectedStudent = db.Students.Find(selectedstud.id);
            
            selectedStudent.student_cap_point = cap_point;
            db.SaveChanges();
            this.s_Cap.Text = Math.Round(selectedstud.student_cap_point, 2).ToString();




            this.s_Cap.Text = selectedstud.student_cap_point.ToString();
        }
    }  
}
