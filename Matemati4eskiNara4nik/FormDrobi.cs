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
    public partial class FormDrobi : Form
    {
        public FormDrobi()
        {
            InitializeComponent();
        }

        private void началоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            WindowsFormsApplication1.FormNachalo sistema = new WindowsFormsApplication1.FormNachalo();
            sistema.ShowDialog();

            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormDrobi_Load(object sender, EventArgs e)
        {

        }
    }
}
