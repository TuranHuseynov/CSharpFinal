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
    public partial class TeacherMenu : Form
    {
        Code_Academy_DbEntities db = new Code_Academy_DbEntities();
        OpenFileDialog file = new OpenFileDialog();
        private Teacher selectedTeacher;

        public TeacherMenu()
        {
            InitializeComponent();
            fillTeacher();
          
        }
        
        



        private void TeacherMenu_Load(object sender, EventArgs e)
        {
            //gender
            var gendertypes = db.Genders.ToList();
            foreach(Gender item in gendertypes)
            {
                this.cmbGender.Items.Add(item.gender_name);
            }

        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            string imageName = DateTime.Now.ToString("yyyyMMddssHHmm") + file.SafeFileName;
            WebClient webclient = new WebClient();
            string path = @"C:\Users\P104\Desktop\final app\CodeAcademy\Uploads\" + imageName;
            webclient.DownloadFile(file.FileName, path);

            var newTeacher = new Teacher();
            newTeacher.teacher_name = this.t_name.Text;
            newTeacher.teacher_surname = this.t_surname.Text;
            newTeacher.teacher_phone = this.t_phone.Text;
            newTeacher.teacher_gender_id = db.Genders.FirstOrDefault(g => g.gender_name == this.cmbGender.Text).id;
            newTeacher.teacher_email = this.t_email.Text;
            newTeacher.teacher_password = this.t_password.Text;
            newTeacher.teacher_info = this.t_info.Text;
            newTeacher.teacher_photo = path;

            db.Teachers.Add(newTeacher);
            db.SaveChanges();
            fillTeacher();

        }

        public void fillTeacher()
        {

            var t = 0;
            dataGridTeacher.Rows.Clear();
            List<Teacher> list = db.Teachers.ToList();
            foreach(Teacher item in list)
            {
                dataGridTeacher.Rows.Add();
                dataGridTeacher.Rows[t].Cells[0].Value = item.id;
                dataGridTeacher.Rows[t].Cells[1].Value = item.teacher_name;
                dataGridTeacher.Rows[t].Cells[2].Value = item.teacher_surname;
                dataGridTeacher.Rows[t].Cells[3].Value = item.teacher_email;
                dataGridTeacher.Rows[t].Cells[4].Value = item.teacher_phone;
                dataGridTeacher.Rows[t].Cells[5].Value = item.teacher_info;
                dataGridTeacher.Rows[t].Cells[6].Value = item.Gender.gender_name;
                t++;

            }

        }

        private void select_update(object sender, DataGridViewCellMouseEventArgs e)
        {
            // MessageBox.Show(dataGridTeacher.Rows[e.RowIndex].Cells[0].Value + "  ");
            int id = Convert.ToInt32(dataGridTeacher.Rows[e.RowIndex].Cells[0].Value);
            selectedTeacher = db.Teachers.Find(id);
            t_name.Text = selectedTeacher.teacher_name;
            t_surname.Text = selectedTeacher.teacher_surname;
            t_phone.Text = selectedTeacher.teacher_phone;
            cmbGender.Text = selectedTeacher.Gender.gender_name;
            t_email.Text = selectedTeacher.teacher_email;
            t_password.Text = selectedTeacher.teacher_password;
            t_info.Text = selectedTeacher.teacher_info;


           
        }

        private void btnUpdateTeacher_Click(object sender, EventArgs e)
        {

           
            selectedTeacher.teacher_name = this.t_name.Text;
            selectedTeacher.teacher_surname = this.t_surname.Text;
            selectedTeacher.teacher_phone = this.t_phone.Text;
            selectedTeacher.teacher_gender_id = db.Genders.Where(g => g.gender_name == this.cmbGender.Text).First().id;
            selectedTeacher.teacher_email = this.t_email.Text;
            selectedTeacher.teacher_password = this.t_password.Text;
            selectedTeacher.teacher_info = this.t_info.Text;
            
            db.SaveChanges();
            fillTeacher();

        }

        //private void dataGridTeacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int id = Convert.ToInt32(dataGridTeacher.Rows[e.RowIndex].Cells[0].Value);
        //    selectedTeacher = db.Teachers.Find(id);
        //    t_name.Text = selectedTeacher.teacher_name;
        //    t_surname.Text = selectedTeacher.teacher_surname;
        //    t_email.Text = selectedTeacher.teacher_email;
        //    t_phone.Text = selectedTeacher.teacher_phone;
        //    t_info.Text = selectedTeacher.teacher_info;
        //    cmbGender.Text = selectedTeacher.Gender.gender_name;
        //    t_password.Text = selectedTeacher.teacher_password;

        //}

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (db.Teachers.FirstOrDefault(m => m.id == selectedTeacher.id) == null)
            {
                MessageBox.Show("Message");
            }
            else
            {
                db.Teachers.Remove(selectedTeacher);
                db.SaveChanges();
                fillTeacher();
            }
        }

        private void selectPhoto_Click(object sender, EventArgs e)
        {
            file.ShowDialog();
            this.teacherPhoto.Image = Image.FromFile(file.FileName);
        }

        private void export_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Extentions.Export_data(dataGridTeacher, sfd.FileName);
            }
        }

        private void dataGridTeacher_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dataGridTeacher.Rows[e.RowIndex].Cells[0].Value);
            selectedTeacher = db.Teachers.Find(id);
            t_name.Text = selectedTeacher.teacher_name;
            t_surname.Text = selectedTeacher.teacher_surname;
            t_email.Text = selectedTeacher.teacher_email;
            t_phone.Text = selectedTeacher.teacher_phone;
            t_info.Text = selectedTeacher.teacher_info;
            cmbGender.Text = selectedTeacher.Gender.gender_name;
            t_password.Text = selectedTeacher.teacher_password;


        }
    }      
}
