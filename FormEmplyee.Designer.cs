namespace MainPage
{
    partial class FormEmplyee
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
            this.button2 = new System.Windows.Forms.Button();
            this.TxtEPW = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtEUN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtEPN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtELN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtEFN = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 54;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtEPW
            // 
            this.TxtEPW.Location = new System.Drawing.Point(162, 196);
            this.TxtEPW.Name = "TxtEPW";
            this.TxtEPW.Size = new System.Drawing.Size(100, 20);
            this.TxtEPW.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Password";
            // 
            // TxtEUN
            // 
            this.TxtEUN.Location = new System.Drawing.Point(162, 155);
            this.TxtEUN.Name = "TxtEUN";
            this.TxtEUN.Size = new System.Drawing.Size(100, 20);
            this.TxtEUN.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Phone Number";
            // 
            // TxtEPN
            // 
            this.TxtEPN.Location = new System.Drawing.Point(162, 112);
            this.TxtEPN.Name = "TxtEPN";
            this.TxtEPN.Size = new System.Drawing.Size(100, 20);
            this.TxtEPN.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "UserName";
            // 
            // TxtELN
            // 
            this.TxtELN.Location = new System.Drawing.Point(162, 67);
            this.TxtELN.Name = "TxtELN";
            this.TxtELN.Size = new System.Drawing.Size(100, 20);
            this.TxtELN.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Last Name";
            // 
            // TxtEFN
            // 
            this.TxtEFN.Location = new System.Drawing.Point(162, 25);
            this.TxtEFN.Name = "TxtEFN";
            this.TxtEFN.Size = new System.Drawing.Size(100, 20);
            this.TxtEFN.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(72, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "First Name";
            // 
            // FormEmplyee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 366);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TxtEPW);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtEUN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtEPN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtELN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtEFN);
            this.Controls.Add(this.label10);
            this.Name = "FormEmplyee";
            this.Text = "FormEmplyee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxtEPW;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtEUN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtEPN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtELN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtEFN;
        private System.Windows.Forms.Label label10;
    }
}