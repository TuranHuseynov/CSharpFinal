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
    public partial class Mentor_Register : Form
    {
        Code_Academy_DbEntities db = new Code_Academy_DbEntities();
        public Mentor_Register()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            
            foreach (var item in db.Mentors.ToList())
            {

                if (item.mentor_email == userName.Text && item.mentor_password == pass.Text)
                {
                    Mentor_Info mentor_Info = new Mentor_Info();
                    mentor_Info.name.Text = item.mentor_name;
                    mentor_Info.surname.Text = item.mentor_surname;
                    mentor_Info.email.Text = item.mentor_email;
                    mentor_Info.phone.Text = item.mentor_phone;
                    mentor_Info.info.Text = item.mentor_info;
                    mentor_Info.gender.Text = item.Gender.gender_name;
                    mentor_Info.pass.Text = item.mentor_password;
                    mentor_Info.photo.ImageLocation = item.mentor_photo;
                    mentor_Info.Show();
                }
                else
                {
                    elselabel.Text = "Your email or password incorrect";
                }
            }
        }

       
    }
}
