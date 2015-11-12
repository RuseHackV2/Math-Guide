using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
namespace Matemati4eskiNara4nik
{
    public partial class FormAvtori : Form
    {
        public FormAvtori()
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

        private void pictureBoxFB_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/KV-Crew-865335973535355/?ref=hl");
        }
    }
}
