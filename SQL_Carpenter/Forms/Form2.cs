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
        string server_name;
        string user_name;
        string password;
        string database_name;
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            server_name = txt_DDL_serverName.Text;
            user_name = txt_DDL_userName.Text;
            password = txt_DDL_password.Text;
            database_name = txt_DDL_dataBaseName.Text;

            try
            {
                CreateDB createDB = new CreateDB(server_name, user_name, password);

                int result = createDB.CreateDatabase(database_name);
                MessageBox.Show(result == -1 ? "Database created succesfully" : "Error while creating the database");
            }
            catch (Exception ex)
            {
                MessageBox.Show($" -- Exception found --> \n\n {ex}");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            server_name = txt_DDL_serverName.Text;
            user_name = txt_DDL_userName.Text;
            password = txt_DDL_password.Text;
            try
            {
                GetAllDB getAllDB = new GetAllDB(server_name, user_name, password);
                allDataBasesBindingSource.DataSource = getAllDB.getAllDataBases();
                dataGridView1.DataSource = allDataBasesBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($" -- Exception found --> \n\n {ex}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridView1.CurrentRow.Index;
            string db_name = dataGridView1.Rows[rowClicked].Cells[0].Value.ToString();

            server_name = txt_DDL_serverName.Text;
            user_name = txt_DDL_userName.Text;
            password = txt_DDL_password.Text;

            try
            {
                DropDB dropDB = new DropDB(server_name, user_name, password);
                int result = dropDB.DropDatabase(db_name);

                MessageBox.Show(result == -1 ? "Database deleted succesfully" : "Error while deleting the database");
            }
            catch (Exception ex)
            {
                MessageBox.Show($" -- Exception found --> \n\n {ex}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int currentRow = dataGridView1.CurrentRow.Index;
            server_name = txt_DDL_serverName.Text;
            user_name = txt_DDL_userName.Text;
            password = txt_DDL_password.Text;
            string db_name = dataGridView1.Rows[currentRow].Cells[0].Value.ToString();

            Form3 form3 = new Form3(db_name, server_name, user_name, password);
            form3.FormClosed += (s, args) => this.Show();
            form3.Show();
            this.Hide();
            
        }
    }
}
