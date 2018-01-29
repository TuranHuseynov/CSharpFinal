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
    public partial class AddTaskType : Form
    {
        Code_Academy_DbEntities db = new Code_Academy_DbEntities();
        Task_types selectedType;
        public AddTaskType()
        {
            InitializeComponent();
            fillType();
        }

        private void addType_Click(object sender, EventArgs e)
        {
            var item = new Task_types();
            item.task_type_name = typeName.Text;
            item.task_type_rate = Convert.ToDouble(typeRate.Text);
            db.Task_types.Add(item);
            db.SaveChanges();
            fillType();
        }
        public void fillType()
        {

            var t = 0;
            dataGridType.Rows.Clear();
            List<Task_types> list = db.Task_types.ToList();
            foreach (var item in list)
            {
                dataGridType.Rows.Add();
                dataGridType.Rows[t].Cells[0].Value = item.id;
                dataGridType.Rows[t].Cells[1].Value = item.task_type_name;
                dataGridType.Rows[t].Cells[2].Value = item.task_type_rate;
                t++;
            }

        }

        private void update_Click(object sender, EventArgs e)
        {
            selectedType.task_type_name = typeName.Text;
            selectedType.task_type_rate = Convert.ToDouble(typeRate.Text);
            db.SaveChanges();
            fillType();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (db.Task_types.FirstOrDefault(t => t.id == selectedType.id) == null)
            {
                MessageBox.Show("Message");
            }
            else
            {
                db.Task_types.Remove(selectedType);
                db.SaveChanges();
                fillType();
            }
        }

        private void dataGridType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridType.Rows[e.RowIndex].Cells[0].Value);
            selectedType = db.Task_types.Find(id);
            typeName.Text = selectedType.task_type_name;
            typeRate.Text = selectedType.task_type_rate.ToString();
        }
    }
}
