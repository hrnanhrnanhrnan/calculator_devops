namespace App
{
    partial class GUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonSubtraction = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonRes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultBox
            // 
            this.resultBox.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultBox.Location = new System.Drawing.Point(8, 7);
            this.resultBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(290, 50);
            this.resultBox.TabIndex = 0;
            this.resultBox.Text = "0";
            this.resultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 297);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.numButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(82, 297);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = ",";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.numButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 238);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 55);
            this.button3.TabIndex = 3;
            this.button3.Text = "1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.numButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(82, 238);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 55);
            this.button4.TabIndex = 4;
            this.button4.Text = "2";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.numButton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(155, 238);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 55);
            this.button5.TabIndex = 5;
            this.button5.Text = "3";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.numButton_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(8, 179);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(69, 55);
            this.button6.TabIndex = 6;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.numButton_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(82, 179);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(69, 55);
            this.button7.TabIndex = 7;
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.numButton_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(155, 179);
            this.button8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(69, 55);
            this.button8.TabIndex = 8;
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.numButton_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(8, 120);
            this.button9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(69, 55);
            this.button9.TabIndex = 9;
            this.button9.Text = "7";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.numButton_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(82, 120);
            this.button10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(69, 55);
            this.button10.TabIndex = 10;
            this.button10.Text = "8";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.numButton_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(155, 120);
            this.button11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(69, 55);
            this.button11.TabIndex = 11;
            this.button11.Text = "9";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.numButton_Click);
            // 
            // buttonSum
            // 
            this.buttonSum.Location = new System.Drawing.Point(155, 297);
            this.buttonSum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(143, 55);
            this.buttonSum.TabIndex = 12;
            this.buttonSum.Text = "=";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.sum_click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(229, 238);
            this.buttonDivide.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(69, 55);
            this.buttonDivide.TabIndex = 13;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.operator_click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(229, 179);
            this.buttonMultiply.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(69, 55);
            this.buttonMultiply.TabIndex = 14;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.operator_click);
            // 
            // buttonSubtraction
            // 
            this.buttonSubtraction.Location = new System.Drawing.Point(229, 120);
            this.buttonSubtraction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSubtraction.Name = "buttonSubtraction";
            this.buttonSubtraction.Size = new System.Drawing.Size(69, 55);
            this.buttonSubtraction.TabIndex = 15;
            this.buttonSubtraction.Text = "-";
            this.buttonSubtraction.UseVisualStyleBackColor = true;
            this.buttonSubtraction.Click += new System.EventHandler(this.operator_click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(229, 61);
            this.buttonPlus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(69, 55);
            this.buttonPlus.TabIndex = 16;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.operator_click);
            // 
            // buttonRes
            // 
            this.buttonRes.Location = new System.Drawing.Point(8, 61);
            this.buttonRes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRes.Name = "buttonRes";
            this.buttonRes.Size = new System.Drawing.Size(216, 55);
            this.buttonRes.TabIndex = 17;
            this.buttonRes.Text = "C";
            this.buttonRes.UseVisualStyleBackColor = true;
            this.buttonRes.Click += new System.EventHandler(this.reset_click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 358);
            this.Controls.Add(this.buttonRes);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonSubtraction);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GUI";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonSubtraction;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonRes;
    }
}
