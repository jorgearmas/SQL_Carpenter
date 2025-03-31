using SQL_Carpenter.Forms;
using SQL_Carpenter.Services;

namespace SQL_Carpenter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.FormClosed += (s, args) => this.Show();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.FormClosed += (s, args) => this.Show();
            form4.Show();
            this.Hide();
        }
    }
}
