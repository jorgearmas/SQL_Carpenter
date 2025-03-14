using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL_Carpenter.Services.DDL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SQL_Carpenter.Forms
{
    public partial class Form3 : Form
    {
        private string _db_name;
        private string _server_name;
        private string _user_name;
        private string _password;

        private Dictionary<string, string> field_type_pair = new Dictionary<string, string>();
        public Form3(string db_name_from_form2, string server_name, string user_name, string password)
        {
            InitializeComponent();
            _db_name = db_name_from_form2;
            _server_name = server_name;
            _user_name = user_name;
            _password = password;
            label2.Text = _db_name;
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

            TableManagement tableManagement = new TableManagement(_server_name, _user_name, _password);
            int result = tableManagement.CreateTable(_db_name, table_name, primary_key, field_type_pair);
            MessageBox.Show(result == -1 ? "Table created succesfully" : "Error while deleting the table");
            
        }
    }
}
