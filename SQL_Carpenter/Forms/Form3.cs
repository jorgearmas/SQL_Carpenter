using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SQL_Carpenter.Forms
{
    public partial class Form3 : Form
    {
        private string db_name;
        private Dictionary<string, string> field_type_pair = new Dictionary<string, string>();
        public Form3(string db_name_from_form2)
        {
            InitializeComponent();
            db_name = db_name_from_form2;
            label2.Text = db_name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string db_name = textBox1.Text;
            string field_name = textBox3.Text;
            string field_type = comboBox1.Text;
            textBox3.Text = "";

            field_type_pair.Add(field_name, field_type);

            System.Windows.Forms.Label label = new System.Windows.Forms.Label();
            label.Name = $"textBox_{field_name}";
            label.Text = $"helloo {field_name}";

            panel1.Controls.Add(label);
            int offsetY = panel1.Controls.Count * 30;
            label.Location = new Point(10, offsetY);
            label.Width = 200;
            panel1.Controls.Add(label);
        }
    }
}
