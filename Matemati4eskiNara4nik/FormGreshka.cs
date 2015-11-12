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
    public partial class FormGreshka : Form
    {
        public FormGreshka()
        {
            InitializeComponent();
        }

        private void buttonGreshka_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormGreshka_Load(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
