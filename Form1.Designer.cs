namespace MainPage
{
    partial class Form1
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
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emplyeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.officersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criminalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patrolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfCasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.createToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(435, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emplyeeToolStripMenuItem,
            this.officersToolStripMenuItem,
            this.criminalToolStripMenuItem,
            this.caseToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // emplyeeToolStripMenuItem
            // 
            this.emplyeeToolStripMenuItem.Name = "emplyeeToolStripMenuItem";
            this.emplyeeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.emplyeeToolStripMenuItem.Text = "Emplyee";
            this.emplyeeToolStripMenuItem.Click += new System.EventHandler(this.emplyeeToolStripMenuItem_Click);
            // 
            // officersToolStripMenuItem
            // 
            this.officersToolStripMenuItem.Name = "officersToolStripMenuItem";
            this.officersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.officersToolStripMenuItem.Text = "Officers";
            this.officersToolStripMenuItem.Click += new System.EventHandler(this.officersToolStripMenuItem_Click);
            // 
            // criminalToolStripMenuItem
            // 
            this.criminalToolStripMenuItem.Name = "criminalToolStripMenuItem";
            this.criminalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.criminalToolStripMenuItem.Text = "Criminal";
            this.criminalToolStripMenuItem.Click += new System.EventHandler(this.criminalToolStripMenuItem_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentToolStripMenuItem,
            this.patrolToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.departmentToolStripMenuItem.Text = "Department";
            this.departmentToolStripMenuItem.Click += new System.EventHandler(this.departmentToolStripMenuItem_Click);
            // 
            // patrolToolStripMenuItem
            // 
            this.patrolToolStripMenuItem.Name = "patrolToolStripMenuItem";
            this.patrolToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.patrolToolStripMenuItem.Text = "Patrol";
            this.patrolToolStripMenuItem.Click += new System.EventHandler(this.patrolToolStripMenuItem_Click);
            // 
            // caseToolStripMenuItem
            // 
            this.caseToolStripMenuItem.Name = "caseToolStripMenuItem";
            this.caseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.caseToolStripMenuItem.Text = "Case";
            this.caseToolStripMenuItem.Click += new System.EventHandler(this.caseToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfCasesToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // listOfCasesToolStripMenuItem
            // 
            this.listOfCasesToolStripMenuItem.Name = "listOfCasesToolStripMenuItem";
            this.listOfCasesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listOfCasesToolStripMenuItem.Text = "List of Cases";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 395);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emplyeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem officersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criminalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patrolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfCasesToolStripMenuItem;
    }
}

