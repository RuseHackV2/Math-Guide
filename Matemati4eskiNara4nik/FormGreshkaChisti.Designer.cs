namespace Matemati4eskiNara4nik
{
    partial class FormGreshkaChisti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGreshkaChisti));
            this.labelizchisti = new System.Windows.Forms.Label();
            this.buttonОК = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelizchisti
            // 
            this.labelizchisti.AutoSize = true;
            this.labelizchisti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelizchisti.Location = new System.Drawing.Point(27, 25);
            this.labelizchisti.Name = "labelizchisti";
            this.labelizchisti.Size = new System.Drawing.Size(252, 54);
            this.labelizchisti.TabIndex = 0;
            this.labelizchisti.Text = "      Не сте изчистили полетата,\r\nза да го направите моля кликнете \r\n         вър" +
                "ху бутона \"Изчисти\"";
            // 
            // buttonОК
            // 
            this.buttonОК.Location = new System.Drawing.Point(103, 96);
            this.buttonОК.Name = "buttonОК";
            this.buttonОК.Size = new System.Drawing.Size(75, 23);
            this.buttonОК.TabIndex = 1;
            this.buttonОК.Text = "ОК";
            this.buttonОК.UseVisualStyleBackColor = true;
            this.buttonОК.Click += new System.EventHandler(this.buttonОК_Click);
            // 
            // FormGreshkaChisti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 131);
            this.Controls.Add(this.buttonОК);
            this.Controls.Add(this.labelizchisti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGreshkaChisti";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Грешка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelizchisti;
        private System.Windows.Forms.Button buttonОК;
    }
}