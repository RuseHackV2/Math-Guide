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
    public partial class FormLicenaPravoagalnik : Form
    {
        public FormLicenaPravoagalnik()
        {
            InitializeComponent();
            this.comboBoxStrana2.SelectedIndex = 1;
            this.comboBoxMernaEdinica1.SelectedIndex = 1;
            this.comboBoxRezultat.SelectedIndex = 1;
        }

        private void textBoxdiametar_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonIzchisti_Click(object sender, EventArgs e)
        {

        }

        private void buttonIzchisli_Click(object sender, EventArgs e)
        {

        }

        private void правиленNъгълникToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPurvaStrana_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPurvaStrana_TextChanged_1(object sender, EventArgs e)
        {

        }

        double a, b, p = 0, g = 0;

        private void buttonIzchisti_Click_1(object sender, EventArgs e)
        {

            this.pictureBoxPravoagalnik.Image = null;
            g = 0;
            this.textBoxPurvaStrana.Text = "0";
            this.textBoxStrana2.Text = "0";
            this.textBoxRezultat.Text = "0";

            this.comboBoxMernaEdinica1.SelectedIndex = 1;
            this.comboBoxRezultat.SelectedIndex = 1;
            this.comboBoxStrana2.SelectedIndex = 1;
        }

        private void мерниЕдинициToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Matemati4eskiNara4nik.FormMerniEdinici sistema = new Matemati4eskiNara4nik.FormMerniEdinici();
            sistema.ShowDialog();

            this.Close();
        }

        private void началоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            WindowsFormsApplication1.FormNachalo sistema = new WindowsFormsApplication1.FormNachalo();
            sistema.ShowDialog();

            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if ((this.textBoxPurvaStrana.Text == "0" && this.textBoxStrana2.Text == "0") || (this.textBoxPurvaStrana.Text == "0" && this.textBoxRezultat.Text == "0") || (this.textBoxStrana2.Text == "0" && this.textBoxRezultat.Text == "0"))
            {

                Matemati4eskiNara4nik.FormGreshka sistema = new Matemati4eskiNara4nik.FormGreshka();
                sistema.ShowDialog();


            }


            else

                if (g == 1)
            {
                Matemati4eskiNara4nik.FormGreshkaChisti sistema = new Matemati4eskiNara4nik.FormGreshkaChisti();
                sistema.ShowDialog();

            }
            else
            {

                string aconvect = this.textBoxPurvaStrana.Text.ToString();
                a = Convert.ToDouble(aconvect);
                string bconvect = this.textBoxStrana2.Text.ToString();
                b = Convert.ToDouble(bconvect);
                string pconvect = this.textBoxRezultat.Text.ToString();
                p = Convert.ToDouble(pconvect);
                if (this.comboBoxMernaEdinica1.SelectedIndex == 0)
                {
                    a = a / 10;
                }
                if (this.comboBoxStrana2.SelectedIndex == 0)
                {
                    b = b / 10;
                }
                if (this.comboBoxRezultat.SelectedIndex == 0)
                {
                    p = p / 10;
                }
                if (this.comboBoxMernaEdinica1.SelectedIndex == 2)
                {
                    a = a * 10;
                }
                if (this.comboBoxStrana2.SelectedIndex == 2)
                {
                    b = b * 10;
                }
                if (this.comboBoxRezultat.SelectedIndex == 2)
                {
                    p = p * 10;
                }
                if (this.comboBoxMernaEdinica1.SelectedIndex == 3)
                {
                    a = a * 100;
                }
                if (this.comboBoxStrana2.SelectedIndex == 3)
                {
                    b = b * 100;
                }
                if (this.comboBoxRezultat.SelectedIndex == 3)
                {
                    p = p * 100;
                }

                if (this.textBoxPurvaStrana.Text == "0")
                {
                    a = p / b;

                    this.textBoxPurvaStrana.Text = a.ToString();
                }
                if (this.textBoxStrana2.Text == "0")
                {
                    b = p / a;

                    this.textBoxStrana2.Text = b.ToString();
                }
                if (this.textBoxRezultat.Text == "0")
                {
                    p = a * b;

                    this.textBoxRezultat.Text = p.ToString();
                }




                g = 1;
                if (a != b)
                {

                    Graphics h = this.pictureBoxPravoagalnik.CreateGraphics();
                    Pen v = new Pen(Color.DarkOrange, 10);

                    for (x = 50; x <= 174; x++)
                    {
                        System.Threading.Thread.Sleep(1);

                        h.DrawLine(v, 40, x - 10, 40, x + 1);

                    }
                    for (x = 50; x <= 299; x++)
                    {
                        System.Threading.Thread.Sleep(1);

                        h.DrawLine(v, x - 15, 175, x + 7, 175);


                    }
                    for (x = 175; x >= 51; x--)
                    {
                        System.Threading.Thread.Sleep(1);

                        h.DrawLine(v, 301, x, 301, x - 11);



                    }

                    for (x = 299; x >= 51; x--)
                    {
                        System.Threading.Thread.Sleep(1);

                        h.DrawLine(v, x - 16, 40, x + 7, 40);


                    }

                    Pen k = new Pen(Color.DarkOrange, 5);
                    x = 50;
                    y = 50;
                    while (x != 300)
                    {
                        x = x + 2;
                        y = y + 1;


                        System.Threading.Thread.Sleep(1);
                        h.DrawLine(k, x - 15, y - 8, x + 5, y);

                    }



                }




                if (a == b)
                {

                    Graphics h = this.pictureBoxPravoagalnik.CreateGraphics();
                    Pen v = new Pen(Color.DarkOrange, 10);
                    {
                        System.Threading.Thread.Sleep(1);

                        h.DrawLine(v, 40, x - 10, 40, x + 1);

                    }
                    for (x = 50; x <= 174; x++)
                    {
                        System.Threading.Thread.Sleep(1);

                        h.DrawLine(v, 40, x - 10, 40, x + 1);

                    }
                    for (x = 50; x <= 174; x++)
                    {
                        System.Threading.Thread.Sleep(1);
                        h.DrawLine(v, x - 15, 175, x + 7, 175);


                    }
                    for (x = 175; x >= 51; x--)
                    {
                        System.Threading.Thread.Sleep(1);

                        h.DrawLine(v, 176, x, 176, x - 11);



                    }

                    for (x = 174; x >= 51; x--)
                    {
                        System.Threading.Thread.Sleep(1);

                        h.DrawLine(v, x - 16, 40, x + 7, 40);


                    }


                    x = 50;
                    y = 50;
                    Pen f = new Pen(Color.DarkOrange, 2);
                    while (x != 174)
                    {
                        x = x + 2;
                        y = y + 2;


                        System.Threading.Thread.Sleep(1);
                        h.DrawLine(f, x - 18, y - 15, x + 5, y);

                    }




                }



                if (this.comboBoxMernaEdinica1.SelectedIndex == 0)
                {
                    a = a * 10;
                    this.textBoxPurvaStrana.Text = a.ToString();
                }
                if (this.comboBoxStrana2.SelectedIndex == 0)
                {
                    b = b * 10;
                    this.textBoxStrana2.Text = b.ToString();
                }

                if (this.comboBoxRezultat.SelectedIndex == 0)
                {
                    p = p * 10;
                    this.textBoxRezultat.Text = p.ToString();
                }
                if (this.comboBoxMernaEdinica1.SelectedIndex == 2)
                {
                    a = a / 10;
                    this.textBoxPurvaStrana.Text = a.ToString();
                }
                if (this.comboBoxStrana2.SelectedIndex == 2)
                {
                    b = b / 10;
                    this.textBoxStrana2.Text = b.ToString();
                }

                if (this.comboBoxRezultat.SelectedIndex == 2)
                {
                    p = p / 10;
                    this.textBoxRezultat.Text = p.ToString();
                }
                if (this.comboBoxMernaEdinica1.SelectedIndex == 3)
                {
                    a = a / 100;
                    this.textBoxPurvaStrana.Text = a.ToString();
                }
                if (this.comboBoxStrana2.SelectedIndex == 3)
                {
                    b = b / 100;
                    this.textBoxStrana2.Text = b.ToString();
                }

                if (this.comboBoxRezultat.SelectedIndex == 3)
                {
                    p = p / 100;
                    this.textBoxRezultat.Text = p.ToString();

                }
            }
        
    
}

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.pictureBoxPravoagalnik.Image = null;
            g = 0;
            this.textBoxPurvaStrana.Text = "0";
            this.textBoxStrana2.Text = "0";
            this.textBoxRezultat.Text = "0";

            this.comboBoxMernaEdinica1.SelectedIndex = 1;
            this.comboBoxRezultat.SelectedIndex = 1;
            this.comboBoxStrana2.SelectedIndex = 1;
        }

        private void menuStripGlaavnoMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        int x = 0, y = 0;
        private void buttonIzchisli_Click_1(object sender, EventArgs e)
        {
            if ((this.textBoxPurvaStrana.Text == "0" && this.textBoxStrana2.Text == "0" )||(this.textBoxPurvaStrana.Text == "0" && this.textBoxRezultat.Text == "0") || (this.textBoxStrana2.Text == "0" && this.textBoxRezultat.Text == "0"))
            {

                Matemati4eskiNara4nik.FormGreshka sistema = new Matemati4eskiNara4nik.FormGreshka();
                sistema.ShowDialog();


            }


            else

                if (g == 1)
            {
                Matemati4eskiNara4nik.FormGreshkaChisti sistema = new Matemati4eskiNara4nik.FormGreshkaChisti();
                sistema.ShowDialog();

            }
            else
            {

                string aconvect = this.textBoxPurvaStrana.Text.ToString();
                a = Convert.ToDouble(aconvect);
                string bconvect = this.textBoxStrana2.Text.ToString();
                b = Convert.ToDouble(bconvect);
                string pconvect = this.textBoxRezultat.Text.ToString();
                p = Convert.ToDouble(pconvect);
                if (this.comboBoxMernaEdinica1.SelectedIndex == 0)
                {
                    a = a / 10;
                }
                if (this.comboBoxStrana2.SelectedIndex == 0)
                {
                    b = b / 10;
                }
                if (this.comboBoxRezultat.SelectedIndex == 0)
                {
                    p = p / 10;
                }
                if (this.comboBoxMernaEdinica1.SelectedIndex == 2)
                {
                    a = a * 10;
                }
                if (this.comboBoxStrana2.SelectedIndex == 2)
                {
                    b = b * 10;
                }
                if (this.comboBoxRezultat.SelectedIndex == 2)
                {
                    p = p * 10;
                }
                if (this.comboBoxMernaEdinica1.SelectedIndex == 3)
                {
                    a = a * 100;
                }
                if (this.comboBoxStrana2.SelectedIndex == 3)
                {
                    b = b * 100;
                }
                if (this.comboBoxRezultat.SelectedIndex == 3)
                {
                    p = p * 100;
                }

                if (this.textBoxPurvaStrana.Text == "0")
                {
                    a = p / b;

                    this.textBoxPurvaStrana.Text = a.ToString();
                }
                if (this.textBoxStrana2.Text == "0")
                {
                    b = p / a;

                    this.textBoxStrana2.Text = b.ToString();
                }
                if (this.textBoxRezultat.Text == "0")
                {
                    p = a * b;

                    this.textBoxRezultat.Text = p.ToString();
                }




                g = 1;
                if (a != b)
                {

                    Graphics h = this.pictureBoxPravoagalnik.CreateGraphics();
                    Pen v = new Pen(Color.DarkOrange, 10);

                    for (x = 50; x <= 174; x++)
                    {
                        System.Threading.Thread.Sleep(1);

                        h.DrawLine(v, 40, x - 10, 40, x + 1);

                    }
                    for (x = 50; x <= 299; x++)
                    {
                        System.Threading.Thread.Sleep(1);

                        h.DrawLine(v, x - 15, 175, x + 7, 175);


                    }
                    for (x = 175; x >= 51; x--)
                    {
                        System.Threading.Thread.Sleep(1);

                        h.DrawLine(v, 301, x, 301, x - 11);



                    }

                    for (x = 299; x >= 51; x--)
                    {
                        System.Threading.Thread.Sleep(1);

                        h.DrawLine(v, x - 16, 40, x + 7, 40);


                    }

                    Pen k = new Pen(Color.DarkOrange, 5);
                    x = 50;
                    y = 50;
                    while (x != 300)
                    {
                        x = x + 2;
                        y = y + 1;


                        System.Threading.Thread.Sleep(1);
                        h.DrawLine(k, x - 15, y - 8, x + 5, y);

                    }



                }




                if (a == b)
                {

                    Graphics h = this.pictureBoxPravoagalnik.CreateGraphics();
                    Pen v = new Pen(Color.DarkOrange, 10);
                    {
                        System.Threading.Thread.Sleep(1);

                        h.DrawLine(v, 40, x - 10, 40, x + 1);

                    }
                    for (x = 50; x <= 174; x++)
                    {
                        System.Threading.Thread.Sleep(1);

                        h.DrawLine(v, 40, x - 10, 40, x + 1);

                    }
                    for (x = 50; x <= 174; x++)
                    {
                        System.Threading.Thread.Sleep(1);
                        h.DrawLine(v, x - 15, 175, x + 7, 175);


                    }
                    for (x = 175; x >= 51; x--)
                    {
                        System.Threading.Thread.Sleep(1);

                        h.DrawLine(v, 176, x, 176, x - 11);



                    }

                    for (x = 174; x >= 51; x--)
                    {
                        System.Threading.Thread.Sleep(1);

                        h.DrawLine(v, x - 16, 40, x + 7, 40);


                    }


                    x = 50;
                    y = 50;
                    Pen f = new Pen(Color.DarkOrange, 2);
                    while (x != 174)
                    {
                        x = x + 2;
                        y = y + 2;


                        System.Threading.Thread.Sleep(1);
                        h.DrawLine(f, x - 18, y - 15, x + 5, y);

                    }




                }



                if (this.comboBoxMernaEdinica1.SelectedIndex == 0)
                {
                    a = a * 10;
                    this.textBoxPurvaStrana.Text = a.ToString();
                }
                if (this.comboBoxStrana2.SelectedIndex == 0)
                {
                    b = b * 10;
                    this.textBoxStrana2.Text = b.ToString();
                }

                if (this.comboBoxRezultat.SelectedIndex == 0)
                {
                    p = p * 10;
                    this.textBoxRezultat.Text = p.ToString();
                }
                if (this.comboBoxMernaEdinica1.SelectedIndex == 2)
                {
                    a = a / 10;
                    this.textBoxPurvaStrana.Text = a.ToString();
                }
                if (this.comboBoxStrana2.SelectedIndex == 2)
                {
                    b = b / 10;
                    this.textBoxStrana2.Text = b.ToString();
                }

                if (this.comboBoxRezultat.SelectedIndex == 2)
                {
                    p = p / 10;
                    this.textBoxRezultat.Text = p.ToString();
                }
                if (this.comboBoxMernaEdinica1.SelectedIndex == 3)
                {
                    a = a / 100;
                    this.textBoxPurvaStrana.Text = a.ToString();
                }
                if (this.comboBoxStrana2.SelectedIndex == 3)
                {
                    b = b / 100;
                    this.textBoxStrana2.Text = b.ToString();
                }

                if (this.comboBoxRezultat.SelectedIndex == 3)
                {
                    p = p / 100;
                    this.textBoxRezultat.Text = p.ToString();

                }
            }
        }
    }
}
        
    

