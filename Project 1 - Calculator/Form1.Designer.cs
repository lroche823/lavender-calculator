namespace chap1test2
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
            this.digit1 = new System.Windows.Forms.Button();
            this.digit0 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.asterisk = new System.Windows.Forms.Button();
            this.slash = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.decimalPoint = new System.Windows.Forms.Button();
            this.openP = new System.Windows.Forms.Button();
            this.closeP = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.digit2 = new System.Windows.Forms.Button();
            this.digit3 = new System.Windows.Forms.Button();
            this.digit6 = new System.Windows.Forms.Button();
            this.digit5 = new System.Windows.Forms.Button();
            this.digit4 = new System.Windows.Forms.Button();
            this.digit9 = new System.Windows.Forms.Button();
            this.digit8 = new System.Windows.Forms.Button();
            this.digit7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // digit1
            // 
            this.digit1.BackColor = System.Drawing.Color.Lavender;
            this.digit1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.digit1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.digit1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.digit1.Location = new System.Drawing.Point(34, 210);
            this.digit1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.digit1.Name = "digit1";
            this.digit1.Size = new System.Drawing.Size(46, 46);
            this.digit1.TabIndex = 0;
            this.digit1.Text = "1";
            this.digit1.UseVisualStyleBackColor = false;
            this.digit1.Click += new System.EventHandler(this.number_Click);
            // 
            // digit0
            // 
            this.digit0.BackColor = System.Drawing.Color.Lavender;
            this.digit0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.digit0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.digit0.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.digit0.Location = new System.Drawing.Point(34, 262);
            this.digit0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.digit0.Name = "digit0";
            this.digit0.Size = new System.Drawing.Size(46, 46);
            this.digit0.TabIndex = 1;
            this.digit0.Text = "0";
            this.digit0.UseVisualStyleBackColor = false;
            this.digit0.Click += new System.EventHandler(this.number_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(328, 78);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Enter an expression";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.Click += new System.EventHandler(this.clear_click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.Lavender;
            this.plus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plus.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.plus.Location = new System.Drawing.Point(196, 106);
            this.plus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(46, 46);
            this.plus.TabIndex = 3;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.Lavender;
            this.minus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minus.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minus.Location = new System.Drawing.Point(250, 158);
            this.minus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(46, 46);
            this.minus.TabIndex = 4;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // asterisk
            // 
            this.asterisk.BackColor = System.Drawing.Color.Lavender;
            this.asterisk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.asterisk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.asterisk.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.asterisk.Location = new System.Drawing.Point(196, 158);
            this.asterisk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.asterisk.Name = "asterisk";
            this.asterisk.Size = new System.Drawing.Size(46, 46);
            this.asterisk.TabIndex = 5;
            this.asterisk.Text = "×";
            this.asterisk.UseVisualStyleBackColor = false;
            this.asterisk.Click += new System.EventHandler(this.asterisk_Click);
            // 
            // slash
            // 
            this.slash.BackColor = System.Drawing.Color.Lavender;
            this.slash.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.slash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.slash.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.slash.Location = new System.Drawing.Point(142, 262);
            this.slash.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.slash.Name = "slash";
            this.slash.Size = new System.Drawing.Size(46, 46);
            this.slash.TabIndex = 6;
            this.slash.Text = "÷";
            this.slash.UseVisualStyleBackColor = false;
            this.slash.Click += new System.EventHandler(this.slash_Click);
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.GhostWhite;
            this.calculate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.calculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculate.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calculate.Location = new System.Drawing.Point(196, 262);
            this.calculate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(100, 46);
            this.calculate.TabIndex = 7;
            this.calculate.Text = "=";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // decimalPoint
            // 
            this.decimalPoint.BackColor = System.Drawing.Color.Lavender;
            this.decimalPoint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.decimalPoint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.decimalPoint.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.decimalPoint.Location = new System.Drawing.Point(88, 262);
            this.decimalPoint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.decimalPoint.Name = "decimalPoint";
            this.decimalPoint.Size = new System.Drawing.Size(46, 46);
            this.decimalPoint.TabIndex = 11;
            this.decimalPoint.Text = ".";
            this.decimalPoint.UseVisualStyleBackColor = false;
            this.decimalPoint.Click += new System.EventHandler(this.decimalPoint_Click);
            // 
            // openP
            // 
            this.openP.BackColor = System.Drawing.Color.Lavender;
            this.openP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.openP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openP.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.openP.Location = new System.Drawing.Point(196, 210);
            this.openP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.openP.Name = "openP";
            this.openP.Size = new System.Drawing.Size(46, 46);
            this.openP.TabIndex = 12;
            this.openP.Text = "(";
            this.openP.UseVisualStyleBackColor = false;
            this.openP.Click += new System.EventHandler(this.openP_Click);
            // 
            // closeP
            // 
            this.closeP.BackColor = System.Drawing.Color.Lavender;
            this.closeP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.closeP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeP.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeP.Location = new System.Drawing.Point(250, 210);
            this.closeP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.closeP.Name = "closeP";
            this.closeP.Size = new System.Drawing.Size(46, 46);
            this.closeP.TabIndex = 13;
            this.closeP.Text = ")";
            this.closeP.UseVisualStyleBackColor = false;
            this.closeP.Click += new System.EventHandler(this.closeP_Click);
            // 
            // CE
            // 
            this.CE.BackColor = System.Drawing.Color.Lavender;
            this.CE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.CE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CE.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CE.Location = new System.Drawing.Point(250, 106);
            this.CE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(46, 46);
            this.CE.TabIndex = 14;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = false;
            this.CE.Click += new System.EventHandler(this.clear_click);
            // 
            // digit2
            // 
            this.digit2.BackColor = System.Drawing.Color.Lavender;
            this.digit2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.digit2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.digit2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.digit2.Location = new System.Drawing.Point(88, 210);
            this.digit2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.digit2.Name = "digit2";
            this.digit2.Size = new System.Drawing.Size(46, 46);
            this.digit2.TabIndex = 15;
            this.digit2.Text = "2";
            this.digit2.UseVisualStyleBackColor = false;
            this.digit2.Click += new System.EventHandler(this.number_Click);
            // 
            // digit3
            // 
            this.digit3.BackColor = System.Drawing.Color.Lavender;
            this.digit3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.digit3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.digit3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.digit3.Location = new System.Drawing.Point(142, 210);
            this.digit3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.digit3.Name = "digit3";
            this.digit3.Size = new System.Drawing.Size(46, 46);
            this.digit3.TabIndex = 16;
            this.digit3.Text = "3";
            this.digit3.UseVisualStyleBackColor = false;
            this.digit3.Click += new System.EventHandler(this.number_Click);
            // 
            // digit6
            // 
            this.digit6.BackColor = System.Drawing.Color.Lavender;
            this.digit6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.digit6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.digit6.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.digit6.Location = new System.Drawing.Point(142, 158);
            this.digit6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.digit6.Name = "digit6";
            this.digit6.Size = new System.Drawing.Size(46, 46);
            this.digit6.TabIndex = 19;
            this.digit6.Text = "6";
            this.digit6.UseVisualStyleBackColor = false;
            this.digit6.Click += new System.EventHandler(this.number_Click);
            // 
            // digit5
            // 
            this.digit5.BackColor = System.Drawing.Color.Lavender;
            this.digit5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.digit5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.digit5.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.digit5.Location = new System.Drawing.Point(88, 158);
            this.digit5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.digit5.Name = "digit5";
            this.digit5.Size = new System.Drawing.Size(46, 46);
            this.digit5.TabIndex = 18;
            this.digit5.Text = "5";
            this.digit5.UseVisualStyleBackColor = false;
            this.digit5.Click += new System.EventHandler(this.number_Click);
            // 
            // digit4
            // 
            this.digit4.BackColor = System.Drawing.Color.Lavender;
            this.digit4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.digit4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.digit4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.digit4.Location = new System.Drawing.Point(34, 158);
            this.digit4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.digit4.Name = "digit4";
            this.digit4.Size = new System.Drawing.Size(46, 46);
            this.digit4.TabIndex = 17;
            this.digit4.Text = "4";
            this.digit4.UseVisualStyleBackColor = false;
            this.digit4.Click += new System.EventHandler(this.number_Click);
            // 
            // digit9
            // 
            this.digit9.BackColor = System.Drawing.Color.Lavender;
            this.digit9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.digit9.FlatAppearance.BorderSize = 2;
            this.digit9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.digit9.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.digit9.Location = new System.Drawing.Point(142, 106);
            this.digit9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.digit9.Name = "digit9";
            this.digit9.Size = new System.Drawing.Size(46, 46);
            this.digit9.TabIndex = 22;
            this.digit9.Text = "9";
            this.digit9.UseVisualStyleBackColor = false;
            this.digit9.Click += new System.EventHandler(this.number_Click);
            // 
            // digit8
            // 
            this.digit8.BackColor = System.Drawing.Color.Lavender;
            this.digit8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.digit8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.digit8.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.digit8.Location = new System.Drawing.Point(88, 106);
            this.digit8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.digit8.Name = "digit8";
            this.digit8.Size = new System.Drawing.Size(46, 46);
            this.digit8.TabIndex = 21;
            this.digit8.Text = "8";
            this.digit8.UseVisualStyleBackColor = false;
            this.digit8.Click += new System.EventHandler(this.number_Click);
            // 
            // digit7
            // 
            this.digit7.BackColor = System.Drawing.Color.Lavender;
            this.digit7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.digit7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.digit7.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.digit7.Location = new System.Drawing.Point(34, 106);
            this.digit7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.digit7.Name = "digit7";
            this.digit7.Size = new System.Drawing.Size(46, 46);
            this.digit7.TabIndex = 20;
            this.digit7.Text = "7";
            this.digit7.UseVisualStyleBackColor = false;
            this.digit7.Click += new System.EventHandler(this.number_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(185)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(328, 334);
            this.Controls.Add(this.digit9);
            this.Controls.Add(this.digit8);
            this.Controls.Add(this.digit7);
            this.Controls.Add(this.digit6);
            this.Controls.Add(this.digit5);
            this.Controls.Add(this.digit4);
            this.Controls.Add(this.digit3);
            this.Controls.Add(this.digit2);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.closeP);
            this.Controls.Add(this.openP);
            this.Controls.Add(this.decimalPoint);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.slash);
            this.Controls.Add(this.asterisk);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.digit0);
            this.Controls.Add(this.digit1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Best Calculator Ever";
            this.DoubleClick += new System.EventHandler(this.form1_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button digit1;
        private System.Windows.Forms.Button digit0;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button asterisk;
        private System.Windows.Forms.Button slash;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button decimalPoint;
        private System.Windows.Forms.Button openP;
        private System.Windows.Forms.Button closeP;
        private Button CE;
        private Button digit2;
        private Button digit3;
        private Button digit6;
        private Button digit5;
        private Button digit4;
        private Button digit9;
        private Button digit8;
        private Button digit7;
    }
}

