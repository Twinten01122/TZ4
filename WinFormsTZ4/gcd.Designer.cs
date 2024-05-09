namespace WinFormsTZ4
{
    partial class gcd
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
            this.help = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gcdResult = new System.Windows.Forms.TextBox();
            this.initialNumber1 = new System.Windows.Forms.TextBox();
            this.findGCD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.initialNumber2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // help
            // 
            this.help.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.help.Location = new System.Drawing.Point(1065, 806);
            this.help.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(283, 82);
            this.help.TabIndex = 27;
            this.help.Text = "Справка";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(454, 598);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(454, 46);
            this.label3.TabIndex = 26;
            this.label3.Text = "НОД заданных чисел:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(151, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 46);
            this.label2.TabIndex = 25;
            this.label2.Text = "Введите первое число";
            // 
            // gcdResult
            // 
            this.gcdResult.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.gcdResult.Location = new System.Drawing.Point(371, 708);
            this.gcdResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcdResult.Name = "gcdResult";
            this.gcdResult.Size = new System.Drawing.Size(621, 53);
            this.gcdResult.TabIndex = 24;
            // 
            // initialNumber1
            // 
            this.initialNumber1.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.initialNumber1.Location = new System.Drawing.Point(772, 249);
            this.initialNumber1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.initialNumber1.Name = "initialNumber1";
            this.initialNumber1.Size = new System.Drawing.Size(471, 53);
            this.initialNumber1.TabIndex = 23;
            // 
            // findGCD
            // 
            this.findGCD.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.findGCD.Location = new System.Drawing.Point(327, 453);
            this.findGCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.findGCD.Name = "findGCD";
            this.findGCD.Size = new System.Drawing.Size(709, 84);
            this.findGCD.TabIndex = 22;
            this.findGCD.Text = "Найти НОД";
            this.findGCD.UseVisualStyleBackColor = true;
            this.findGCD.Click += new System.EventHandler(this.findGCD_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(182, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(998, 74);
            this.label1.TabIndex = 21;
            this.label1.Text = "Нахождение наибольшего общего делителя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(151, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(457, 46);
            this.label4.TabIndex = 29;
            this.label4.Text = "Введите второе число";
            // 
            // initialNumber2
            // 
            this.initialNumber2.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.initialNumber2.Location = new System.Drawing.Point(772, 350);
            this.initialNumber2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.initialNumber2.Name = "initialNumber2";
            this.initialNumber2.Size = new System.Drawing.Size(471, 53);
            this.initialNumber2.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.button1.Location = new System.Drawing.Point(532, 805);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 82);
            this.button1.TabIndex = 48;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gcd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 902);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.initialNumber2);
            this.Controls.Add(this.help);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gcdResult);
            this.Controls.Add(this.initialNumber1);
            this.Controls.Add(this.findGCD);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "gcd";
            this.Text = "Нахождение наибольшего общего делителя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gcdResult;
        private System.Windows.Forms.TextBox initialNumber1;
        private System.Windows.Forms.Button findGCD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox initialNumber2;
        private System.Windows.Forms.Button button1;
    }
}