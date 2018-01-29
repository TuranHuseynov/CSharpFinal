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
    public partial class Teacher_info : Form
    {
        
        public Teacher_info()
        {
            InitializeComponent();
        }

        private void btnaddtask_Click(object sender, EventArgs e)
        {
            Add_Task addtask = new Add_Task();
            addtask.ShowDialog();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            ShowStudent studentinfo = new ShowStudent();
            studentinfo.id = Convert.ToInt32(this.lbl_id.Text);
            studentinfo.ShowDialog();
        }

        private void Teacher_info_Load(object sender, EventArgs e)
        {

        }
    }
}
