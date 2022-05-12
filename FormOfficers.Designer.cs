namespace MainPage
{
    partial class FormOfficers
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtOE = new System.Windows.Forms.TextBox();
            this.TxtOA = new System.Windows.Forms.TextBox();
            this.TxtOLN = new System.Windows.Forms.TextBox();
            this.TxtOFN = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtOP = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "BirthDate Year/MM/DD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Officer\'s First Name";
            // 
            // TxtOE
            // 
            this.TxtOE.Location = new System.Drawing.Point(159, 219);
            this.TxtOE.Name = "TxtOE";
            this.TxtOE.Size = new System.Drawing.Size(165, 20);
            this.TxtOE.TabIndex = 20;
            // 
            // TxtOA
            // 
            this.TxtOA.Location = new System.Drawing.Point(161, 162);
            this.TxtOA.Name = "TxtOA";
            this.TxtOA.Size = new System.Drawing.Size(163, 20);
            this.TxtOA.TabIndex = 19;
            // 
            // TxtOLN
            // 
            this.TxtOLN.Location = new System.Drawing.Point(161, 64);
            this.TxtOLN.Name = "TxtOLN";
            this.TxtOLN.Size = new System.Drawing.Size(163, 20);
            this.TxtOLN.TabIndex = 18;
            // 
            // TxtOFN
            // 
            this.TxtOFN.Location = new System.Drawing.Point(159, 14);
            this.TxtOFN.Name = "TxtOFN";
            this.TxtOFN.Size = new System.Drawing.Size(165, 20);
            this.TxtOFN.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 43);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add The Officer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Officer\'s Last Name";
            // 
            // TxtOP
            // 
            this.TxtOP.Location = new System.Drawing.Point(159, 279);
            this.TxtOP.Name = "TxtOP";
            this.TxtOP.Size = new System.Drawing.Size(165, 20);
            this.TxtOP.TabIndex = 26;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 119);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 20);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // FormOfficers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 448);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtOP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtOE);
            this.Controls.Add(this.TxtOA);
            this.Controls.Add(this.TxtOLN);
            this.Controls.Add(this.TxtOFN);
            this.Controls.Add(this.button1);
            this.Name = "FormOfficers";
            this.Text = "FormOfficers";
            this.Load += new System.EventHandler(this.FormOfficers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtOE;
        private System.Windows.Forms.TextBox TxtOA;
        private System.Windows.Forms.TextBox TxtOLN;
        private System.Windows.Forms.TextBox TxtOFN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtOP;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}