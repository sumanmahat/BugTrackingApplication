namespace BugTracking_Aplication_suman_mahat.Views
{
    partial class TesterPanel
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBugsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBugsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.bugsToolStripMenuItem,
            this.versionControlToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(723, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // bugsToolStripMenuItem
            // 
            this.bugsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBugsToolStripMenuItem,
            this.viewBugsToolStripMenuItem});
            this.bugsToolStripMenuItem.Name = "bugsToolStripMenuItem";
            this.bugsToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.bugsToolStripMenuItem.Text = "Bugs";
            // 
            // addBugsToolStripMenuItem
            // 
            this.addBugsToolStripMenuItem.Name = "addBugsToolStripMenuItem";
            this.addBugsToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.addBugsToolStripMenuItem.Text = "AddBugs";
            this.addBugsToolStripMenuItem.Click += new System.EventHandler(this.addBugsToolStripMenuItem_Click);
            // 
            // viewBugsToolStripMenuItem
            // 
            this.viewBugsToolStripMenuItem.Name = "viewBugsToolStripMenuItem";
            this.viewBugsToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.viewBugsToolStripMenuItem.Text = "ViewBugs";
            this.viewBugsToolStripMenuItem.Click += new System.EventHandler(this.viewBugsToolStripMenuItem_Click);
            // 
            // versionControlToolStripMenuItem
            // 
            this.versionControlToolStripMenuItem.Name = "versionControlToolStripMenuItem";
            this.versionControlToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.versionControlToolStripMenuItem.Text = "Version Control";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.logOutToolStripMenuItem.Text = "LogOut";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TesterPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 477);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TesterPanel";
            this.Text = "TesterPanel";
            this.Load += new System.EventHandler(this.TesterPanel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bugsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBugsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewBugsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
    }
}