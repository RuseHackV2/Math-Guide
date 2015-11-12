namespace Matemati4eskiNara4nik
{
    partial class FormGreshkaValutiNishto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGreshkaValutiNishto));
            this.labelGreshka = new System.Windows.Forms.Label();
            this.pictureBoxUdivitelen = new System.Windows.Forms.PictureBox();
            this.buttonOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUdivitelen)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGreshka
            // 
            this.labelGreshka.AutoSize = true;
            this.labelGreshka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGreshka.Location = new System.Drawing.Point(-2, 7);
            this.labelGreshka.Name = "labelGreshka";
            this.labelGreshka.Size = new System.Drawing.Size(302, 18);
            this.labelGreshka.TabIndex = 0;
            this.labelGreshka.Text = "Моля въведете стойност на валута и курс";
            // 
            // pictureBoxUdivitelen
            // 
            this.pictureBoxUdivitelen.BackgroundImage = global::Matemati4eskiNara4nik.Properties.Resources.ZnakGreshka;
            this.pictureBoxUdivitelen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxUdivitelen.Location = new System.Drawing.Point(51, 28);
            this.pictureBoxUdivitelen.Name = "pictureBoxUdivitelen";
            this.pictureBoxUdivitelen.Size = new System.Drawing.Size(184, 53);
            this.pictureBoxUdivitelen.TabIndex = 1;
            this.pictureBoxUdivitelen.TabStop = false;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(104, 96);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormGreshkaValutiNishto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 131);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.pictureBoxUdivitelen);
            this.Controls.Add(this.labelGreshka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGreshkaValutiNishto";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Грешка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUdivitelen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGreshka;
        private System.Windows.Forms.PictureBox pictureBoxUdivitelen;
        private System.Windows.Forms.Button buttonOk;
    }
}