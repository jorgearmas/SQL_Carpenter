using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL_Carpenter.Data;
using SQL_Carpenter.Services.DDL;

namespace SQL_Carpenter.Forms
{
    public partial class Form2 : Form
    {
        BindingSource allDataBasesBindingSource = new BindingSource();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server_name = txt_DDL_serverName.Text;
            string database_name = txt_DDL_dataBaseName.Text;
            string user_name = txt_DDL_userName.Text;
            string password = txt_DDL_password.Text;

            CreateDB createDB = new CreateDB(server_name, user_name, password);

            int result = createDB.CreateDatabase(database_name);
            MessageBox.Show(result == -1 ? "Database created succesfully" : "Error while creating the database");

            txt_DDL_serverName.Text = "";
            txt_DDL_dataBaseName.Text = "";
            txt_DDL_userName.Text = "";
            txt_DDL_password.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string server_name = txt_DDL_getAll_serverName.Text;
            string user_name = txt_DDL_getAll_userName.Text;
            string password = txt_DDL_getAll_password.Text;
            try
            {
                GetAllDB getAllDB = new GetAllDB(server_name, user_name, password);
                allDataBasesBindingSource.DataSource = getAllDB.getAllDataBases();
                dataGridView1.DataSource = allDataBasesBindingSource;
            }
            catch (Exception ex) 
            {
                MessageBox.Show($" -- Exception found, check your credentials \n\n {ex}");
            }
        }
    }
}
