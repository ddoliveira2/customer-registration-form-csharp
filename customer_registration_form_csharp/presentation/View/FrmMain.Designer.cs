namespace presentation
{
    partial class FrmMain
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
            this.cadastraAlterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mClient = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastraAlterarToolStripMenuItem,
            this.mSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastraAlterarToolStripMenuItem
            // 
            this.cadastraAlterarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mClient});
            this.cadastraAlterarToolStripMenuItem.Name = "cadastraAlterarToolStripMenuItem";
            this.cadastraAlterarToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.cadastraAlterarToolStripMenuItem.Text = "Cadastra / Alterar";
            // 
            // mSair
            // 
            this.mSair.Name = "mSair";
            this.mSair.Size = new System.Drawing.Size(38, 20);
            this.mSair.Text = "Sair";
            this.mSair.Click += new System.EventHandler(this.mSair_Click);
            // 
            // mClient
            // 
            this.mClient.Name = "mClient";
            this.mClient.Size = new System.Drawing.Size(180, 22);
            this.mClient.Text = "Cliente";
            this.mClient.Click += new System.EventHandler(this.mClient_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastraAlterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mClient;
        private System.Windows.Forms.ToolStripMenuItem mSair;
    }
}

