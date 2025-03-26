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
        private string _server_name;
        private string _user_name;
        private string _password;
        private string _db_name;
        private string _table_name;
        public Form7(string server_name, string user_name, string password, string db_name, string table_name)
        {
            _server_name = server_name;
            _user_name = user_name;
            _password = password;
            _db_name = db_name;
            _table_name = table_name;
            InitializeComponent();
            TableDMLManagement tableDMLManagement = new TableDMLManagement(_server_name, _user_name, _password);
            getAllRecordsFromTableBindingSource.DataSource = tableDMLManagement.getAllRecords(db_name, table_name);
            dataGridView1.DataSource = getAllRecordsFromTableBindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridView1.CurrentRow.Index;
            int ID_toDelete = Convert.ToInt32(dataGridView1.Rows[rowClicked].Cells[0].Value);
            string IdColumnName = dataGridView1.Columns[0].Name;
            
            TableDMLManagement tableDMLManagement = new TableDMLManagement(_server_name, _user_name, _password);
            int result = tableDMLManagement.deleteRow(_db_name, _table_name, IdColumnName, ID_toDelete);
            MessageBox.Show(result.ToString());
        }
    }
}
