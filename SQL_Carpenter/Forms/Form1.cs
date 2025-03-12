using SQL_Carpenter.Forms;

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
    }
}
