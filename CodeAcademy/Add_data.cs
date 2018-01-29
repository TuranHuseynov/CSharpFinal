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
    public partial class Add_data : Form
    {
        public Add_data()
        {
            InitializeComponent();
        }

        private void addTeacher_Click(object sender, EventArgs e)
        {
            TeacherMenu teacherMenu = new TeacherMenu();
            teacherMenu.ShowDialog();
        }

        private void addMentor_Click(object sender, EventArgs e)
        {
            Add_Mentor add_Mentor = new Add_Mentor();
            add_Mentor.ShowDialog();
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            Add_Student add_Student = new Add_Student();
            add_Student.ShowDialog();
        }

        private void group_Click(object sender, EventArgs e)
        {
            Add_Group group = new Add_Group();
            group.ShowDialog();
        }
    }
}
