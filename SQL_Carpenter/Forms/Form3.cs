using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL_Carpenter.Managers;
using SQL_Carpenter.Services.DDL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SQL_Carpenter.Forms
{
    public partial class Form3 : Form
    {
        BindingSource getAllTablesBindingSource = new BindingSource();

        private string _db_name;

        private Dictionary<string, string> field_type_pair = new Dictionary<string, string>();
        public Form3(string db_name_from_form2)
        {
            InitializeComponent();
            _db_name = db_name_from_form2;
            label2.Text = _db_name;

            var getAllTables = DatabaseManager.GetAllTables(_db_name);
            getAllTablesBindingSource.DataSource = getAllTables;
            dataGridView1.DataSource = getAllTablesBindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string field_name = textBox3.Text;
            string field_type = comboBox1.Text;
            textBox3.Text = "";

            field_type_pair.Add(field_name, field_type);

            System.Windows.Forms.Label label = new System.Windows.Forms.Label();
            label.Name = $"textBox_{field_name}";
            label.Text = $"{field_name} - {field_type}";

            panel1.Controls.Add(label);
            int offsetY = panel1.Controls.Count * 30;
            label.Location = new Point(10, offsetY);
            label.Width = 200;
            panel1.Controls.Add(label);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string table_name = textBox1.Text;
            string primary_key = textBox2.Text;

            int result = DatabaseManager.CreateTable(_db_name, table_name, primary_key, field_type_pair);
            MessageBox.Show(result == -1 ? "Table created succesfully" : "Error while creating the table");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridView1.CurrentRow.Index;
            string table_name = dataGridView1.Rows[rowClicked].Cells[2].Value.ToString();

            
            int result = DatabaseManager.DropTable(_db_name, table_name);
            MessageBox.Show(result == -1 ? "Table deleted succesfully" : "Error while deleting the table");
        }
    }
}
