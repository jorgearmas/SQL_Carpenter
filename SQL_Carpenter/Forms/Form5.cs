﻿using System;
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
using SQL_Carpenter.Managers;

namespace SQL_Carpenter.Forms
{
    public partial class Form5 : Form
    {
        private string _db_name;
        private string _table_name;
        string subQueryColumns = "";

        public Dictionary<CheckBox, string> checkBoxes = new Dictionary<CheckBox, string>();
        public Dictionary<CheckBox, string> checkedBoxes = new Dictionary<CheckBox, string>();
        public Dictionary<TextBox, string> textBoxesWithValues = new Dictionary<TextBox, string>();
        public List<Object> valuesToInsert = new List<Object>();

        public Form5(string db_name, string table_name)
        {
            _db_name = db_name;
            _table_name = table_name;

            InitializeComponent();
            Dictionary<string, string> columnsToRender = TableManager.getColumns(db_name, table_name);
            List<string> columnsDataType = new List<string>();

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

                subQueryColumns += $"{item.Key.Name}, ";
                textBoxesWithValues.Add(textBox, item.Value);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in textBoxesWithValues)
            {
                if(item.Value == "int")
                {
                    valuesToInsert.Add(Convert.ToInt32(item.Key.Text));
                }
                else
                {
                    valuesToInsert.Add(item.Key.Text);
                }
                //MessageBox.Show(item.Key.Text);
            }
            string modifiedSubQueryColumns = subQueryColumns.Substring(0, subQueryColumns.Length - 2);

            int rowsInserted = TableManager.insertData(_db_name, _table_name, modifiedSubQueryColumns, valuesToInsert);
            MessageBox.Show($"{rowsInserted} Rows inserted");
        }
    }
}
