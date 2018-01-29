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
    public partial class ShowStudent : Form
    {
        public int id;
        Code_Academy_DbEntities db = new Code_Academy_DbEntities();
        public ShowStudent()
        {
            InitializeComponent();
        }
        

        private void ShowStudent_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(id + "");
            Selectid();
        }

        private void Selectid()
        {
            List<Student> list = db.Students.Where(s => s.Group.group_techer_id == id).ToList();
            var t = 0;
            dataGridDatata.Rows.Clear();






            foreach (var item in list)
            {
                dataGridDatata.Rows.Add();
                dataGridDatata.Rows[t].Cells[0].Value = item.student_name;
                dataGridDatata.Rows[t].Cells[1].Value = item.Group.group_name;
                dataGridDatata.Rows[t].Cells[2].Value = item.student_github_account;
                dataGridDatata.Rows[t].Cells[3].Value = item.student_cap_point;


                t++;
            }

        }

        private void export_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Extentions.Export_data(dataGridDatata, sfd.FileName);
            }
        }

        private void code_Click(object sender, EventArgs e)
        {

        }
    }
}
