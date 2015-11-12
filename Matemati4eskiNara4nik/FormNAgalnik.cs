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
    public partial class FormNAgalnik : Form
    {
        public FormNAgalnik()
        {
            InitializeComponent();
            comboBoxA.SelectedIndex = 1;
            comboBoxD.SelectedIndex = 1;
            comboBoxP.SelectedIndex = 1;
        }

        private void правиленNъгълникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Matemati4eskiNara4nik.FormNAgalnik sistema = new Matemati4eskiNara4nik.FormNAgalnik();
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
        Double a,n,d,p;
        private void buttonPresmetni_Click(object sender, EventArgs e)
        {
            if (this.textBoxN.Text != "0" && this.textBoxA.Text != "0" && this.textBoxP.Text != "0")
            {
                Matemati4eskiNara4nik.FormGreshka sistema = new Matemati4eskiNara4nik.FormGreshka();
                sistema.ShowDialog();
            }
            else
            {
                string dconvect = this.textBoxD.Text.ToString();
                d = Convert.ToDouble(dconvect);
                string aconvect = this.textBoxA.Text.ToString();
                a = Convert.ToDouble(aconvect);
                string bconvect = this.textBoxN.Text.ToString();
                n = Convert.ToDouble(bconvect);
                string pconvect = this.textBoxP.Text.ToString();
                p = Convert.ToDouble(pconvect);
                if (n == 1 || n == 2)
                {
                    Matemati4eskiNara4nik.FormNagalnikGreshka sistema = new Matemati4eskiNara4nik.FormNagalnikGreshka();
                    sistema.ShowDialog();
                }
                else
                {
                    if (this.comboBoxA.SelectedIndex == 0)
                    {
                        a = a / 10;
                    }

                    if (this.comboBoxD.SelectedIndex == 0)
                    {
                        d = d / 10;
                    }
                    if (this.comboBoxP.SelectedIndex == 0)
                    {
                        p = p / 10;
                    }
                    if (this.comboBoxA.SelectedIndex == 2)
                    {
                        a = a * 10;
                    }

                    if (this.comboBoxD.SelectedIndex == 2)
                    {
                        d = d * 10;
                    }
                    if (this.comboBoxP.SelectedIndex == 2)
                    {
                        p = p * 10;
                    }
                    if (this.comboBoxA.SelectedIndex == 3)
                    {
                        a = a * 100;
                    }

                    if (this.comboBoxD.SelectedIndex == 3)
                    {
                        d = d * 100;
                    }
                    if (this.comboBoxP.SelectedIndex == 3)
                    {
                        p = p * 100;
                    }
                    if (this.textBoxP.Text == "0")
                    {
                        p = n * a;
                        this.textBoxP.Text = p.ToString();
                    }
                    if (this.textBoxA.Text == "0")
                    {

                        a = p / n;
                        this.textBoxA.Text = a.ToString();
                    }
                    if (this.textBoxN.Text == "0")
                    {

                        n = p / a;
                        this.textBoxN.Text = n.ToString();
                    }
                    if (this.textBoxD.Text == "0")
                    {
                        d = n - 3;
                        d = d * n;
                        d = d / 2;
                        this.textBoxD.Text = d.ToString();
                    }
                }
                int x, y;
                Graphics h = this.pictureBoxRisunka.CreateGraphics();
                Pen v = new Pen(Color.DarkOrange, 10);



            }

        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            
        }

        private void валутиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Matemati4eskiNara4nik.FormValuti sistema = new Matemati4eskiNara4nik.FormValuti();
            sistema.ShowDialog();

            this.Close();
        }

        private void заНасToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxN_SelectedIndexChanged(object sender, EventArgs e)
        {
                    }

        private void buttonIz4isti_Click(object sender, EventArgs e)
        {
            comboBoxA.SelectedIndex = 1;
            comboBoxD.SelectedIndex = 1;
            comboBoxP.SelectedIndex = 1;
            this.textBoxD.Text = "0";
            this.textBoxN.Text = "0";
            this.textBoxA.Text = "0";
            this.textBoxP.Text = "0";
        }

        private void окръжностToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOkrujnost sistema = new FormOkrujnost();
            sistema.ShowDialog();

            this.Close();
        }

                }
}
