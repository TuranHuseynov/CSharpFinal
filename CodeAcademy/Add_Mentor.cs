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
    public partial class Add_Mentor : Form
    {
        Code_Academy_DbEntities db = new Code_Academy_DbEntities();
        OpenFileDialog file = new OpenFileDialog();
        Mentor selectedMentor;
        public Add_Mentor()
        {
            InitializeComponent();
            fillMentor();
        }

        private void Add_Mentor_Load(object sender, EventArgs e)
        {
            foreach (var item in db.Genders.ToList())
            {
                mentorGender.Items.Add(item.gender_name);
            }
        }

        private void addMentor_Click(object sender, EventArgs e)
        {
            string imageName = DateTime.Now.ToString("yyyyMMddssHHmm") + file.SafeFileName;
            WebClient webclient = new WebClient();
            string path = @"C:\Users\P104\Desktop\final app\CodeAcademy\Uploads\" + imageName;
            webclient.DownloadFile(file.FileName, path);


            var item = new Mentor();
            item.mentor_name = mentorName.Text;
            item.mentor_surname = mentorSurname.Text;
            item.mentor_email = mentorEmail.Text;
            item.mentor_phone = mentorPhone.Text;
            item.mentor_info = mentorInfo.Text;
            item.mentor_gender_id = db.Genders.Where(g => g.gender_name == this.mentorGender.Text).First().id;
            item.mentor_password = mentorPassword.Text;
            item.mentor_photo = path;
            db.Mentors.Add(item);
            db.SaveChanges();
            fillMentor();
        }

        private void selectPhoto_Click(object sender, EventArgs e)
        {
            file.ShowDialog();
            this.mentorPhoto.Image = Image.FromFile(file.FileName);
        }

        public void fillMentor()
        {

            var t = 0;
            dataGridMentor.Rows.Clear();
            List<Mentor> list = db.Mentors.ToList();
            foreach (var item in list)
            {
                dataGridMentor.Rows.Add();
                dataGridMentor.Rows[t].Cells[0].Value = item.id;
                dataGridMentor.Rows[t].Cells[1].Value = item.mentor_name;
                dataGridMentor.Rows[t].Cells[2].Value = item.mentor_surname;
                dataGridMentor.Rows[t].Cells[3].Value = item.mentor_email;
                dataGridMentor.Rows[t].Cells[4].Value = item.mentor_phone;
                dataGridMentor.Rows[t].Cells[5].Value = item.mentor_info;
                dataGridMentor.Rows[t].Cells[6].Value = item.Gender.gender_name;
                t++;

            }

        }


        private void updateMentor_Click(object sender, EventArgs e)
        {
            selectedMentor.mentor_name = mentorName.Text;
            selectedMentor.mentor_surname = mentorSurname.Text;
            selectedMentor.mentor_email = mentorEmail.Text;
            selectedMentor.mentor_phone = mentorPhone.Text;
            selectedMentor.mentor_info = mentorInfo.Text;
            selectedMentor.mentor_gender_id = db.Genders.Where(g => g.gender_name == this.mentorGender.Text).First().id;
            selectedMentor.mentor_password = mentorPassword.Text;

            db.SaveChanges();
            fillMentor();

        }

        private void deleteMentor_Click(object sender, EventArgs e)
        {
            if (db.Mentors.FirstOrDefault(m=>m.id==selectedMentor.id)==null)
            {
                MessageBox.Show("Message");
            }
            else
            {
                db.Mentors.Remove(selectedMentor);
                db.SaveChanges();
                fillMentor();
            }
        }

        private void dataGridMentor_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dataGridMentor.Rows[e.RowIndex].Cells[0].Value);
            selectedMentor = db.Mentors.Find(id);
            mentorName.Text = selectedMentor.mentor_name;
            mentorSurname.Text = selectedMentor.mentor_surname;
            mentorPhone.Text = selectedMentor.mentor_phone;
            mentorGender.Text = selectedMentor.Gender.gender_name;
            mentorEmail.Text = selectedMentor.mentor_email;
            mentorPassword.Text = selectedMentor.mentor_password;
            mentorInfo.Text = selectedMentor.mentor_info;
        }

        private void export_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Extentions.Export_data(dataGridMentor, sfd.FileName);
            }
        }
    }
}
