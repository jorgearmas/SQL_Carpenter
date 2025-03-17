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
            string server_name = txt_server_name.Text;
            string user_name = txt_user_name.Text;
            string password = txt_password.Text;
            string db_name = txt_db_name.Text;

            TableManagement tableManagement = new TableManagement(server_name, user_name, password);
            getAllTablesBindingSource.DataSource = tableManagement.GetAllTables(db_name);
            dataGridView1.DataSource = getAllTablesBindingSource;
        }
    }
}
