using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class FormNachalo : Form
    {
        public FormNachalo()
        {
            InitializeComponent();
        }

        private void FormNachalo_Load(object sender, EventArgs e)
        {
            
 
        }

        private void лицеToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void обемToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void првоъгълникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Matemati4eskiNara4nik.FormObikolkaPravoagalnik sistema = new Matemati4eskiNara4nik.FormObikolkaPravoagalnik();
            sistema.ShowDialog();

            this.Close();
        }

        private void buttonOpenSplashScreen_Click(object sender, EventArgs e)
        {
            
           
        }

        private void триъглникToolStripMenuItem_Click(object sender, EventArgs e)
        {this.Hide();
        Matemati4eskiNara4nik.FormObikolkaNaTriagalnik sistema = new Matemati4eskiNara4nik.FormObikolkaNaTriagalnik();
            sistema.ShowDialog();

            this.Close();
            
        }

        private void правиленNъгълникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Matemati4eskiNara4nik.FormNAgalnik sistema = new Matemati4eskiNara4nik.FormNAgalnik();
            sistema.ShowDialog();
            this.Close(); 
        }

        private void pictureBoxFacebook_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/KV-Crew-865335973535355/?ref=hl");
        }

        private void валутаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Matemati4eskiNara4nik.FormValuti sistema = new Matemati4eskiNara4nik.FormValuti();
            sistema.ShowDialog();

            this.Close();
        }

        private void мерниЕдинициToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                Matemati4eskiNara4nik.FormMerniEdinici sistema = new Matemati4eskiNara4nik.FormMerniEdinici();
            sistema.ShowDialog();

            this.Close();
        }

        private void окръжностToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Matemati4eskiNara4nik.FormOkrujnost sistema = new Matemati4eskiNara4nik.FormOkrujnost();
            sistema.ShowDialog();

            this.Close();
        }

        private void действияСДробиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Matemati4eskiNara4nik.FormDrobi sistema = new Matemati4eskiNara4nik.FormDrobi();
            sistema.ShowDialog();

            this.Close();
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            Process.Start("www.kvcrew.free.bg");
        }

        private void првоъгълникToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Matemati4eskiNara4nik.FormLicenaPravoagalnik sistema = new Matemati4eskiNara4nik.FormLicenaPravoagalnik();
            sistema.ShowDialog();
            this.Close();
        }

        private void menuStripGlaavnoMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void авториToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Matemati4eskiNara4nik.FormAvtori sistema = new Matemati4eskiNara4nik.FormAvtori();
            sistema.ShowDialog();
            this.Close();
        }
    }
}
