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
    public partial class Add_Group_Types : Form
    {
        Code_Academy_DbEntities db = new Code_Academy_DbEntities();
        Group_types selectedType;
        public Add_Group_Types()
        {
            InitializeComponent();
            fillType();
        }

        private void Add_Group_Types_Load(object sender, EventArgs e)
        {
            foreach (var item in db.Group_schedule.ToList())
            {
                shedule.Items.Add(item.group_schedule_name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = new Group_types();
            item.group_type_name = typeName.Text;
            item.group_schedule_id= db.Group_schedule.FirstOrDefault(s => s.group_schedule_name == this.shedule.Text).id;
            db.Group_types.Add(item);
            db.SaveChanges();
            fillType();
        }

        public void fillType()
        {

            var t = 0;
            dataGridType.Rows.Clear();
            List<Group_types> list = db.Group_types.ToList();
            foreach (var item in list)
            {
                dataGridType.Rows.Add();
                dataGridType.Rows[t].Cells[0].Value = item.id;
                dataGridType.Rows[t].Cells[1].Value = item.group_type_name;
                dataGridType.Rows[t].Cells[2].Value = item.group_schedule_id;
                t++;
            }

        }

        private void update_Click(object sender, EventArgs e)
        {
            selectedType.group_type_name = typeName.Text;
            selectedType.group_schedule_id = db.Group_schedule.FirstOrDefault(s => s.group_schedule_name == this.shedule.Text).id;
            db.SaveChanges();
            fillType();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (db.Group_types.FirstOrDefault(g => g.id == selectedType.id) == null)
            {
                MessageBox.Show("Message");
            }
            else
            {
                db.Group_types.Remove(selectedType);
                db.SaveChanges();
                fillType();
            }
        }

        private void dataGridType_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dataGridType.Rows[e.RowIndex].Cells[0].Value);
            selectedType = db.Group_types.Find(id);
            typeName.Text = selectedType.group_type_name;
            shedule.Text = selectedType.Group_schedule.group_schedule_name;
        }
    }
}
