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
    public partial class TeacherLogin : Form
    {
        Code_Academy_DbEntities db = new Code_Academy_DbEntities();
        public TeacherLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
         
            foreach(var item in db.Teachers.ToList())
            {
                if(item.teacher_email == txtemail.Text && item.teacher_password == txtpassworrd.Text)
                {
                    Teacher_info info = new Teacher_info();
                    info.t_name.Text = item.teacher_name;
                    info.t_surname.Text = item.teacher_surname;
                    info.t_email.Text = item.teacher_email;
                    info.t_phone.Text = item.teacher_phone;
                    info.t_info.Text = item.teacher_info;
                    info.t_gender.Text = item.Gender.gender_name;
                    info.t_pass.Text = item.teacher_password;
                    info.lbl_id.Text = item.id.ToString();
                    info.t_photo.ImageLocation = item.teacher_photo;
                    info.ShowDialog();
                }
                else
                {
                    elselabel.Text = "Your email or Password incorrect";
                }
            }
        }

        private void TeacherLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
