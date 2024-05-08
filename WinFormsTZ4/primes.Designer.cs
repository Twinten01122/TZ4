namespace WinFormsTZ4
{
    partial class primes
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
            this.label4 = new System.Windows.Forms.Label();
            this.initialNumber2 = new System.Windows.Forms.TextBox();
            this.help = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.primesResult = new System.Windows.Forms.TextBox();
            this.findPrimes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(9, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(768, 46);
            this.label4.TabIndex = 38;
            this.label4.Text = "Введите верхнюю границу интервала";
            // 
            // initialNumber2
            // 
            this.initialNumber2.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.initialNumber2.Location = new System.Drawing.Point(780, 222);
            this.initialNumber2.Margin = new System.Windows.Forms.Padding(2);
            this.initialNumber2.Name = "initialNumber2";
            this.initialNumber2.Size = new System.Drawing.Size(210, 53);
            this.initialNumber2.TabIndex = 37;
            // 
            // help
            // 
            this.help.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.help.Location = new System.Drawing.Point(799, 655);
            this.help.Margin = new System.Windows.Forms.Padding(2);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(212, 67);
            this.help.TabIndex = 36;
            this.help.Text = "Справка";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(147, 486);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(788, 46);
            this.label3.TabIndex = 35;
            this.label3.Text = "Простые числа в заданном интервале:";
            // 
            // primesResult
            // 
            this.primesResult.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.primesResult.Location = new System.Drawing.Point(278, 575);
            this.primesResult.Margin = new System.Windows.Forms.Padding(2);
            this.primesResult.Name = "primesResult";
            this.primesResult.Size = new System.Drawing.Size(467, 53);
            this.primesResult.TabIndex = 33;
            // 
            // findPrimes
            // 
            this.findPrimes.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.findPrimes.Location = new System.Drawing.Point(245, 347);
            this.findPrimes.Margin = new System.Windows.Forms.Padding(2);
            this.findPrimes.Name = "findPrimes";
            this.findPrimes.Size = new System.Drawing.Size(532, 68);
            this.findPrimes.TabIndex = 31;
            this.findPrimes.Text = "Найти простые числа";
            this.findPrimes.UseVisualStyleBackColor = true;
            this.findPrimes.Click += new System.EventHandler(this.findPrimes_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(930, 60);
            this.label1.TabIndex = 30;
            this.label1.Text = "Нахождение простых чисел в интервале";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.button1.Location = new System.Drawing.Point(399, 655);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 66);
            this.button1.TabIndex = 48;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // primes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 733);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.initialNumber2);
            this.Controls.Add(this.help);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.primesResult);
            this.Controls.Add(this.findPrimes);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "primes";
            this.Text = "primes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox initialNumber2;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox primesResult;
        private System.Windows.Forms.Button findPrimes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}