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
    public partial class FormOkrujnost : Form
    {
        public FormOkrujnost()
        {
            InitializeComponent();
            comboBoxN.SelectedIndex = 1;
            comboBoxD.SelectedIndex = 1;
            comboBoxP.SelectedIndex = 1;
        }
        double r, d, p;
        private void buttonPresmetni_Click(object sender, EventArgs e)
        {
            string dconvect = this.textBoxD.Text.ToString();
            d = Convert.ToDouble(dconvect);
            string bconvect = this.textBoxN.Text.ToString();
            r = Convert.ToDouble(bconvect);
            string pconvect = this.textBoxP.Text.ToString();
            p = Convert.ToDouble(pconvect);

            if (this.comboBoxN.SelectedIndex == 0)
            {
                r = r / 10;
            }
            if (this.comboBoxD.SelectedIndex == 0)
            {
                d = d / 10;
            }
            if (this.comboBoxP.SelectedIndex == 0)
            {
                p = p / 10;
            }

            if (this.comboBoxN.SelectedIndex == 2)
            {
                r = r * 10;
            }
            if (this.comboBoxD.SelectedIndex == 2)
            {
                d = d * 10;
            }
            if (this.comboBoxP.SelectedIndex == 2)
            {
                p = p * 10;
            }

            if (this.comboBoxN.SelectedIndex == 3)
            {
                r = r * 100;
            }
            if (this.comboBoxD.SelectedIndex == 3)
            {
                d = d * 100;
            }
            if (this.comboBoxP.SelectedIndex == 3)
            {
                p = p * 100;
            }


            if (this.textBoxN.Text == "0")
            {
                if (d != 0)
                    r = d / 2;
                if (d == 0)
                    r = p / 3.14 / 2;

                this.textBoxN.Text = r.ToString();
            }
            if (this.textBoxP.Text == "0")
            {
                p = 2 * r * 3.14;
                this.textBoxP.Text = p.ToString();
            }
            if (this.textBoxD.Text == "0")
            {
                if (r != 0)
                    d = 2 * r;
                if (r == 0)
                    d = p / 3.14;
                this.textBoxD.Text = d.ToString();
            }
            int x, y;
            Graphics h = this.pictureBoxRisunka.CreateGraphics();
            Pen v = new Pen(Color.DarkOrange, 10);

            h.DrawEllipse(v, 100, 10, 150, 150);
        }

        private void началоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            WindowsFormsApplication1.FormNachalo sistema = new WindowsFormsApplication1.FormNachalo();
            sistema.ShowDialog();

            this.Close();
        }

        private void правоъгълникToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Matemati4eskiNara4nik.FormLicenaPravoagalnik sistema = new Matemati4eskiNara4nik.FormLicenaPravoagalnik();
            sistema.ShowDialog();

            this.Close();
        }

        private void правоъгълникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Matemati4eskiNara4nik.FormObikolkaPravoagalnik sistema = new Matemati4eskiNara4nik.FormObikolkaPravoagalnik();
            sistema.ShowDialog();
            this.Close();
        }

        private void триъгълникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Matemati4eskiNara4nik.FormObikolkaNaTriagalnik sistema = new Matemati4eskiNara4nik.FormObikolkaNaTriagalnik();
            sistema.ShowDialog();

            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            string dconvect = this.textBoxD.Text.ToString();
            d = Convert.ToDouble(dconvect);
            string bconvect = this.textBoxN.Text.ToString();
            r = Convert.ToDouble(bconvect);
            string pconvect = this.textBoxP.Text.ToString();
            p = Convert.ToDouble(pconvect);

            if (this.comboBoxN.SelectedIndex == 0)
            {
                r = r / 10;
            }
            if (this.comboBoxD.SelectedIndex == 0)
            {
                d = d / 10;
            }
            if (this.comboBoxP.SelectedIndex == 0)
            {
                p = p / 10;
            }

            if (this.comboBoxN.SelectedIndex == 2)
            {
                r = r * 10;
            }
            if (this.comboBoxD.SelectedIndex == 2)
            {
                d = d * 10;
            }
            if (this.comboBoxP.SelectedIndex == 2)
            {
                p = p * 10;
            }

            if (this.comboBoxN.SelectedIndex == 3)
            {
                r = r * 100;
            }
            if (this.comboBoxD.SelectedIndex == 3)
            {
                d = d * 100;
            }
            if (this.comboBoxP.SelectedIndex == 3)
            {
                p = p * 100;
            }


            if (this.textBoxN.Text == "0")
            {
                if (d != 0)
                    r = d / 2;
                if (d == 0)
                    r = p / 3.14 / 2;

                this.textBoxN.Text = r.ToString();
            }
            if (this.textBoxP.Text == "0")
            {
                p = 2 * r * 3.14;
                this.textBoxP.Text = p.ToString();
            }
            if (this.textBoxD.Text == "0")
            {
                if (r != 0)
                    d = 2 * r;
                if (r == 0)
                    d = p / 3.14;
                this.textBoxD.Text = d.ToString();
            }
            int x, y;
            Graphics h = this.pictureBoxRisunka.CreateGraphics();
            Pen v = new Pen(Color.DarkOrange, 10);

            h.DrawEllipse(v, 100, 10, 150, 150);
        
    }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            comboBoxN.SelectedIndex = 1;
            comboBoxD.SelectedIndex = 1;
            comboBoxP.SelectedIndex = 1;
            this.textBoxD.Text = "0";
            this.textBoxN.Text = "0";
            this.textBoxP.Text = "0";
            this.pictureBoxRisunka.Image = null;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
           
              
        }

        private void FormOkrujnost_Load(object sender, EventArgs e)
        {

        }

        private void buttonIz4isti_Click(object sender, EventArgs e)
        {
            comboBoxN.SelectedIndex = 1;
            comboBoxD.SelectedIndex = 1;
            comboBoxP.SelectedIndex = 1;
            this.textBoxD.Text = "0";
            this.textBoxN.Text = "0";
            this.textBoxP.Text = "0";
            this.pictureBoxRisunka.Image = null;
        }
    }
}
