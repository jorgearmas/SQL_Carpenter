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
using SQL_Carpenter.Managers;
using SQL_Carpenter.Services.DDL;

namespace SQL_Carpenter.Forms
{
    public partial class Form2 : Form
    {
        BindingSource allDataBasesBindingSource = new BindingSource();
        string database_name;
        public Form2()
        {
            InitializeComponent();
            try
            {
                var getAllDB = DatabaseManager.GetAllDatabases();
                allDataBasesBindingSource.DataSource = getAllDB;
                dataGridView1.DataSource = allDataBasesBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($" -- Exception found --> \n\n {ex}");
            }
        }
        private void btnCreateDB_Click(object sender, EventArgs e)
        {
            database_name = txt_DDL_dataBaseName.Text;

            try
            {
               
                int result = DatabaseManager.CreateDatabase(database_name);
                MessageBox.Show(result == -1 ? "Database created succesfully" : "Error while creating the database");
            }
            catch (Exception ex)
            {
                MessageBox.Show($" -- Exception found --> \n\n {ex}");
            }

        }

        private void btnDeleteDB_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridView1.CurrentRow.Index;
            string db_name = dataGridView1.Rows[rowClicked].Cells[0].Value.ToString();

            try
            {
                int result = DatabaseManager.DeleteDatabase(db_name);

                MessageBox.Show(result == -1 ? "Database deleted succesfully" : "Error while deleting the database");
            }
            catch (Exception ex)
            {
                MessageBox.Show($" -- Exception found --> \n\n {ex}");
            }
        }

        private void btnModifyDB_Click(object sender, EventArgs e)
        {
            int currentRow = dataGridView1.CurrentRow.Index;
            string db_name = dataGridView1.Rows[currentRow].Cells[0].Value.ToString();

            Form3 form3 = new Form3(db_name);
            form3.FormClosed += (s, args) => this.Show();
            form3.Show();
            this.Hide();
            
        }
    }
}
