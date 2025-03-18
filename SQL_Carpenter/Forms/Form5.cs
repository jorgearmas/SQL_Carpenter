using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using SQL_Carpenter.Services.DML;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;

namespace SQL_Carpenter.Forms
{
    public partial class Form5 : Form
    {
        public List<CheckBox> checkBoxes = new List<CheckBox>();
        public List<CheckBox> checkedBoxes = new List<CheckBox>();
        string initialQuery = "";
        public Form5(string server_name, string user_name, string password, string db_name, string table_name)
        {
            InitializeComponent();
            TableDMLManagement tableDMLManagement = new TableDMLManagement(server_name, user_name, password);
            List<string> columnsToRender = tableDMLManagement.getColumns(db_name, table_name);
            

            foreach (string column in columnsToRender)
            {
                System.Windows.Forms.CheckBox checkBox = new System.Windows.Forms.CheckBox();
                checkBox.Name = $"{column}";
                checkBox.Text = $"Field: {column}";

                panel1.Controls.Add(checkBox);
                int offsetY = panel1.Controls.Count * 30;
                checkBox.Location = new Point(10, offsetY);
                checkBox.Width = 200;
                panel1.Controls.Add(checkBox);
                checkBoxes.Add(checkBox);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(var checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    checkedBoxes.Add(checkBox);
                }
            }


            foreach(var checkBox in checkedBoxes)
            {
                MessageBox.Show(checkBox.Name);
            }
        }
    }
}
