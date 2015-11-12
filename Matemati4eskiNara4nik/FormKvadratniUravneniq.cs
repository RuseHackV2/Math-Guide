using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Matemati4eskiNara4nik
{
    public partial class FormKvadratniUravneniq : Form
    {
        public FormKvadratniUravneniq()
        {
            InitializeComponent();
        }
        double a, b, c;

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPresmqtane_Click(object sender, EventArgs e)
        {
            
                a = Convert.ToDouble(textBoxA.Text);
                b = Convert.ToDouble(textBoxB.Text);
                c = Convert.ToDouble(textBoxC.Text);
        }





    }
}
