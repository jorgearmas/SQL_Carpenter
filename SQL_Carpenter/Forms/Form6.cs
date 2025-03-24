using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL_Carpenter.Services.DML;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;

namespace SQL_Carpenter.Forms
{
    public partial class Form6 : Form
    {
        private string _server_name;
        private string _user_name;
        private string _password;
        private string _db_name;
        private string _table_name;
        public string id_field = "";

        public Dictionary<CheckBox, string> checkBoxes = new Dictionary<CheckBox, string>();
        public Dictionary<CheckBox, string> checkedBoxes = new Dictionary<CheckBox, string>();
        public Dictionary<TextBox, string> textBoxesWithValues = new Dictionary<TextBox, string>();
        public List<Object> valuesToUpdate = new List<Object>();
        public Form6(string server_name, string user_name, string password, string db_name, string table_name)
        {
            _server_name = server_name;
            _user_name = user_name;
            _password = password;
            _db_name = db_name;
            _table_name = table_name;

            InitializeComponent();
            TableDMLManagement tableDMLManagement = new TableDMLManagement(_server_name, _user_name, _password);
            Dictionary<string, string> columnsToRender = tableDMLManagement.getColumns(_db_name, _table_name);
            List<string> columnsDataType = new List<string>();
            id_field = columnsToRender.Keys.First();
            foreach (var item in columnsToRender)
            {
                System.Windows.Forms.CheckBox checkBox = new System.Windows.Forms.CheckBox();
                checkBox.Name = $"{item.Key}";
                checkBox.Text = $" Name: {item.Key} | DataType: {item.Value}";

                panel1.Controls.Add(checkBox);
                int offsetY = panel1.Controls.Count * 30;
                checkBox.Location = new Point(10, offsetY);
                checkBox.Width = 300;
                panel1.Controls.Add(checkBox);

                checkBoxes.Add(checkBox, item.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in checkBoxes)
            {
                if (item.Key.Checked)
                {
                    checkedBoxes.Add(item.Key, item.Value);
                }
            }
            List<string> targetedColumns = new List<string>();
            foreach (var item in checkedBoxes)
            {
                System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
                System.Windows.Forms.Label label = new System.Windows.Forms.Label();

                label.Name = $"lbl_{item.Key.Name}";
                label.Text = $"{item.Key.Name}";
                textBox.Name = $"txt_{item.Key.Name}";

                int offsetY = (panel2.Controls.Count / 2) * 40;
                label.Location = new Point(10, offsetY);
                label.Width = 100;
                textBox.Location = new Point(label.Right + 10, offsetY);
                textBox.Width = 200;
                panel2.Controls.Add(label);
                panel2.Controls.Add(textBox);

                textBoxesWithValues.Add(textBox, item.Value);
                targetedColumns.Add(item.Key.Name);
            }

            int ID_toUpdate = Convert.ToInt32(textBox1.Text);
            TableDMLManagement tableDMLManagement = new TableDMLManagement(_server_name, _user_name, _password);
            List<Object> valsToRender = tableDMLManagement.GetValuesFromColumns(_db_name, _table_name, targetedColumns, ID_toUpdate, id_field);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in textBoxesWithValues)
            {
                if (item.Value == "int")
                {
                    valuesToUpdate.Add(Convert.ToInt32(item.Key.Text));
                }
                else
                {
                    valuesToUpdate.Add(item.Key.Text);
                }
                //MessageBox.Show(item.Key.Text);
            }
            //string modifiedSubQueryColumns = subQueryColumns.Substring(0, subQueryColumns.Length - 2);
        }
    }
}
