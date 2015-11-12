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
    public partial class FormObikolkaNaTriagalnik : Form
    {
        public FormObikolkaNaTriagalnik()
        {
            InitializeComponent();
            this.comboBoxStrana2.SelectedIndex = 1;
            this.comboBoxMernaEdinica1.SelectedIndex = 1;
            this.comboBoxRezultat.SelectedIndex = 1;
            this.comboBoxDiametur.SelectedIndex = 1;
        }

        private void FormObikolkaNaTriagalnik_Load(object sender, EventArgs e)
        {

        }
        double a, b, c, p,g=0, agala,agalb,agalc;
        private void buttonIzchisli_Click(object sender, EventArgs e)
        {
            if ((this.textBoxA.Text == "0" && this.textBoxB.Text == "0" && this.textBoxC.Text == "0") || (this.textBoxA.Text == "0" && this.textBoxB.Text == "0" && this.textBoxP.Text == "0") || (this.textBoxA.Text == "0" && this.textBoxP.Text == "0" && this.textBoxC.Text == "0") || (this.textBoxP.Text == "0" && this.textBoxB.Text == "0" && this.textBoxC.Text == "0"))
            {

                Matemati4eskiNara4nik.FormGreshka sistema = new Matemati4eskiNara4nik.FormGreshka();
                sistema.ShowDialog();

                g = 0;
            }


            else

                if (g == 1)
            {
                Matemati4eskiNara4nik.FormGreshkaChisti sistema = new Matemati4eskiNara4nik.FormGreshkaChisti();
                sistema.ShowDialog();
                g = 0;
            }
            else
            {
                string dconvect = this.textBoxC.Text.ToString();
                c = Convert.ToDouble(dconvect);
                string aconvect = this.textBoxA.Text.ToString();
                a = Convert.ToDouble(aconvect);
                string bconvect = this.textBoxB.Text.ToString();
                b = Convert.ToDouble(bconvect);
                string pconvect = this.textBoxP.Text.ToString();
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
                    c = c / 10;
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
                    c = c * 10;
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
                    c = c * 100;
                }
                if (this.comboBoxRezultat.SelectedIndex == 3)
                {
                    p = p * 100;
                }
                if ((b >= a + c) || (c >= b + a) || (a >= b + c))
                {
                    Matemati4eskiNara4nik.FormTriagalnikGreshka sistema = new Matemati4eskiNara4nik.FormTriagalnikGreshka();
                    sistema.ShowDialog();
                }
                else
                    {
                        if (this.textBoxP.Text == "0")
                        {
                            p = a + b + c;
                            this.textBoxP.Text = p.ToString();
                        }
                        if (this.textBoxA.Text == "0")
                        {

                            a = p - (b + c);
                            this.textBoxA.Text = a.ToString();
                        }
                        if (this.textBoxB.Text == "0")
                        {

                            b = p - (a + c);
                            this.textBoxB.Text = b.ToString();
                        }
                        if (this.textBoxC.Text == "0")
                        {

                            c = p - (b + a);
                            this.textBoxC.Text = a.ToString();
                        }
                        if (a == b && b == c && a == c)
                            this.comboBoxVidove.SelectedIndex = 2;
                        else
                            if (a == b || b == c || a == c)
                            this.comboBoxVidove.SelectedIndex = 0;
                        else
                                if (a != b && b != c && a != c)

                            this.comboBoxVidove.SelectedIndex = 1;
                        // poluchavane na aglite po 3 dadeni strani
                        agala = (a * a + b * b - c * c) / (2 * a * b);
                        agalb = (a * a + c * c - b * b) / (2 * a * c);
                        agalc = (c * c + b * b - a * a) / (2 * b * c);
                    // prevrushtane ot radiani v gradusi
                        agala = (Math.Acos(agala) * 57.29578);
                        agalb = (Math.Acos(agalb) * 57.29578);
                        agalc = (Math.Acos(agalc) * 57.29578);
                    // zakruglqne na aglite
                        agala = Math.Round(agala, 3);
                        agalb = Math.Round(agalb, 3);
                        agalc = Math.Round(agalc, 3);
                    this.textBoxagala.Text = agala.ToString();
                        this.textBoxagalb.Text = agalb.ToString();
                        this.textBoxagalc.Text = agalc.ToString();

                        int x, y;

                        if (this.comboBoxVidove.SelectedIndex == 0 || this.comboBoxVidove.SelectedIndex == 2)
                        {
                            Graphics h = this.pictureBoxTriagalnik.CreateGraphics();
                            Pen v = new Pen(Color.DarkOrange,10);
                            x = 175;
                            y = 50;
                            while (x != 299)
                            {



                                x = x + 1;
                                y = y + 1;


                                System.Threading.Thread.Sleep(4);
                                h.DrawLine(v, x-5, y-5, x + 7, y + 3);
                                
                            }
                            x = 175;
                            y = 50;
                            while (x != 50)
                            {
                                x = x - 1;
                                y = y + 1;


                                System.Threading.Thread.Sleep(4);
                                h.DrawLine(v, x, y, x - 1, y + 1);
                                h.DrawLine(v, x + 1, y + 1, x + 1, y + 2);
                                h.DrawLine(v, x + 2, y + 2, x + 2, y + 3);
                                h.DrawLine(v, x + 3, y + 3, x + 3, y + 4);
                            }

                            for (x = 50; x <= 299; x++)
                            {
                                System.Threading.Thread.Sleep(4);

                                h.DrawLine(v, x, 175, x + 1, 175);
                                h.DrawLine(v, x + 1, 176, x + 2, 176);
                                h.DrawLine(v, x + 2, 177, x + 3, 177);
                                h.DrawLine(v, x - 1, 174, x, 174);

                            }
                        }
                        if (this.comboBoxVidove.SelectedIndex == 1)
                        {
                            Graphics h = this.pictureBoxTriagalnik.CreateGraphics();
                            Pen v = new Pen(Color.DarkOrange,10);
                            h.DrawLine(v, 50, 150, 300, 150);
                            h.DrawLine(v, 300, 150, 90, 100);
                            h.DrawLine(v, 95, 100, 52, 150);
                        }
                    }
                }
        }

        private void buttonIzchisti_Click(object sender, EventArgs e)
        {
            this.pictureBoxTriagalnik.Image = null;
            g = 0;
            this.textBoxA.Text = "0";
            this.textBoxB.Text = "0";
            this.textBoxC.Text = "0";
            this.textBoxP.Text = "0";
            this.textBoxagalc.Text = "0";
            this.textBoxagalb.Text = "0";
            this.textBoxagala.Text = "0";
            this.comboBoxDiametur.SelectedIndex = 1;
            this.comboBoxMernaEdinica1.SelectedIndex = 1;
            this.comboBoxRezultat.SelectedIndex = 1;
            this.comboBoxStrana2.SelectedIndex = 1;
            this.comboBoxVidove.SelectedIndex = -1;
        }

        private void pictureBoxTriagalnik_Click(object sender, EventArgs e)
        {
            
                


                
            
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if ((this.textBoxA.Text == "0" && this.textBoxB.Text == "0" && this.textBoxC.Text == "0") || (this.textBoxA.Text == "0" && this.textBoxB.Text == "0" && this.textBoxP.Text == "0") || (this.textBoxA.Text == "0" && this.textBoxP.Text == "0" && this.textBoxC.Text == "0") || (this.textBoxP.Text == "0" && this.textBoxB.Text == "0" && this.textBoxC.Text == "0"))
            {

                Matemati4eskiNara4nik.FormGreshka sistema = new Matemati4eskiNara4nik.FormGreshka();
                sistema.ShowDialog();

                g = 0;
            }


            else

               if (g == 1)
            {
                Matemati4eskiNara4nik.FormGreshkaChisti sistema = new Matemati4eskiNara4nik.FormGreshkaChisti();
                sistema.ShowDialog();
                g = 0;
            }
            else
            {
                string dconvect = this.textBoxC.Text.ToString();
                c = Convert.ToDouble(dconvect);
                string aconvect = this.textBoxA.Text.ToString();
                a = Convert.ToDouble(aconvect);
                string bconvect = this.textBoxB.Text.ToString();
                b = Convert.ToDouble(bconvect);
                string pconvect = this.textBoxP.Text.ToString();
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
                    c = c / 10;
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
                    c = c * 10;
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
                    c = c * 100;
                }
                if (this.comboBoxRezultat.SelectedIndex == 3)
                {
                    p = p * 100;
                }
                if ((b >= a + c) || (c >= b + a) || (a >= b + c))
                {
                    Matemati4eskiNara4nik.FormTriagalnikGreshka sistema = new Matemati4eskiNara4nik.FormTriagalnikGreshka();
                    sistema.ShowDialog();
                }
                else
                {
                    if (this.textBoxP.Text == "0")
                    {
                        p = a + b + c;
                        this.textBoxP.Text = p.ToString();
                    }
                    if (this.textBoxA.Text == "0")
                    {

                        a = p - (b + c);
                        this.textBoxA.Text = a.ToString();
                    }
                    if (this.textBoxB.Text == "0")
                    {

                        b = p - (a + c);
                        this.textBoxB.Text = b.ToString();
                    }
                    if (this.textBoxC.Text == "0")
                    {

                        c = p - (b + a);
                        this.textBoxC.Text = a.ToString();
                    }
                    if (a == b && b == c && a == c)
                        this.comboBoxVidove.SelectedIndex = 2;
                    else
                        if (a == b || b == c || a == c)
                        this.comboBoxVidove.SelectedIndex = 0;
                    else
                            if (a != b && b != c && a != c)

                        this.comboBoxVidove.SelectedIndex = 1;
                    // poluchavane na aglite po 3 dadeni strani
                    agala = (a * a + b * b - c * c) / (2 * a * b);
                    agalb = (a * a + c * c - b * b) / (2 * a * c);
                    agalc = (c * c + b * b - a * a) / (2 * b * c);
                    // prevrushtane ot radiani v gradusi
                    agala = (Math.Acos(agala) * 57.29578);
                    agalb = (Math.Acos(agalb) * 57.29578);
                    agalc = (Math.Acos(agalc) * 57.29578);
                    // zakruglqne na aglite
                    agala = Math.Round(agala, 3);
                    agalb = Math.Round(agalb, 3);
                    agalc = Math.Round(agalc, 3);
                    this.textBoxagala.Text = agala.ToString();
                    this.textBoxagalb.Text = agalb.ToString();
                    this.textBoxagalc.Text = agalc.ToString();

                    int x, y;

                    if (this.comboBoxVidove.SelectedIndex == 0 || this.comboBoxVidove.SelectedIndex == 2)
                    {
                        Graphics h = this.pictureBoxTriagalnik.CreateGraphics();
                        Pen v = new Pen(Color.DarkOrange, 10);
                        x = 175;
                        y = 50;
                        while (x != 299)
                        {



                            x = x + 1;
                            y = y + 1;


                            System.Threading.Thread.Sleep(4);
                            h.DrawLine(v, x - 5, y - 5, x + 7, y + 3);

                        }
                        x = 175;
                        y = 50;
                        while (x != 50)
                        {
                            x = x - 1;
                            y = y + 1;


                            System.Threading.Thread.Sleep(4);
                            h.DrawLine(v, x, y, x - 1, y + 1);
                            h.DrawLine(v, x + 1, y + 1, x + 1, y + 2);
                            h.DrawLine(v, x + 2, y + 2, x + 2, y + 3);
                            h.DrawLine(v, x + 3, y + 3, x + 3, y + 4);
                        }

                        for (x = 50; x <= 299; x++)
                        {
                            System.Threading.Thread.Sleep(4);

                            h.DrawLine(v, x, 175, x + 1, 175);
                            h.DrawLine(v, x + 1, 176, x + 2, 176);
                            h.DrawLine(v, x + 2, 177, x + 3, 177);
                            h.DrawLine(v, x - 1, 174, x, 174);

                        }
                    }
                    if (this.comboBoxVidove.SelectedIndex == 1)
                    {
                        Graphics h = this.pictureBoxTriagalnik.CreateGraphics();
                        Pen v = new Pen(Color.DarkOrange, 10);
                        h.DrawLine(v, 50, 150, 300, 150);
                        h.DrawLine(v, 300, 150, 90, 100);
                        h.DrawLine(v, 95, 100, 52, 150);
                    }
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.pictureBoxTriagalnik.Image = null;
            g = 0;
            this.textBoxA.Text = "0";
            this.textBoxB.Text = "0";
            this.textBoxC.Text = "0";
            this.textBoxP.Text = "0";
            this.textBoxagalc.Text = "0";
            this.textBoxagalb.Text = "0";
            this.textBoxagala.Text = "0";
            this.comboBoxDiametur.SelectedIndex = 1;
            this.comboBoxMernaEdinica1.SelectedIndex = 1;
            this.comboBoxRezultat.SelectedIndex = 1;
            this.comboBoxStrana2.SelectedIndex = 1;
            this.comboBoxVidove.SelectedIndex = -1;
        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {

        }

        private void обиколкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBoxVidove_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void триъгълникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        Matemati4eskiNara4nik.FormObikolkaNaTriagalnik sistema = new Matemati4eskiNara4nik.FormObikolkaNaTriagalnik();
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

        private void правиленNъгълникToolStripMenuItem_Click(object sender, EventArgs e)
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
