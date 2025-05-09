﻿using System;
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

namespace SQL_Carpenter.Forms
{
    public partial class Form4 : Form
    {
        BindingSource getAllTablesBindingSource = new BindingSource();
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string db_name = txt_db_name.Text;

            var getAllTables = DatabaseManager.GetAllTables(db_name);
            getAllTablesBindingSource.DataSource = getAllTables;
            dataGridView1.DataSource = getAllTablesBindingSource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string db_name = txt_db_name.Text;

            int rowClicked = dataGridView1.CurrentRow.Index;
            string table_name = dataGridView1.Rows[rowClicked].Cells[2].Value.ToString();

            Form5 form5 = new Form5(db_name, table_name);
            form5.FormClosed += (s, args) => this.Show();
            form5.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string db_name = txt_db_name.Text;

            int rowClicked = dataGridView1.CurrentRow.Index;
            string table_name = dataGridView1.Rows[rowClicked].Cells[2].Value.ToString();

            Form6 form6 = new Form6(db_name, table_name);
            form6.FormClosed += (s, args) => this.Show();
            form6.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string db_name = txt_db_name.Text;

            int rowClicked = dataGridView1.CurrentRow.Index;
            string table_name = dataGridView1.Rows[rowClicked].Cells[2].Value.ToString();

            Form7 form7 = new Form7(db_name, table_name);
            form7.FormClosed += (s, args) => this.Show();
            form7.Show();
            this.Hide();
        }

    }
}
