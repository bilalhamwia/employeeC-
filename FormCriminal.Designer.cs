namespace MainPage
{
    partial class FormCriminal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCFN = new System.Windows.Forms.TextBox();
            this.TxtCLN = new System.Windows.Forms.TextBox();
            this.TXtCNN = new System.Windows.Forms.TextBox();
            this.TxtCA = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criminal\'s First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Criminal\'s Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birthdate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "National Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // TxtCFN
            // 
            this.TxtCFN.Location = new System.Drawing.Point(245, 30);
            this.TxtCFN.Name = "TxtCFN";
            this.TxtCFN.Size = new System.Drawing.Size(152, 20);
            this.TxtCFN.TabIndex = 5;
            // 
            // TxtCLN
            // 
            this.TxtCLN.Location = new System.Drawing.Point(245, 81);
            this.TxtCLN.Name = "TxtCLN";
            this.TxtCLN.Size = new System.Drawing.Size(152, 20);
            this.TxtCLN.TabIndex = 6;
            // 
            // TXtCNN
            // 
            this.TXtCNN.Location = new System.Drawing.Point(245, 203);
            this.TXtCNN.Name = "TXtCNN";
            this.TXtCNN.Size = new System.Drawing.Size(152, 20);
            this.TXtCNN.TabIndex = 8;
            // 
            // TxtCA
            // 
            this.TxtCA.Location = new System.Drawing.Point(245, 267);
            this.TxtCA.Name = "TxtCA";
            this.TxtCA.Size = new System.Drawing.Size(152, 20);
            this.TxtCA.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add The Criminal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(245, 140);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(152, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // FormCriminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 460);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtCA);
            this.Controls.Add(this.TXtCNN);
            this.Controls.Add(this.TxtCLN);
            this.Controls.Add(this.TxtCFN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCriminal";
            this.Text = "FormCriminal";
            this.Load += new System.EventHandler(this.FormCriminal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCFN;
        private System.Windows.Forms.TextBox TxtCLN;
        private System.Windows.Forms.TextBox TXtCNN;
        private System.Windows.Forms.TextBox TxtCA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}