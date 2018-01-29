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
    public partial class Student_Tasks : Form
    {
        
        Code_Academy_DbEntities db = new Code_Academy_DbEntities();
        public int Stud_Id { get; set; }
        Student selectstudent;
        public Student_Tasks()
        {
            InitializeComponent();
        }

       

         private void Student_Tasks_Load(object sender, EventArgs e)
        {
                cagir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Stud_Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            selectstudent = db.Students.Find(Stud_Id);
        }


        



        private void cagir()
        {
            var t = 0;
            dataGridView1.Rows.Clear();
            List<Task> list = db.Tasks.Where(v => v.task_student_id == Stud_Id).ToList();
            foreach (var item in list)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[t].Cells[0].Value = item.Group.group_name;   
                dataGridView1.Rows[t].Cells[1].Value = item.task_start_date;
                dataGridView1.Rows[t].Cells[2].Value = item.task_end_date;
                dataGridView1.Rows[t].Cells[3].Value = item.task_point;

                t++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Extentions.Export_data(dataGridView1, sfd.FileName);
            }
        }
    }
}
