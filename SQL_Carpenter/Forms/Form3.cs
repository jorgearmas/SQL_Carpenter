using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Carpenter.Forms
{
    public partial class Form3 : Form
    {
        public Form3(string db_name_from_form2)
        {
            InitializeComponent();
            string db_name = db_name_from_form2;
        }
    }
}
