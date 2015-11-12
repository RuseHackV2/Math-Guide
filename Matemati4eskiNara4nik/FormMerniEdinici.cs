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
    public partial class FormMerniEdinici : Form
    {

        public FormMerniEdinici()
        {
            
            InitializeComponent();
            comboBoxPurvaDaljina.SelectedIndex = 0;
            comboBoxVtoraDaljina.SelectedIndex = 0;
            comboBoxPurviObem.SelectedIndex = 0;
            comboBoxVtoriObem.SelectedIndex = 0;
            comboBoxPurvaSkorost.SelectedIndex = 0;
            comboBoxVtoraSkorost.SelectedIndex = 0;
            comboBoxPurvaMasa.SelectedIndex = 0;
            comboBoxVtoraMasa.SelectedIndex = 0;
            comboBoxPurvaPlosht.SelectedIndex = 0;
            comboBoxVtoraPlosht.SelectedIndex = 0;
            comboBoxVtoroNalqgane.SelectedIndex = 0;
            comboBoxPurvoNalqgane.SelectedIndex = 0;
        }
        double a, b;


        //Presmqtane na 1 kolona
        private void buttonObemPresmetni_Click(object sender, EventArgs e)
        {
            if (comboBoxPurvaDaljina.SelectedIndex == 0 & comboBoxVtoraDaljina.SelectedIndex == 1)
            {
                a = Convert.ToDouble(textBoxPurvaDaljina.Text);
                if (a < 0)
                {
                   
                }
                else
                {
                    a = a * 1000;
                    textBoxVtoraDaljina.Text = a.ToString();
                }
            }

            if (comboBoxPurvaDaljina.SelectedIndex == 0 & comboBoxVtoraDaljina.SelectedIndex == 2)
            {

                a = Convert.ToDouble(textBoxPurvaDaljina.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a * 100000;
                    textBoxVtoraDaljina.Text = a.ToString();
                }
            }

            if (comboBoxPurvaDaljina.SelectedIndex == 0 & comboBoxVtoraDaljina.SelectedIndex == 3)
            {
                a = Convert.ToDouble(textBoxPurvaDaljina.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a * 1000000;
                    textBoxVtoraDaljina.Text = a.ToString();
                }
            }
            if (comboBoxPurvaDaljina.SelectedIndex == 1 & comboBoxVtoraDaljina.SelectedIndex == 0)
            {
                a = Convert.ToDouble(textBoxPurvaDaljina.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a / 1000;
                    textBoxVtoraDaljina.Text = a.ToString();
                }
            }
            if (comboBoxPurvaDaljina.SelectedIndex == 1 & comboBoxVtoraDaljina.SelectedIndex == 2)
            {
                a = Convert.ToDouble(textBoxPurvaDaljina.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a * 100;
                    textBoxVtoraDaljina.Text = a.ToString();
                }
            }

            if (comboBoxPurvaDaljina.SelectedIndex == 1 & comboBoxVtoraDaljina.SelectedIndex == 3)
            {
                a = Convert.ToDouble(textBoxPurvaDaljina.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a * 1000;
                    textBoxVtoraDaljina.Text = a.ToString();
                }
            }

            if (comboBoxPurvaDaljina.SelectedIndex == 2 & comboBoxVtoraDaljina.SelectedIndex == 0)
            {
                a = Convert.ToDouble(textBoxPurvaDaljina.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a / 100000;
                    textBoxVtoraDaljina.Text = a.ToString();
                }
            }

            if (comboBoxPurvaDaljina.SelectedIndex == 2 & comboBoxVtoraDaljina.SelectedIndex == 1)
            {
                a = Convert.ToDouble(textBoxPurvaDaljina.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a / 100;
                    textBoxVtoraDaljina.Text = a.ToString();
                }
            }

            if (comboBoxPurvaDaljina.SelectedIndex == 2 & comboBoxVtoraDaljina.SelectedIndex == 3)
            {
                a = Convert.ToDouble(textBoxPurvaDaljina.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a * 10;
                    textBoxVtoraDaljina.Text = a.ToString();
                }
            }

            if (comboBoxPurvaDaljina.SelectedIndex == 3 & comboBoxVtoraDaljina.SelectedIndex == 0)
            {
                a = Convert.ToDouble(textBoxPurvaDaljina.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a / 1000000;
                    textBoxVtoraDaljina.Text = a.ToString();
                }
            }

            if (comboBoxPurvaDaljina.SelectedIndex == 3 & comboBoxVtoraDaljina.SelectedIndex == 1)
            {
                a = Convert.ToDouble(textBoxPurvaDaljina.Text);
                a = a / 1000;
                textBoxVtoraDaljina.Text = a.ToString();
            }
            if (comboBoxPurvaDaljina.SelectedIndex == 3 & comboBoxVtoraDaljina.SelectedIndex == 2)
            {
                a = Convert.ToDouble(textBoxPurvaDaljina.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a / 10;
                    textBoxVtoraDaljina.Text = a.ToString();
                }
            }

            if (comboBoxPurvaDaljina.SelectedIndex == 0 & comboBoxVtoraDaljina.SelectedIndex == 0)
            {
                a = Convert.ToDouble(textBoxPurvaDaljina.Text);
                if (a < 0)
                {

                }
                else
                {
                    textBoxVtoraDaljina.Text = a.ToString();
                }
            }
            if (comboBoxPurvaDaljina.SelectedIndex == 1 & comboBoxVtoraDaljina.SelectedIndex == 1)
            {
                a = Convert.ToDouble(textBoxPurvaDaljina.Text);
                if (a < 0)
                {

                }
                else
                {
                    textBoxVtoraDaljina.Text = a.ToString();
                }
            }
            if (comboBoxPurvaDaljina.SelectedIndex == 2 & comboBoxVtoraDaljina.SelectedIndex == 2)
            {
                a = Convert.ToDouble(textBoxPurvaDaljina.Text);
                if (a < 0)
                {

                }
                else
                {
                    textBoxVtoraDaljina.Text = a.ToString();
                }
            }
            if (comboBoxPurvaDaljina.SelectedIndex == 3 & comboBoxVtoraDaljina.SelectedIndex == 3)
            {
                a = Convert.ToDouble(textBoxPurvaDaljina.Text);
                if (a < 0)
                {

                }
                else
                {
                    textBoxVtoraDaljina.Text = a.ToString();
                }
            }
            if (comboBoxPurviObem.SelectedIndex == 0 & comboBoxVtoriObem.SelectedIndex == 1)
            {
                a = Convert.ToDouble(textBoxPurviObem.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a * 1000;

                    textBoxVtoriObem.Text = a.ToString();

                }
            }
            if (comboBoxPurviObem.SelectedIndex == 1 & comboBoxVtoriObem.SelectedIndex == 0)
            {
                a = Convert.ToDouble(textBoxPurviObem.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a / 1000;
                    textBoxVtoriObem.Text = a.ToString();
                }
            }
            if (comboBoxPurviObem.SelectedIndex == 0 & comboBoxVtoriObem.SelectedIndex == 0)
            {
                a = Convert.ToDouble(textBoxPurviObem.Text);
                if (a < 0)
                {

                }
                else
                {
                    textBoxVtoriObem.Text = a.ToString();
                }
            }
            if (comboBoxPurviObem.SelectedIndex == 1 & comboBoxVtoriObem.SelectedIndex == 1)
            {
                a = Convert.ToDouble(textBoxPurviObem.Text);
                if (a < 0)
                {

                }
                else
                {
                    textBoxVtoriObem.Text = a.ToString();
                }
            }
            if (comboBoxPurvaMasa.SelectedIndex == 0 & comboBoxVtoraMasa.SelectedIndex == 1)
            {
                a = Convert.ToDouble(textBoxPurvaMasa.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a * 1000;
                    textBoxVtoraMasa.Text = a.ToString();
                }
            }
            if (comboBoxPurvaMasa.SelectedIndex == 0 & comboBoxVtoraMasa.SelectedIndex == 2)
            {
                a = Convert.ToDouble(textBoxPurvaMasa.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a * 1000000;
                    textBoxVtoraMasa.Text = a.ToString();
                }
            }
            if (comboBoxPurvaMasa.SelectedIndex == 1 & comboBoxVtoraMasa.SelectedIndex == 0)
            {
                a = Convert.ToDouble(textBoxPurvaMasa.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a / 1000;
                    textBoxVtoraMasa.Text = a.ToString();
                }
            }
            if (comboBoxPurvaMasa.SelectedIndex == 1 & comboBoxVtoraMasa.SelectedIndex == 2)
            {
                a = Convert.ToDouble(textBoxPurvaMasa.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a * 1000;
                    textBoxVtoraMasa.Text = a.ToString();
                }
            }
            if (comboBoxPurvaMasa.SelectedIndex == 2 & comboBoxVtoraMasa.SelectedIndex == 0)
            {
                a = Convert.ToDouble(textBoxPurvaMasa.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a / 1000000;
                    textBoxVtoraMasa.Text = a.ToString();
                }
            }
            if (comboBoxPurvaMasa.SelectedIndex == 2 & comboBoxVtoraMasa.SelectedIndex == 1)
            {
                a = Convert.ToDouble(textBoxPurvaMasa.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a / 1000;
                    textBoxVtoraMasa.Text = a.ToString();
                }
            }
            if (comboBoxPurvaMasa.SelectedIndex == 0 & comboBoxVtoraMasa.SelectedIndex == 0)
            {
                a = Convert.ToDouble(textBoxPurvaMasa.Text);
                if (a < 0)
                {

                }
                else
                {
                    textBoxVtoraMasa.Text = a.ToString();
                }
                if (comboBoxPurvaMasa.SelectedIndex == 1 & comboBoxVtoraMasa.SelectedIndex == 1)
                {
                    a = Convert.ToDouble(textBoxPurvaMasa.Text);
                    textBoxVtoraMasa.Text = a.ToString();
                }
            }
            if (comboBoxPurvaMasa.SelectedIndex == 2 & comboBoxVtoraMasa.SelectedIndex == 2)
            {
                a = Convert.ToDouble(textBoxPurvaMasa.Text);
                if (a < 0)
                {

                }
                else
                {
                    textBoxVtoraMasa.Text = a.ToString();
                }
            }
           
        }
      
             //Presmqtane na 2 kolona
        private void buttonNalqganePresmetni_Click(object sender, EventArgs e)
        {
            if (comboBoxPurvoNalqgane.SelectedIndex == 0 & comboBoxVtoroNalqgane.SelectedIndex == 1)
            {
                a = Convert.ToDouble(textBoxPurvoNalqgane.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a / 1000;
                    textBoxVtoroNalqgane.Text = a.ToString();
                }
            }
            if (comboBoxPurvoNalqgane.SelectedIndex == 1 & comboBoxVtoroNalqgane.SelectedIndex == 0)
            {
                a = Convert.ToDouble(textBoxPurvoNalqgane.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a * 1000;
                    textBoxVtoroNalqgane.Text = a.ToString();
                }
            }
            if (comboBoxPurvoNalqgane.SelectedIndex == 0 & comboBoxVtoroNalqgane.SelectedIndex == 0)
            {
                a = Convert.ToDouble(textBoxPurvoNalqgane.Text);
                if (a < 0)
                {

                }
                else
                {
                    textBoxVtoroNalqgane.Text = a.ToString();
                }
            }
            if (comboBoxPurvoNalqgane.SelectedIndex == 1 & comboBoxVtoroNalqgane.SelectedIndex == 1)
            {
                a = Convert.ToDouble(textBoxPurvoNalqgane.Text);
                if (a < 0)
                {

                }
                else
                {
                    textBoxVtoroNalqgane.Text = a.ToString();
                }
            }
            if (comboBoxPurvaSkorost.SelectedIndex == 0 & comboBoxVtoraSkorost.SelectedIndex == 1)
            {
                a = Convert.ToDouble(textBoxPurvaSkorost.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a * 1000 / 3600;
                    textBoxVtoraSkorost.Text = a.ToString();
                }
            }
            if (comboBoxPurvaSkorost.SelectedIndex == 1 & comboBoxVtoraSkorost.SelectedIndex == 0)
            {
                a = Convert.ToDouble(textBoxPurvaSkorost.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a / 1000 * 3600;
                    textBoxVtoraSkorost.Text = a.ToString();
                }
            }
            if (comboBoxPurvaSkorost.SelectedIndex == 0 & comboBoxVtoraSkorost.SelectedIndex == 0)
            {
                a = Convert.ToDouble(textBoxPurvaSkorost.Text);
                if (a < 0)
                {

                }
                else
                {
                    textBoxVtoraSkorost.Text = a.ToString();
                }
            }
            if (comboBoxPurvaSkorost.SelectedIndex == 1 & comboBoxVtoraSkorost.SelectedIndex == 1)
            {
                a = Convert.ToDouble(textBoxPurvaSkorost.Text);
                if (a < 0)
                {

                }
                else
                {
                    textBoxVtoraSkorost.Text = a.ToString();
                }
            }
            if (comboBoxPurvaPlosht.SelectedIndex == 0 & comboBoxVtoraPlosht.SelectedIndex == 1)
            {
                a = Convert.ToDouble(textBoxPurvaPlosht.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a * 10000;
                    textBoxVtoraPlosht.Text = a.ToString();
                }
            }
            if (comboBoxPurvaPlosht.SelectedIndex == 0 & comboBoxVtoraPlosht.SelectedIndex == 2)
            {
                a = Convert.ToDouble(textBoxPurvaPlosht.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a * 1000000;
                    textBoxVtoraPlosht.Text = a.ToString();
                }
            }
            if (comboBoxPurvaPlosht.SelectedIndex == 1 & comboBoxVtoraPlosht.SelectedIndex == 0)
            {
                a = Convert.ToDouble(textBoxPurvaPlosht.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a / 10000;
                    textBoxVtoraPlosht.Text = a.ToString();
                }
            }
            if (comboBoxPurvaPlosht.SelectedIndex == 1 & comboBoxVtoraPlosht.SelectedIndex == 2)
            {
                a = Convert.ToDouble(textBoxPurvaPlosht.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a * 100;
                    textBoxVtoraPlosht.Text = a.ToString();
                }
            }
            if (comboBoxPurvaPlosht.SelectedIndex == 2 & comboBoxVtoraPlosht.SelectedIndex == 0)
            {
                a = Convert.ToDouble(textBoxPurvaPlosht.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a / 1000000;
                    textBoxVtoraPlosht.Text = a.ToString();
                }
            }
            if (comboBoxPurvaPlosht.SelectedIndex == 2 & comboBoxVtoraPlosht.SelectedIndex == 1)
            {
                a = Convert.ToDouble(textBoxPurvaPlosht.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a / 100;
                    textBoxVtoraPlosht.Text = a.ToString();
                }
            }
            if (comboBoxPurvaPlosht.SelectedIndex == 0 & comboBoxVtoraPlosht.SelectedIndex == 0)
            {
                a = Convert.ToDouble(textBoxPurvaPlosht.Text);
                if (a < 0)
                {

                }
                else
                {
                    textBoxVtoraPlosht.Text = a.ToString();
                }
            }
            if (comboBoxPurvaPlosht.SelectedIndex == 1 & comboBoxVtoraPlosht.SelectedIndex == 1)
            {
                a = Convert.ToDouble(textBoxPurvaPlosht.Text);
                if (a < 0)
                {

                }
                else
                {
                    textBoxVtoraPlosht.Text = a.ToString();
                }
            }
            if (comboBoxPurvaPlosht.SelectedIndex == 2 & comboBoxVtoraPlosht.SelectedIndex == 2)
            {
                a = Convert.ToDouble(textBoxPurvaPlosht.Text);
                if (a < 0)
                {

                }
                else
                {
                    textBoxVtoraPlosht.Text = a.ToString();
                }
            }
        }


        private void началоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            WindowsFormsApplication1.FormNachalo sistema = new WindowsFormsApplication1.FormNachalo();
            sistema.ShowDialog();

            this.Close();
        }

        private void FormMerniEdinici_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void buttonNalqganeIz4isti_Click_1(object sender, EventArgs e)
        {
            textBoxVtoraSkorost.Text = "0";
            textBoxPurvaSkorost.Text = "0";
            textBoxVtoraPlosht.Text = "0";
            textBoxPurvaPlosht.Text = "0";
            textBoxVtoroNalqgane.Text = "0";
            textBoxPurvoNalqgane.Text = "0";
            comboBoxPurvaSkorost.SelectedIndex = 0;
            comboBoxVtoraSkorost.SelectedIndex = 0;
            comboBoxPurvoNalqgane.SelectedIndex = 0;
            comboBoxVtoroNalqgane.SelectedIndex = 0;
            comboBoxPurvaPlosht.SelectedIndex = 0;
            comboBoxVtoraPlosht.SelectedIndex = 0;
        }

        private void buttonObemIz4isti_Click_1(object sender, EventArgs e)
        {
            textBoxVtoraDaljina.Text = "0";
            textBoxPurvaDaljina.Text = "0";
            textBoxVtoraMasa.Text = "0";
            textBoxPurvaMasa.Text = "0";
            textBoxVtoriObem.Text = "0";
            textBoxPurviObem.Text = "0";
            comboBoxPurvaDaljina.SelectedIndex = 0;
            comboBoxVtoraDaljina.SelectedIndex = 0;
            comboBoxPurvaMasa.SelectedIndex = 0;
            comboBoxVtoraMasa.SelectedIndex = 0;
            comboBoxPurviObem.SelectedIndex = 0;
            comboBoxVtoriObem.SelectedIndex = 0;
        }

        private void pictureBoxDaljinaSmqna_Click(object sender, EventArgs e)
        {
            
                a = Convert.ToDouble(textBoxPurvaDaljina.Text);
                b = Convert.ToDouble(textBoxVtoraDaljina.Text);
                textBoxVtoraDaljina.Text = a.ToString();
                textBoxPurvaDaljina.Text = b.ToString();
                int c = comboBoxPurvaDaljina.SelectedIndex;
                comboBoxPurvaDaljina.SelectedIndex = comboBoxVtoraDaljina.SelectedIndex;    
            comboBoxVtoraDaljina.SelectedIndex=c;
            

        }

        private void pictureBoxMasaSmqna_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBoxPurvaMasa.Text);
            b = Convert.ToDouble(textBoxVtoraMasa.Text);
            textBoxVtoraMasa.Text = a.ToString();
            textBoxPurvaMasa.Text = b.ToString();
            int c = comboBoxPurvaMasa.SelectedIndex;
            comboBoxPurvaMasa.SelectedIndex = comboBoxVtoraMasa.SelectedIndex;
            comboBoxVtoraMasa.SelectedIndex = c;
        }

        private void pictureBoxObemSmqna_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBoxPurviObem.Text);
            b = Convert.ToDouble(textBoxVtoriObem.Text);
            textBoxVtoriObem.Text = a.ToString();
            textBoxPurviObem.Text = b.ToString();
            int c = comboBoxPurviObem.SelectedIndex;
            comboBoxPurviObem.SelectedIndex = comboBoxVtoriObem.SelectedIndex;
            comboBoxVtoriObem.SelectedIndex = c;
        }

        private void pictureBoxSkorostSmqna_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBoxPurvaSkorost.Text);
            b = Convert.ToDouble(textBoxVtoraSkorost.Text);
            textBoxVtoraSkorost.Text = a.ToString();
            textBoxPurvaSkorost.Text = b.ToString();
            int c = comboBoxPurvaSkorost.SelectedIndex;
            comboBoxPurvaSkorost.SelectedIndex = comboBoxVtoraSkorost.SelectedIndex;
            comboBoxVtoraSkorost.SelectedIndex = c;
        }

        private void pictureBoxPloshtSmqna_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBoxPurvaPlosht.Text);
            b = Convert.ToDouble(textBoxVtoraPlosht.Text);
            textBoxVtoraPlosht.Text = a.ToString();
            textBoxPurvaPlosht.Text = b.ToString();
            int c = comboBoxPurvaPlosht.SelectedIndex;
            comboBoxPurvaPlosht.SelectedIndex = comboBoxVtoraPlosht.SelectedIndex;
            comboBoxVtoraPlosht.SelectedIndex = c;
        }

        private void авториToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Matemati4eskiNara4nik.FormAvtori sistema = new Matemati4eskiNara4nik.FormAvtori();
            sistema.ShowDialog();
            this.Close();
        }

        private void валутиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (comboBoxPurvoNalqgane.SelectedIndex == 0 & comboBoxVtoroNalqgane.SelectedIndex == 1)
            {
                a = Convert.ToDouble(textBoxPurvoNalqgane.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a / 1000;
                    textBoxVtoroNalqgane.Text = a.ToString();
                }
            }
            if (comboBoxPurvoNalqgane.SelectedIndex == 1 & comboBoxVtoroNalqgane.SelectedIndex == 0)
            {
                a = Convert.ToDouble(textBoxPurvoNalqgane.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a * 1000;
                    textBoxVtoroNalqgane.Text = a.ToString();
                }
            }
            if (comboBoxPurvoNalqgane.SelectedIndex == 0 & comboBoxVtoroNalqgane.SelectedIndex == 0)
            {
                a = Convert.ToDouble(textBoxPurvoNalqgane.Text);
                if (a < 0)
                {

                }
                else
                {
                    textBoxVtoroNalqgane.Text = a.ToString();
                }
            }
            if (comboBoxPurvoNalqgane.SelectedIndex == 1 & comboBoxVtoroNalqgane.SelectedIndex == 1)
            {
                a = Convert.ToDouble(textBoxPurvoNalqgane.Text);
                if (a < 0)
                {

                }
                else
                {
                    textBoxVtoroNalqgane.Text = a.ToString();
                }
            }
            if (comboBoxPurvaSkorost.SelectedIndex == 0 & comboBoxVtoraSkorost.SelectedIndex == 1)
            {
                a = Convert.ToDouble(textBoxPurvaSkorost.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a * 1000 / 3600;
                    textBoxVtoraSkorost.Text = a.ToString();
                }
            }
            if (comboBoxPurvaSkorost.SelectedIndex == 1 & comboBoxVtoraSkorost.SelectedIndex == 0)
            {
                a = Convert.ToDouble(textBoxPurvaSkorost.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a / 1000 * 3600;
                    textBoxVtoraSkorost.Text = a.ToString();
                }
            }
            if (comboBoxPurvaSkorost.SelectedIndex == 0 & comboBoxVtoraSkorost.SelectedIndex == 0)
            {
                a = Convert.ToDouble(textBoxPurvaSkorost.Text);
                if (a < 0)
                {

                }
                else
                {
                    textBoxVtoraSkorost.Text = a.ToString();
                }
            }
            if (comboBoxPurvaSkorost.SelectedIndex == 1 & comboBoxVtoraSkorost.SelectedIndex == 1)
            {
                a = Convert.ToDouble(textBoxPurvaSkorost.Text);
                if (a < 0)
                {

                }
                else
                {
                    textBoxVtoraSkorost.Text = a.ToString();
                }
            }
            if (comboBoxPurvaPlosht.SelectedIndex == 0 & comboBoxVtoraPlosht.SelectedIndex == 1)
            {
                a = Convert.ToDouble(textBoxPurvaPlosht.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a * 10000;
                    textBoxVtoraPlosht.Text = a.ToString();
                }
            }
            if (comboBoxPurvaPlosht.SelectedIndex == 0 & comboBoxVtoraPlosht.SelectedIndex == 2)
            {
                a = Convert.ToDouble(textBoxPurvaPlosht.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a * 1000000;
                    textBoxVtoraPlosht.Text = a.ToString();
                }
            }
            if (comboBoxPurvaPlosht.SelectedIndex == 1 & comboBoxVtoraPlosht.SelectedIndex == 0)
            {
                a = Convert.ToDouble(textBoxPurvaPlosht.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a / 10000;
                    textBoxVtoraPlosht.Text = a.ToString();
                }
            }
            if (comboBoxPurvaPlosht.SelectedIndex == 1 & comboBoxVtoraPlosht.SelectedIndex == 2)
            {
                a = Convert.ToDouble(textBoxPurvaPlosht.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a * 100;
                    textBoxVtoraPlosht.Text = a.ToString();
                }
            }
            if (comboBoxPurvaPlosht.SelectedIndex == 2 & comboBoxVtoraPlosht.SelectedIndex == 0)
            {
                a = Convert.ToDouble(textBoxPurvaPlosht.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a / 1000000;
                    textBoxVtoraPlosht.Text = a.ToString();
                }
            }
            if (comboBoxPurvaPlosht.SelectedIndex == 2 & comboBoxVtoraPlosht.SelectedIndex == 1)
            {
                a = Convert.ToDouble(textBoxPurvaPlosht.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a / 100;
                    textBoxVtoraPlosht.Text = a.ToString();
                }
            }
            if (comboBoxPurvaPlosht.SelectedIndex == 0 & comboBoxVtoraPlosht.SelectedIndex == 0)
            {
                a = Convert.ToDouble(textBoxPurvaPlosht.Text);
                if (a < 0)
                {

                }
                else
                {
                    textBoxVtoraPlosht.Text = a.ToString();
                }
            }
            if (comboBoxPurvaPlosht.SelectedIndex == 1 & comboBoxVtoraPlosht.SelectedIndex == 1)
            {
                a = Convert.ToDouble(textBoxPurvaPlosht.Text);
                if (a < 0)
                {

                }
                else
                {
                    textBoxVtoraPlosht.Text = a.ToString();
                }
            }
            if (comboBoxPurvaPlosht.SelectedIndex == 2 & comboBoxVtoraPlosht.SelectedIndex == 2)
            {
                a = Convert.ToDouble(textBoxPurvaPlosht.Text);
                if (a < 0)
                {

                }
                else
                {
                    textBoxVtoraPlosht.Text = a.ToString();
                }
            }
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

            textBoxVtoraSkorost.Text = "0";
            textBoxPurvaSkorost.Text = "0";
            textBoxVtoraPlosht.Text = "0";
            textBoxPurvaPlosht.Text = "0";
            textBoxVtoroNalqgane.Text = "0";
            textBoxPurvoNalqgane.Text = "0";
            comboBoxPurvaSkorost.SelectedIndex = 0;
            comboBoxVtoraSkorost.SelectedIndex = 0;
            comboBoxPurvoNalqgane.SelectedIndex = 0;
            comboBoxVtoroNalqgane.SelectedIndex = 0;
            comboBoxPurvaPlosht.SelectedIndex = 0;
            comboBoxVtoraPlosht.SelectedIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (comboBoxPurvaDaljina.SelectedIndex == 0 & comboBoxVtoraDaljina.SelectedIndex == 1)
            {
                a = Convert.ToDouble(textBoxPurvaDaljina.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a * 1000;
                    textBoxVtoraDaljina.Text = a.ToString();
                }
            }

            if (comboBoxPurvaDaljina.SelectedIndex == 0 & comboBoxVtoraDaljina.SelectedIndex == 2)
            {

                a = Convert.ToDouble(textBoxPurvaDaljina.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a * 100000;
                    textBoxVtoraDaljina.Text = a.ToString();
                }
            }

            if (comboBoxPurvaDaljina.SelectedIndex == 0 & comboBoxVtoraDaljina.SelectedIndex == 3)
            {
                a = Convert.ToDouble(textBoxPurvaDaljina.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a * 1000000;
                    textBoxVtoraDaljina.Text = a.ToString();
                }
            }
            if (comboBoxPurvaDaljina.SelectedIndex == 1 & comboBoxVtoraDaljina.SelectedIndex == 0)
            {
                a = Convert.ToDouble(textBoxPurvaDaljina.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a / 1000;
                    textBoxVtoraDaljina.Text = a.ToString();
                }
            }
            if (comboBoxPurvaDaljina.SelectedIndex == 1 & comboBoxVtoraDaljina.SelectedIndex == 2)
            {
                a = Convert.ToDouble(textBoxPurvaDaljina.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a * 100;
                    textBoxVtoraDaljina.Text = a.ToString();
                }
            }

            if (comboBoxPurvaDaljina.SelectedIndex == 1 & comboBoxVtoraDaljina.SelectedIndex == 3)
            {
                a = Convert.ToDouble(textBoxPurvaDaljina.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a * 1000;
                    textBoxVtoraDaljina.Text = a.ToString();
                }
            }

            if (comboBoxPurvaDaljina.SelectedIndex == 2 & comboBoxVtoraDaljina.SelectedIndex == 0)
            {
                a = Convert.ToDouble(textBoxPurvaDaljina.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a / 100000;
                    textBoxVtoraDaljina.Text = a.ToString();
                }
            }

            if (comboBoxPurvaDaljina.SelectedIndex == 2 & comboBoxVtoraDaljina.SelectedIndex == 1)
            {
                a = Convert.ToDouble(textBoxPurvaDaljina.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a / 100;
                    textBoxVtoraDaljina.Text = a.ToString();
                }
            }

            if (comboBoxPurvaDaljina.SelectedIndex == 2 & comboBoxVtoraDaljina.SelectedIndex == 3)
            {
                a = Convert.ToDouble(textBoxPurvaDaljina.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a * 10;
                    textBoxVtoraDaljina.Text = a.ToString();
                }
            }

            if (comboBoxPurvaDaljina.SelectedIndex == 3 & comboBoxVtoraDaljina.SelectedIndex == 0)
            {
                a = Convert.ToDouble(textBoxPurvaDaljina.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a / 1000000;
                    textBoxVtoraDaljina.Text = a.ToString();
                }
            }

            if (comboBoxPurvaDaljina.SelectedIndex == 3 & comboBoxVtoraDaljina.SelectedIndex == 1)
            {
                a = Convert.ToDouble(textBoxPurvaDaljina.Text);
                a = a / 1000;
                textBoxVtoraDaljina.Text = a.ToString();
            }
            if (comboBoxPurvaDaljina.SelectedIndex == 3 & comboBoxVtoraDaljina.SelectedIndex == 2)
            {
                a = Convert.ToDouble(textBoxPurvaDaljina.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a / 10;
                    textBoxVtoraDaljina.Text = a.ToString();
                }
            }

            if (comboBoxPurvaDaljina.SelectedIndex == 0 & comboBoxVtoraDaljina.SelectedIndex == 0)
            {
                a = Convert.ToDouble(textBoxPurvaDaljina.Text);
                if (a < 0)
                {

                }
                else
                {
                    textBoxVtoraDaljina.Text = a.ToString();
                }
            }
            if (comboBoxPurvaDaljina.SelectedIndex == 1 & comboBoxVtoraDaljina.SelectedIndex == 1)
            {
                a = Convert.ToDouble(textBoxPurvaDaljina.Text);
                if (a < 0)
                {

                }
                else
                {
                    textBoxVtoraDaljina.Text = a.ToString();
                }
            }
            if (comboBoxPurvaDaljina.SelectedIndex == 2 & comboBoxVtoraDaljina.SelectedIndex == 2)
            {
                a = Convert.ToDouble(textBoxPurvaDaljina.Text);
                if (a < 0)
                {

                }
                else
                {
                    textBoxVtoraDaljina.Text = a.ToString();
                }
            }
            if (comboBoxPurvaDaljina.SelectedIndex == 3 & comboBoxVtoraDaljina.SelectedIndex == 3)
            {
                a = Convert.ToDouble(textBoxPurvaDaljina.Text);
                if (a < 0)
                {

                }
                else
                {
                    textBoxVtoraDaljina.Text = a.ToString();
                }
            }
            if (comboBoxPurviObem.SelectedIndex == 0 & comboBoxVtoriObem.SelectedIndex == 1)
            {
                a = Convert.ToDouble(textBoxPurviObem.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a * 1000;

                    textBoxVtoriObem.Text = a.ToString();

                }
            }
            if (comboBoxPurviObem.SelectedIndex == 1 & comboBoxVtoriObem.SelectedIndex == 0)
            {
                a = Convert.ToDouble(textBoxPurviObem.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a / 1000;
                    textBoxVtoriObem.Text = a.ToString();
                }
            }
            if (comboBoxPurviObem.SelectedIndex == 0 & comboBoxVtoriObem.SelectedIndex == 0)
            {
                a = Convert.ToDouble(textBoxPurviObem.Text);
                if (a < 0)
                {

                }
                else
                {
                    textBoxVtoriObem.Text = a.ToString();
                }
            }
            if (comboBoxPurviObem.SelectedIndex == 1 & comboBoxVtoriObem.SelectedIndex == 1)
            {
                a = Convert.ToDouble(textBoxPurviObem.Text);
                if (a < 0)
                {

                }
                else
                {
                    textBoxVtoriObem.Text = a.ToString();
                }
            }
            if (comboBoxPurvaMasa.SelectedIndex == 0 & comboBoxVtoraMasa.SelectedIndex == 1)
            {
                a = Convert.ToDouble(textBoxPurvaMasa.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a * 1000;
                    textBoxVtoraMasa.Text = a.ToString();
                }
            }
            if (comboBoxPurvaMasa.SelectedIndex == 0 & comboBoxVtoraMasa.SelectedIndex == 2)
            {
                a = Convert.ToDouble(textBoxPurvaMasa.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a * 1000000;
                    textBoxVtoraMasa.Text = a.ToString();
                }
            }
            if (comboBoxPurvaMasa.SelectedIndex == 1 & comboBoxVtoraMasa.SelectedIndex == 0)
            {
                a = Convert.ToDouble(textBoxPurvaMasa.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a / 1000;
                    textBoxVtoraMasa.Text = a.ToString();
                }
            }
            if (comboBoxPurvaMasa.SelectedIndex == 1 & comboBoxVtoraMasa.SelectedIndex == 2)
            {
                a = Convert.ToDouble(textBoxPurvaMasa.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a * 1000;
                    textBoxVtoraMasa.Text = a.ToString();
                }
            }
            if (comboBoxPurvaMasa.SelectedIndex == 2 & comboBoxVtoraMasa.SelectedIndex == 0)
            {
                a = Convert.ToDouble(textBoxPurvaMasa.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a / 1000000;
                    textBoxVtoraMasa.Text = a.ToString();
                }
            }
            if (comboBoxPurvaMasa.SelectedIndex == 2 & comboBoxVtoraMasa.SelectedIndex == 1)
            {
                a = Convert.ToDouble(textBoxPurvaMasa.Text);
                if (a < 0)
                {

                }
                else
                {
                    a = a / 1000;
                    textBoxVtoraMasa.Text = a.ToString();
                }
            }
            if (comboBoxPurvaMasa.SelectedIndex == 0 & comboBoxVtoraMasa.SelectedIndex == 0)
            {
                a = Convert.ToDouble(textBoxPurvaMasa.Text);
                if (a < 0)
                {

                }
                else
                {
                    textBoxVtoraMasa.Text = a.ToString();
                }
                if (comboBoxPurvaMasa.SelectedIndex == 1 & comboBoxVtoraMasa.SelectedIndex == 1)
                {
                    a = Convert.ToDouble(textBoxPurvaMasa.Text);
                    textBoxVtoraMasa.Text = a.ToString();
                }
            }
            if (comboBoxPurvaMasa.SelectedIndex == 2 & comboBoxVtoraMasa.SelectedIndex == 2)
            {
                a = Convert.ToDouble(textBoxPurvaMasa.Text);
                if (a < 0)
                {

                }
                else
                {
                    textBoxVtoraMasa.Text = a.ToString();
                }
            }

        
    }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBoxVtoraDaljina.Text = "0";
            textBoxPurvaDaljina.Text = "0";
            textBoxVtoraMasa.Text = "0";
            textBoxPurvaMasa.Text = "0";
            textBoxVtoriObem.Text = "0";
            textBoxPurviObem.Text = "0";
            comboBoxPurvaDaljina.SelectedIndex = 0;
            comboBoxVtoraDaljina.SelectedIndex = 0;
            comboBoxPurvaMasa.SelectedIndex = 0;
            comboBoxVtoraMasa.SelectedIndex = 0;
            comboBoxPurviObem.SelectedIndex = 0;
            comboBoxVtoriObem.SelectedIndex = 0;
        }

        private void pictureBoxNalqganeSmqna_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBoxPurvoNalqgane.Text);
            b = Convert.ToDouble(textBoxVtoroNalqgane.Text);
            textBoxVtoroNalqgane.Text = a.ToString();
            textBoxPurvoNalqgane.Text = b.ToString();
            int c = comboBoxPurvoNalqgane.SelectedIndex;
            comboBoxPurvoNalqgane.SelectedIndex = comboBoxVtoroNalqgane.SelectedIndex;
            comboBoxVtoroNalqgane.SelectedIndex = c;
        }

       

       
    }
}
