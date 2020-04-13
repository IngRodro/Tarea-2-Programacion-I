namespace appSistemaestudiantes.Vista
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cONTROLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLUMNOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mATERIASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cONTROLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cONTROLToolStripMenuItem
            // 
            this.cONTROLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aLUMNOSToolStripMenuItem,
            this.mATERIASToolStripMenuItem,
            this.nOTASToolStripMenuItem});
            this.cONTROLToolStripMenuItem.Name = "cONTROLToolStripMenuItem";
            this.cONTROLToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.cONTROLToolStripMenuItem.Text = "CONTROL";
            // 
            // uSUARIOSToolStripMenuItem
            // 
            this.aLUMNOSToolStripMenuItem.Name = "uSUARIOSToolStripMenuItem";
            this.aLUMNOSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aLUMNOSToolStripMenuItem.Text = "ALUMNOS";
            this.aLUMNOSToolStripMenuItem.Click += new System.EventHandler(this.aLUMNOSToolStripMenuItem_Click);
            // 
            // mATERIASToolStripMenuItem
            // 
            this.mATERIASToolStripMenuItem.Name = "mATERIASToolStripMenuItem";
            this.mATERIASToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mATERIASToolStripMenuItem.Text = "MATERIAS";
            this.mATERIASToolStripMenuItem.Click += new System.EventHandler(this.mATERIASToolStripMenuItem_Click);
            // 
            // nOTASToolStripMenuItem
            // 
            this.nOTASToolStripMenuItem.Name = "nOTASToolStripMenuItem";
            this.nOTASToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nOTASToolStripMenuItem.Text = "NOTAS";
            this.nOTASToolStripMenuItem.Click += new System.EventHandler(this.nOTASToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cONTROLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLUMNOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mATERIASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOTASToolStripMenuItem;
    }
}