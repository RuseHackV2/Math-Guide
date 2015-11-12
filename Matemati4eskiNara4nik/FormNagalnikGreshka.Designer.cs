namespace Matemati4eskiNara4nik
{
    partial class FormNagalnikGreshka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNagalnikGreshka));
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelGreshka = new System.Windows.Forms.Label();
            this.pictureBoxUdivitelen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUdivitelen)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(106, 90);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelGreshka
            // 
            this.labelGreshka.AutoSize = true;
            this.labelGreshka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGreshka.Location = new System.Drawing.Point(57, 5);
            this.labelGreshka.Name = "labelGreshka";
            this.labelGreshka.Size = new System.Drawing.Size(175, 18);
            this.labelGreshka.TabIndex = 3;
            this.labelGreshka.Text = "Няма такъв н - ъгълник!";
            this.labelGreshka.Click += new System.EventHandler(this.labelGreshka_Click);
            // 
            // pictureBoxUdivitelen
            // 
            this.pictureBoxUdivitelen.BackgroundImage = global::Matemati4eskiNara4nik.Properties.Resources.ZnakGreshka;
            this.pictureBoxUdivitelen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxUdivitelen.Location = new System.Drawing.Point(52, 31);
            this.pictureBoxUdivitelen.Name = "pictureBoxUdivitelen";
            this.pictureBoxUdivitelen.Size = new System.Drawing.Size(184, 53);
            this.pictureBoxUdivitelen.TabIndex = 4;
            this.pictureBoxUdivitelen.TabStop = false;
            // 
            // FormNagalnikGreshka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 121);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.pictureBoxUdivitelen);
            this.Controls.Add(this.labelGreshka);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNagalnikGreshka";
            this.Text = "FormNagalnikGreshka";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUdivitelen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.PictureBox pictureBoxUdivitelen;
        private System.Windows.Forms.Label labelGreshka;
    }
}