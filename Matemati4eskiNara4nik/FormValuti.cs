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
    public partial class FormValuti : Form
    {
        public FormValuti()
        {
            
            InitializeComponent();
            comboBoxPurvaValutaIzbor.SelectedIndex = 0;
            comboBoxVtoraValutaIzbor.SelectedIndex = 0;
        }

        private void textBoxPurvaValuta_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void buttonIz4isti_Click(object sender, EventArgs e)
        {
            textBoxVtoraValuta.Text = "";
            textBoxPurvaValuta.Text = "";
            textBoxKurs.Text = "";
            comboBoxPurvaValutaIzbor.SelectedIndex = 0;
            comboBoxVtoraValutaIzbor.SelectedIndex = 0;

        }

        private void buttonPresmetni_Click_1(object sender, EventArgs e)
        {
           
                try
                {
                    textBoxVtoraValuta.Text = (Decimal.Parse(textBoxPurvaValuta.Text) * Decimal.Parse(textBoxKurs.Text)).ToString();
                }
                catch
                {

                }
            


            if (this.textBoxPurvaValuta.Text == "" || this.textBoxKurs.Text == "")
            {
                Matemati4eskiNara4nik.FormGreshkaValutiNishto sistema = new Matemati4eskiNara4nik.FormGreshkaValutiNishto();
                    sistema.ShowDialog();
            }

            
        }

        private void comboBoxPurvaValutaIzbor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void валутиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Matemati4eskiNara4nik.FormValuti sistema = new Matemati4eskiNara4nik.FormValuti();
            sistema.ShowDialog();

            this.Close();
        }

        private void нъгълникToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void FormValuti_Load(object sender, EventArgs e)
        {

        }
    }
}
