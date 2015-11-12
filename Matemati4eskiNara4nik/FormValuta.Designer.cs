namespace Matemati4eskiNara4nik
{
    partial class FormValuta
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
            this.menuStripMenu = new System.Windows.Forms.MenuStrip();
            this.obikolkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxLeva = new System.Windows.Forms.TextBox();
            this.textBoxKurs = new System.Windows.Forms.TextBox();
            this.textBoxValuta = new System.Windows.Forms.TextBox();
            this.menuStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMenu
            // 
            this.menuStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obikolkaToolStripMenuItem});
            this.menuStripMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripMenu.Name = "menuStripMenu";
            this.menuStripMenu.Size = new System.Drawing.Size(1005, 24);
            this.menuStripMenu.TabIndex = 0;
            this.menuStripMenu.Text = "menuStrip1";
            // 
            // obikolkaToolStripMenuItem
            // 
            this.obikolkaToolStripMenuItem.Name = "obikolkaToolStripMenuItem";
            this.obikolkaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.obikolkaToolStripMenuItem.Text = "Obikolka";
            // 
            // textBoxLeva
            // 
            this.textBoxLeva.Location = new System.Drawing.Point(34, 99);
            this.textBoxLeva.Name = "textBoxLeva";
            this.textBoxLeva.Size = new System.Drawing.Size(100, 20);
            this.textBoxLeva.TabIndex = 1;
            // 
            // textBoxKurs
            // 
            this.textBoxKurs.Location = new System.Drawing.Point(357, 60);
            this.textBoxKurs.Name = "textBoxKurs";
            this.textBoxKurs.Size = new System.Drawing.Size(100, 20);
            this.textBoxKurs.TabIndex = 2;
            // 
            // textBoxValuta
            // 
            this.textBoxValuta.Location = new System.Drawing.Point(553, 71);
            this.textBoxValuta.Name = "textBoxValuta";
            this.textBoxValuta.Size = new System.Drawing.Size(100, 20);
            this.textBoxValuta.TabIndex = 3;
            // 
            // FormValuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 612);
            this.Controls.Add(this.textBoxValuta);
            this.Controls.Add(this.textBoxKurs);
            this.Controls.Add(this.textBoxLeva);
            this.Controls.Add(this.menuStripMenu);
            this.MainMenuStrip = this.menuStripMenu;
            this.Name = "FormValuta";
            this.Text = "FormValuta";
            this.menuStripMenu.ResumeLayout(false);
            this.menuStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMenu;
        private System.Windows.Forms.ToolStripMenuItem obikolkaToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxLeva;
        private System.Windows.Forms.TextBox textBoxKurs;
        private System.Windows.Forms.TextBox textBoxValuta;
    }
}