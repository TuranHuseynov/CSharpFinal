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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void admin_Click(object sender, EventArgs e)
        {
            Admin_Enter admin = new Admin_Enter();
            admin.ShowDialog();
        }

        private void teacher_Click(object sender, EventArgs e)
        {
            TeacherLogin login = new TeacherLogin();
            login.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mentor_Register mentor_Register = new Mentor_Register();
            mentor_Register.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student_Register student_Register = new Student_Register();
            student_Register.ShowDialog();
        }

        
    }
}
