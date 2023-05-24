using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTeretana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClanstvo_Click(object sender, EventArgs e)
        {
            Uclanivanje form2 = new Uclanivanje();
            form2.Show();
        }

        private void btnBMIkalkulator_Click(object sender, EventArgs e)
        {
            BMIkalkulator form3 = new BMIkalkulator();
            form3.Show();
        }
    }
}
