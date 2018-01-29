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
    public partial class Student_Register : Form
    {
        Code_Academy_DbEntities db = new Code_Academy_DbEntities();
        public Student_Register()
        {
            InitializeComponent();
        }

        private void Student_Register_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            foreach (var item in db.Students.ToList())
            {

                if (item.student_email == txt_s_email.Text && item.student_password == txt_s_pass.Text)
                {
                    Student stud = db.Students.FirstOrDefault(s => s.student_email==item.student_email && s.student_password == item.student_password);
                    Student_Info student_Info = new Student_Info(stud);
                    student_Info.s_name.Text = item.student_name;
                    student_Info.s_surname.Text = item.student_surname;
                    student_Info.s_email.Text = item.student_email;
                    student_Info.s_phone.Text = item.student_phone;
                    student_Info.s_info.Text = item.student_info;
                    student_Info.s_gender.Text = item.Gender.gender_name;
                    student_Info.s_pass.Text = item.student_password;
                    student_Info.s_photo.ImageLocation = item.student_photo;
                    student_Info.s_github.Text = item.student_github_account;
                    student_Info.s_Cap.Text = item.student_cap_point.ToString();
                    student_Info.s_group.Text = item.Group.group_name;
                    student_Info.Show();
                }
            }
        }
        
    }
}
