using SQL_Carpenter.Data;
using SQL_Carpenter.Forms;
using SQL_Carpenter.Services;

namespace SQL_Carpenter
{
    public partial class Form1 : Form
    {
        private string _server_name;
        private string _user_name;
        private string _password;
        public Form1()
        {
            InitializeComponent();
        }

        public void SetConnectionChain()
        {
            _server_name = btnServerName.Text;
            _user_name = btnUserName.Text;
            _password = btnPassword.Text;
            try
            {
                ConnectionSettings.Configure(_server_name, _user_name, _password);
                MessageBox.Show("Connection successful");

            }
            catch (Exception ex)
            {
                MessageBox.Show($" -- Exception found --> \n\n {ex}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetConnectionChain();
            Form2 form2 = new Form2();
            form2.FormClosed += (s, args) => this.Show();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetConnectionChain();
            Form4 form4 = new Form4();
            form4.FormClosed += (s, args) => this.Show();
            form4.Show();
            this.Hide();
        }
    }
}
