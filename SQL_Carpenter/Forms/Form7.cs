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

namespace SQL_Carpenter.Forms
{
    public partial class Form7 : Form
    {
        BindingSource getAllRecordsFromTableBindingSource = new BindingSource();
        public Form7(string server_name, string user_name, string password, string db_name, string table_name)
        {
            InitializeComponent();
            TableDMLManagement tableDMLManagement = new TableDMLManagement(server_name, user_name, password);
            getAllRecordsFromTableBindingSource.DataSource = tableDMLManagement.getAllRecords(db_name, table_name);
            dataGridView1.DataSource = getAllRecordsFromTableBindingSource;
        }

    }
}
