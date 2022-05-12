namespace MainPage
{
    partial class AddPositionForm
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
            this.TxtPMaxSal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtPMinSal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtPLG = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtPN = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 256);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 74;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TxtPMaxSal
            // 
            this.TxtPMaxSal.Location = new System.Drawing.Point(168, 193);
            this.TxtPMaxSal.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPMaxSal.Name = "TxtPMaxSal";
            this.TxtPMaxSal.Size = new System.Drawing.Size(132, 22);
            this.TxtPMaxSal.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 140);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 72;
            this.label7.Text = "Min Salary";
            // 
            // TxtPMinSal
            // 
            this.TxtPMinSal.Location = new System.Drawing.Point(168, 140);
            this.TxtPMinSal.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPMinSal.Name = "TxtPMinSal";
            this.TxtPMinSal.Size = new System.Drawing.Size(132, 22);
            this.TxtPMinSal.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 193);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 70;
            this.label8.Text = "Max Salary";
            // 
            // TxtPLG
            // 
            this.TxtPLG.Location = new System.Drawing.Point(168, 84);
            this.TxtPLG.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPLG.Name = "TxtPLG";
            this.TxtPLG.Size = new System.Drawing.Size(132, 22);
            this.TxtPLG.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 84);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 68;
            this.label9.Text = "Letter Grade";
            // 
            // TxtPN
            // 
            this.TxtPN.Location = new System.Drawing.Point(168, 33);
            this.TxtPN.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPN.Name = "TxtPN";
            this.TxtPN.Size = new System.Drawing.Size(132, 22);
            this.TxtPN.TabIndex = 67;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 33);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 66;
            this.label10.Text = "Position";
            // 
            // FormAddPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 351);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TxtPMaxSal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtPMinSal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtPLG);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtPN);
            this.Controls.Add(this.label10);
            this.Name = "FormAddPosition";
            this.Text = "w";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxtPMaxSal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtPMinSal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtPLG;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtPN;
        private System.Windows.Forms.Label label10;
    }
}