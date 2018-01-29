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
    public partial class Add_Student : Form
    {
        Code_Academy_DbEntities db = new Code_Academy_DbEntities();
        OpenFileDialog file = new OpenFileDialog();
        Student selectedStudent;
        public Add_Student()
        {
            InitializeComponent();
            fillStudent();
        }

        private void Add_Student_Load(object sender, EventArgs e)
        {
            foreach(var item in db.Groups.ToList())
            {
                cmbGroup.Items.Add(item.group_name);
            }

            foreach (var item in db.Genders.ToList())
            {
                cmbGender.Items.Add(item.gender_name);
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string imageName = DateTime.Now.ToString("yyyyMMddssHHmm") + file.SafeFileName;
            WebClient webclient = new WebClient();
            string path = @"C:\Users\P104\Desktop\final app\CodeAcademy\Uploads\" + imageName;
            webclient.DownloadFile(file.FileName, path);


            var student = new Student();
            student.student_name = s_name.Text;
            student.student_surname = s_surname.Text;
            student.student_email = s_email.Text;
            student.student_phone = s_phone.Text;
            student.student_info = s_info.Text;
            student.student_photo = path;
            student.student_github_account = s_guthub.Text;
            student.student_cap_point = Convert.ToDouble(s_CAP.Text);
            student.student_gender_id = db.Genders.FirstOrDefault(g => g.gender_name == this.cmbGender.Text).id;
            student.student_group_id = db.Groups.FirstOrDefault(q => q.group_name == this.cmbGroup.Text).id;
            student.student_password = s_password.Text;
           
            db.Students.Add(student);
            db.SaveChanges();
            fillStudent();
        }

        private void selectPhoto_Click(object sender, EventArgs e)
        {
            file.ShowDialog();
            this.studentPhoto.Image = Image.FromFile(file.FileName);
        }


        public void fillStudent()
        {

            var t = 0;
            dataGridStudent.Rows.Clear();
            List<Student> list = db.Students.ToList();
            foreach (var item in list)
            {
                dataGridStudent.Rows.Add();
                dataGridStudent.Rows[t].Cells[0].Value = item.id;
                dataGridStudent.Rows[t].Cells[1].Value = item.student_name;
                dataGridStudent.Rows[t].Cells[2].Value = item.student_surname;
                dataGridStudent.Rows[t].Cells[3].Value = item.Group.group_name;
                dataGridStudent.Rows[t].Cells[4].Value = item.Gender.gender_name;
                dataGridStudent.Rows[t].Cells[5].Value = item.student_email;
                dataGridStudent.Rows[t].Cells[6].Value = item.student_phone;
                dataGridStudent.Rows[t].Cells[7].Value = item.student_github_account;
                dataGridStudent.Rows[t].Cells[8].Value = item.student_info;
                dataGridStudent.Rows[t].Cells[9].Value = item.student_cap_point;
                dataGridStudent.Rows[t].Cells[10].Value = item.student_password;
                t++;

            }

        }

        private void dataGridStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            int id = Convert.ToInt32(dataGridStudent.Rows[e.RowIndex].Cells[0].Value);
            selectedStudent = db.Students.Find(id);
            s_name.Text = selectedStudent.student_name;
            s_surname.Text = selectedStudent.student_surname;
            cmbGroup.Text = selectedStudent.Group.group_name;
            cmbGender.Text = selectedStudent.Gender.gender_name;
            s_email.Text = selectedStudent.student_email;
            s_phone.Text = selectedStudent.student_phone;
            s_guthub.Text = selectedStudent.student_github_account;
            s_info.Text = selectedStudent.student_info;
            s_CAP.Text = selectedStudent.student_cap_point.ToString();
            s_password.Text = selectedStudent.student_password;
        }

        private void update_Click(object sender, EventArgs e)
        {
            selectedStudent.student_name = s_name.Text;
            selectedStudent.student_surname = s_surname.Text;
            selectedStudent.student_group_id = db.Groups.Where(q => q.group_name == this.cmbGroup.Text).First().id;
            selectedStudent.student_gender_id = db.Genders.Where(g => g.gender_name == this.cmbGender.Text).First().id;
            selectedStudent.student_email = s_email.Text;
            selectedStudent.student_phone = s_phone.Text;
            selectedStudent.student_github_account = s_guthub.Text;
            selectedStudent.student_info = s_info.Text;
            selectedStudent.student_cap_point = Convert.ToDouble(s_CAP.Text);
            selectedStudent.student_photo = studentPhoto.ToString();
            selectedStudent.student_password = s_password.Text;

            db.SaveChanges();
            fillStudent();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (db.Students.FirstOrDefault(s => s.id == selectedStudent.id) == null)
            {
                MessageBox.Show("Message");
            }
            else
            {
                db.Students.Remove(selectedStudent);
                db.SaveChanges();
                fillStudent();
            }
        }

       

        private void export_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Extentions.Export_data(dataGridStudent, sfd.FileName);
            }
        }
    }
}
