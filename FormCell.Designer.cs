namespace MainPage
{
    partial class FormCell
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtCCrimeLev = new System.Windows.Forms.TextBox();
            this.TxtCCapacity = new System.Windows.Forms.TextBox();
            this.TxtCCode = new System.Windows.Forms.TextBox();
            this.TxtCIN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TxtCCrimeLev);
            this.groupBox1.Controls.Add(this.TxtCCapacity);
            this.groupBox1.Controls.Add(this.TxtCCode);
            this.groupBox1.Controls.Add(this.TxtCIN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(466, 427);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Cell";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 354);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add Cell";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtCCrimeLev
            // 
            this.TxtCCrimeLev.Location = new System.Drawing.Point(270, 237);
            this.TxtCCrimeLev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCCrimeLev.Name = "TxtCCrimeLev";
            this.TxtCCrimeLev.Size = new System.Drawing.Size(160, 27);
            this.TxtCCrimeLev.TabIndex = 7;
            // 
            // TxtCCapacity
            // 
            this.TxtCCapacity.Location = new System.Drawing.Point(270, 172);
            this.TxtCCapacity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCCapacity.Name = "TxtCCapacity";
            this.TxtCCapacity.Size = new System.Drawing.Size(160, 27);
            this.TxtCCapacity.TabIndex = 6;
            // 
            // TxtCCode
            // 
            this.TxtCCode.Location = new System.Drawing.Point(270, 113);
            this.TxtCCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCCode.Name = "TxtCCode";
            this.TxtCCode.Size = new System.Drawing.Size(160, 27);
            this.TxtCCode.TabIndex = 5;
            // 
            // TxtCIN
            // 
            this.TxtCIN.Location = new System.Drawing.Point(270, 56);
            this.TxtCIN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCIN.Name = "TxtCIN";
            this.TxtCIN.Size = new System.Drawing.Size(160, 27);
            this.TxtCIN.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 237);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Crime Level (Between 1 and 10)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Capacity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificartion Number";
            // 
            // FormCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 469);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCell";
            this.Text = "FormCell";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtCCrimeLev;
        private System.Windows.Forms.TextBox TxtCCapacity;
        private System.Windows.Forms.TextBox TxtCCode;
        private System.Windows.Forms.TextBox TxtCIN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}