namespace WinFormsTZ4
{
    partial class factorization
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
            this.factorizationResult = new System.Windows.Forms.TextBox();
            this.initialNumber = new System.Windows.Forms.TextBox();
            this.factorize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // help
            // 
            this.help.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.help.Location = new System.Drawing.Point(799, 655);
            this.help.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(212, 67);
            this.help.TabIndex = 27;
            this.help.Text = "Справка";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(274, 486);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(528, 46);
            this.label3.TabIndex = 26;
            this.label3.Text = "Результат факторизации:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(136, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 46);
            this.label2.TabIndex = 25;
            this.label2.Text = "Введите число";
            // 
            // factorizationResult
            // 
            this.factorizationResult.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.factorizationResult.Location = new System.Drawing.Point(278, 575);
            this.factorizationResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.factorizationResult.Name = "factorizationResult";
            this.factorizationResult.Size = new System.Drawing.Size(467, 53);
            this.factorizationResult.TabIndex = 24;
            // 
            // initialNumber
            // 
            this.initialNumber.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.initialNumber.Location = new System.Drawing.Point(533, 202);
            this.initialNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.initialNumber.Name = "initialNumber";
            this.initialNumber.Size = new System.Drawing.Size(354, 53);
            this.initialNumber.TabIndex = 23;
            // 
            // factorize
            // 
            this.factorize.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.factorize.Location = new System.Drawing.Point(225, 368);
            this.factorize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.factorize.Name = "factorize";
            this.factorize.Size = new System.Drawing.Size(573, 68);
            this.factorize.TabIndex = 22;
            this.factorize.Text = "Произвести факторизацию";
            this.factorize.UseVisualStyleBackColor = true;
            this.factorize.Click += new System.EventHandler(this.factorize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(290, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 46);
            this.label1.TabIndex = 21;
            this.label1.Text = "Факторизация числа";
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // factorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 733);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.help);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.factorizationResult);
            this.Controls.Add(this.initialNumber);
            this.Controls.Add(this.factorize);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "factorization";
            this.Text = "Факторизация числа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox factorizationResult;
        private System.Windows.Forms.TextBox initialNumber;
        private System.Windows.Forms.Button factorize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}