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
    public partial class Admin_Enter : Form
    {
        public Admin_Enter()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if (userName.Text == "admin" && password.Text == "admin") 
            {
                Add_data add_Data = new Add_data();
                add_Data.ShowDialog();
            }
            else
            {
                elselabel.Text = "Your username or password incorrect";
            }
        }

       
    }
}
