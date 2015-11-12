namespace Matemati4eskiNara4nik
{
    partial class FormGreshka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGreshka));
            this.labelGreashka = new System.Windows.Forms.Label();
            this.buttonGreshka = new System.Windows.Forms.Button();
            this.pictureBoxUdivitelen = new System.Windows.Forms.PictureBox();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUdivitelen)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGreashka
            // 
            this.labelGreashka.AutoSize = true;
            this.labelGreashka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGreashka.Location = new System.Drawing.Point(14, 9);
            this.labelGreashka.Name = "labelGreashka";
            this.labelGreashka.Size = new System.Drawing.Size(269, 18);
            this.labelGreashka.TabIndex = 0;
            this.labelGreashka.Text = "Моля въведете поне два параметъра";
            // 
            // buttonGreshka
            // 
            this.buttonGreshka.Location = new System.Drawing.Point(473, 285);
            this.buttonGreshka.Name = "buttonGreshka";
            this.buttonGreshka.Size = new System.Drawing.Size(75, 23);
            this.buttonGreshka.TabIndex = 1;
            this.buttonGreshka.Text = "ОК";
            this.buttonGreshka.UseVisualStyleBackColor = true;
            this.buttonGreshka.Click += new System.EventHandler(this.buttonGreshka_Click);
            // 
            // pictureBoxUdivitelen
            // 
            this.pictureBoxUdivitelen.BackgroundImage = global::Matemati4eskiNara4nik.Properties.Resources.ZnakGreshka;
            this.pictureBoxUdivitelen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxUdivitelen.Location = new System.Drawing.Point(60, 35);
            this.pictureBoxUdivitelen.Name = "pictureBoxUdivitelen";
            this.pictureBoxUdivitelen.Size = new System.Drawing.Size(170, 47);
            this.pictureBoxUdivitelen.TabIndex = 2;
            this.pictureBoxUdivitelen.TabStop = false;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(106, 97);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormGreshka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 131);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.pictureBoxUdivitelen);
            this.Controls.Add(this.buttonGreshka);
            this.Controls.Add(this.labelGreashka);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGreshka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Грешка";
            this.Load += new System.EventHandler(this.FormGreshka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUdivitelen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGreashka;
        private System.Windows.Forms.Button buttonGreshka;
        private System.Windows.Forms.PictureBox pictureBoxUdivitelen;
        private System.Windows.Forms.Button buttonOK;
    }
}