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
    public partial class FormObikolkaPravoagalnik : Form
    {
        public FormObikolkaPravoagalnik()
        {
            InitializeComponent();
            this.comboBoxStrana2.SelectedIndex = 1;
            this.comboBoxMernaEdinica1.SelectedIndex = 1;
            this.comboBoxRezultat.SelectedIndex = 1;
            this.comboBoxDiametur.SelectedIndex = 1;
        }
        double a, b, d, p = 0, g = 0;
        int x = 0, y = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonIzchisli_Click(object sender, EventArgs e)
        {


            if ((this.textBoxPurvaStrana.Text == "0" && this.textBoxStrana2.Text == "0" && this.textBoxdiagunal.Text == "0") || (this.textBoxPurvaStrana.Text == "0" && this.textBoxStrana2.Text == "0" && this.textBoxRezultat.Text == "0") || (this.textBoxPurvaStrana.Text == "0" && this.textBoxRezultat.Text == "0" && this.textBoxdiagunal.Text == "0") || (this.textBoxRezultat.Text == "0" && this.textBoxStrana2.Text == "0" && this.textBoxdiagunal.Text == "0"))
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

                    string dconvect = this.textBoxdiagunal.Text.ToString();
                    d = Convert.ToDouble(dconvect);
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
                    if (this.comboBoxDiametur.SelectedIndex == 0)
                    {
                        d = d / 10;
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
                    if (this.comboBoxDiametur.SelectedIndex == 2)
                    {
                        d = d * 10;
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
                    if (this.comboBoxDiametur.SelectedIndex == 3)
                    {
                        d = d * 100;
                    }
                    if (this.comboBoxRezultat.SelectedIndex == 3)
                    {
                        p = p * 100;
                    }
                    if (this.textBoxdiagunal.Text == "0" && this.textBoxRezultat.Text == "0")
                    {
                        d = Math.Sqrt((a * a) + (b * b));
                        this.textBoxdiagunal.Text = d.ToString();

                        p = 2 * (a + b);
                        this.textBoxRezultat.Text = p.ToString();



                    }
                    if (this.textBoxStrana2.Text == "0" && this.textBoxRezultat.Text == "0")
                    {

                        b = (d * d) - (a * a);
                        b = Math.Sqrt(b);
                        p = 2 * a + 2 * b;
                        this.textBoxRezultat.Text = p.ToString();

                        this.textBoxStrana2.Text = b.ToString();
                    }
                    if (this.textBoxPurvaStrana.Text == "0" && this.textBoxRezultat.Text == "0")
                    {
                        a = (d * d) - (b * b);
                        a = Math.Sqrt(a);
                        p = 2 * a + 2 * b;
                        this.textBoxRezultat.Text = p.ToString();

                        this.textBoxPurvaStrana.Text = a.ToString();
                    }
                    if (this.textBoxdiagunal.Text == "0" && this.textBoxStrana2.Text == "0")
                    {

                        b = (p - (2 * a)) / 2;
                        d = Math.Sqrt((a * a) + (b * b));
                        p = 2 * a + 2 * b;
                        this.textBoxStrana2.Text = b.ToString();

                        this.textBoxdiagunal.Text = d.ToString();
                    }
                    if (this.textBoxdiagunal.Text == "0" && this.textBoxPurvaStrana.Text == "0")
                    {

                        a = (p - (2 * b)) / 2;
                        d = Math.Sqrt((a * a) + (b * b));
                        p = 2 * a + 2 * b;
                        this.textBoxPurvaStrana.Text = a.ToString();

                        this.textBoxdiagunal.Text = d.ToString();
                    }
                    if (this.textBoxStrana2.Text == "0" && this.textBoxPurvaStrana.Text == "0")
                    {
                        double akvadratno, bkvadratno, diskreminanta, pe;

                        pe = p / 2;
                        bkvadratno = pe * pe;
                        pe = pe * pe;
                        pe = pe - (d * d);
                        akvadratno = 2;
                        diskreminanta = bkvadratno - akvadratno * pe;
                        diskreminanta = Math.Sqrt(diskreminanta);
                        b = ((p / 2) + diskreminanta) / 2;
                        a = p / 2 - b;
                        d = Math.Sqrt((a * a) + (b * b));

                        this.textBoxPurvaStrana.Text = a.ToString();

                        this.textBoxStrana2.Text = b.ToString();
                    }
                    if (this.textBoxdiagunal.Text != "0" && this.textBoxPurvaStrana.Text != "0" && this.textBoxStrana2.Text != "0")
                    {

                        p = 2 * (a + b);
                        this.textBoxRezultat.Text = p.ToString();
                    }
                    if (this.textBoxRezultat.Text != "0" && this.textBoxPurvaStrana.Text != "0" && this.textBoxStrana2.Text != "0")
                    {

                        d = Math.Sqrt((a * a) + (b * b));
                        this.textBoxdiagunal.Text = d.ToString();
                    }
                    if (this.textBoxdiagunal.Text != "0" && this.textBoxRezultat.Text != "0" && this.textBoxStrana2.Text != "0")
                    {

                        a = p / 2 - b;
                        this.textBoxPurvaStrana.Text = a.ToString();
                    }
                    if (this.textBoxdiagunal.Text != "0" && this.textBoxPurvaStrana.Text != "0" && this.textBoxRezultat.Text != "0")
                    {

                        b = p / 2 - a;
                        this.textBoxStrana2.Text = b.ToString();
                    }






                    g = 1;
                    if (a != b)
                    {
                    
                    Graphics h = this.pictureBoxPravoagalnik.CreateGraphics();
                            Pen v = new Pen(Color.DarkOrange,10);

                            for (x = 50; x <= 174; x++)
                            {
                                System.Threading.Thread.Sleep(1);

                                h.DrawLine(v, 40, x-10, 40, x+1);
                                
                            }
                            for (x = 50; x <= 299; x++)
                            {
                                System.Threading.Thread.Sleep(1);

                                h.DrawLine(v, x-15, 175, x + 7, 175);
                                

                            }
                            for (x = 175; x >= 51; x--)
                            {
                                System.Threading.Thread.Sleep(1);

                                h.DrawLine(v, 301, x, 301, x - 11);
                                


                            }

                            for (x = 299; x >= 51; x--)
                            {
                                System.Threading.Thread.Sleep(1);

                                h.DrawLine(v, x-16, 40, x + 7, 40);
                               

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
                        Pen v = new Pen(Color.DarkOrange,10);
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
            if (this.comboBoxDiametur.SelectedIndex == 0)
            {
                d = d * 10;
                this.textBoxdiagunal.Text = d.ToString();
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
            if (this.comboBoxDiametur.SelectedIndex == 2)
            {
                d = d / 10;
                this.textBoxdiagunal.Text = d.ToString();
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
            if (this.comboBoxDiametur.SelectedIndex == 3)
            {
                d = d / 100;
                this.textBoxdiagunal.Text = d.ToString();
            }
            if (this.comboBoxRezultat.SelectedIndex == 3)
            {
                p = p / 100;
                this.textBoxRezultat.Text = p.ToString();
            }
        }

        private void textBoxPurvaStrana_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMernaEdinica1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void textBoxdiametar_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonIzchisti_Click(object sender, EventArgs e)
        {
            this.pictureBoxPravoagalnik.Image = null;
            g = 0;
            this.textBoxPurvaStrana.Text = "0";
            this.textBoxStrana2.Text = "0";
            this.textBoxRezultat.Text = "0";
            this.textBoxdiagunal.Text = "0";
            this.comboBoxDiametur.SelectedIndex = 1;
            this.comboBoxMernaEdinica1.SelectedIndex = 1;
            this.comboBoxRezultat.SelectedIndex = 1;
            this.comboBoxStrana2.SelectedIndex = 1;
        }



        private void pictureBoxPravoagalnik_Click(object sender, EventArgs e)
        {



        }

        private void мерниЕдинициToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Matemati4eskiNara4nik.FormMerniEdinici sistema = new Matemati4eskiNara4nik.FormMerniEdinici();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {


            if ((this.textBoxPurvaStrana.Text == "0" && this.textBoxStrana2.Text == "0" && this.textBoxdiagunal.Text == "0") || (this.textBoxPurvaStrana.Text == "0" && this.textBoxStrana2.Text == "0" && this.textBoxRezultat.Text == "0") || (this.textBoxPurvaStrana.Text == "0" && this.textBoxRezultat.Text == "0" && this.textBoxdiagunal.Text == "0") || (this.textBoxRezultat.Text == "0" && this.textBoxStrana2.Text == "0" && this.textBoxdiagunal.Text == "0"))
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

                string dconvect = this.textBoxdiagunal.Text.ToString();
                d = Convert.ToDouble(dconvect);
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
                if (this.comboBoxDiametur.SelectedIndex == 0)
                {
                    d = d / 10;
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
                if (this.comboBoxDiametur.SelectedIndex == 2)
                {
                    d = d * 10;
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
                if (this.comboBoxDiametur.SelectedIndex == 3)
                {
                    d = d * 100;
                }
                if (this.comboBoxRezultat.SelectedIndex == 3)
                {
                    p = p * 100;
                }
                if (this.textBoxdiagunal.Text == "0" && this.textBoxRezultat.Text == "0")
                {
                    d = Math.Sqrt((a * a) + (b * b));
                    this.textBoxdiagunal.Text = d.ToString();

                    p = 2 * (a + b);
                    this.textBoxRezultat.Text = p.ToString();



                }
                if (this.textBoxStrana2.Text == "0" && this.textBoxRezultat.Text == "0")
                {

                    b = (d * d) - (a * a);
                    b = Math.Sqrt(b);
                    p = 2 * a + 2 * b;
                    this.textBoxRezultat.Text = p.ToString();

                    this.textBoxStrana2.Text = b.ToString();
                }
                if (this.textBoxPurvaStrana.Text == "0" && this.textBoxRezultat.Text == "0")
                {
                    a = (d * d) - (b * b);
                    a = Math.Sqrt(a);
                    p = 2 * a + 2 * b;
                    this.textBoxRezultat.Text = p.ToString();

                    this.textBoxPurvaStrana.Text = a.ToString();
                }
                if (this.textBoxdiagunal.Text == "0" && this.textBoxStrana2.Text == "0")
                {

                    b = (p - (2 * a)) / 2;
                    d = Math.Sqrt((a * a) + (b * b));
                    p = 2 * a + 2 * b;
                    this.textBoxStrana2.Text = b.ToString();

                    this.textBoxdiagunal.Text = d.ToString();
                }
                if (this.textBoxdiagunal.Text == "0" && this.textBoxPurvaStrana.Text == "0")
                {

                    a = (p - (2 * b)) / 2;
                    d = Math.Sqrt((a * a) + (b * b));
                    p = 2 * a + 2 * b;
                    this.textBoxPurvaStrana.Text = a.ToString();

                    this.textBoxdiagunal.Text = d.ToString();
                }
                if (this.textBoxStrana2.Text == "0" && this.textBoxPurvaStrana.Text == "0")
                {
                    double akvadratno, bkvadratno, diskreminanta, pe;

                    pe = p / 2;
                    bkvadratno = pe * pe;
                    pe = pe * pe;
                    pe = pe - (d * d);
                    akvadratno = 2;
                    diskreminanta = bkvadratno - akvadratno * pe;
                    diskreminanta = Math.Sqrt(diskreminanta);
                    b = ((p / 2) + diskreminanta) / 2;
                    a = p / 2 - b;
                    d = Math.Sqrt((a * a) + (b * b));

                    this.textBoxPurvaStrana.Text = a.ToString();

                    this.textBoxStrana2.Text = b.ToString();
                }
                if (this.textBoxdiagunal.Text != "0" && this.textBoxPurvaStrana.Text != "0" && this.textBoxStrana2.Text != "0")
                {

                    p = 2 * (a + b);
                    this.textBoxRezultat.Text = p.ToString();
                }
                if (this.textBoxRezultat.Text != "0" && this.textBoxPurvaStrana.Text != "0" && this.textBoxStrana2.Text != "0")
                {

                    d = Math.Sqrt((a * a) + (b * b));
                    this.textBoxdiagunal.Text = d.ToString();
                }
                if (this.textBoxdiagunal.Text != "0" && this.textBoxRezultat.Text != "0" && this.textBoxStrana2.Text != "0")
                {

                    a = p / 2 - b;
                    this.textBoxPurvaStrana.Text = a.ToString();
                }
                if (this.textBoxdiagunal.Text != "0" && this.textBoxPurvaStrana.Text != "0" && this.textBoxRezultat.Text != "0")
                {

                    b = p / 2 - a;
                    this.textBoxStrana2.Text = b.ToString();
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
            if (this.comboBoxDiametur.SelectedIndex == 0)
            {
                d = d * 10;
                this.textBoxdiagunal.Text = d.ToString();
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
            if (this.comboBoxDiametur.SelectedIndex == 2)
            {
                d = d / 10;
                this.textBoxdiagunal.Text = d.ToString();
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
            if (this.comboBoxDiametur.SelectedIndex == 3)
            {
                d = d / 100;
                this.textBoxdiagunal.Text = d.ToString();
            }
            if (this.comboBoxRezultat.SelectedIndex == 3)
            {
                p = p / 100;
                this.textBoxRezultat.Text = p.ToString();
            }
        

    }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.pictureBoxPravoagalnik.Image = null;
            g = 0;
            this.textBoxPurvaStrana.Text = "0";
            this.textBoxStrana2.Text = "0";
            this.textBoxRezultat.Text = "0";
            this.textBoxdiagunal.Text = "0";
            this.comboBoxDiametur.SelectedIndex = 1;
            this.comboBoxMernaEdinica1.SelectedIndex = 1;
            this.comboBoxRezultat.SelectedIndex = 1;
            this.comboBoxStrana2.SelectedIndex = 1;
        }

        private void FormObikolkaPravoagalnik_Load(object sender, EventArgs e)
        {

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
            {
                this.Hide();
                Matemati4eskiNara4nik.FormObikolkaNaTriagalnik sistema = new Matemati4eskiNara4nik.FormObikolkaNaTriagalnik();
                sistema.ShowDialog();

                this.Close();
            }
        }

        private void правиленNъгълникToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Matemati4eskiNara4nik.FormNAgalnik sistema = new Matemati4eskiNara4nik.FormNAgalnik();
            sistema.ShowDialog();
            this.Close(); 
        }

        private void валутиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Matemati4eskiNara4nik.FormValuti sistema = new Matemati4eskiNara4nik.FormValuti();
            sistema.ShowDialog();

            this.Close();
        }

    }
}
    