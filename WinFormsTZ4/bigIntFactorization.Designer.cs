namespace WinFormsTZ4
{
    partial class bigIntFactorization
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
            this.findDividers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // help
            // 
            this.help.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.help.Location = new System.Drawing.Point(1111, 809);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(239, 81);
            this.help.TabIndex = 20;
            this.help.Text = "Справка";
            this.help.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(366, 598);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(631, 57);
            this.label3.TabIndex = 19;
            this.label3.Text = "Результат факторизации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(181, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 57);
            this.label2.TabIndex = 18;
            this.label2.Text = "Введите число";
            // 
            // factorizationResult
            // 
            this.factorizationResult.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.factorizationResult.Location = new System.Drawing.Point(371, 708);
            this.factorizationResult.Name = "factorizationResult";
            this.factorizationResult.ReadOnly = true;
            this.factorizationResult.Size = new System.Drawing.Size(621, 65);
            this.factorizationResult.TabIndex = 17;
            // 
            // initialNumber
            // 
            this.initialNumber.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.initialNumber.Location = new System.Drawing.Point(711, 249);
            this.initialNumber.Name = "initialNumber";
            this.initialNumber.Size = new System.Drawing.Size(470, 65);
            this.initialNumber.TabIndex = 16;
            // 
            // findDividers
            // 
            this.findDividers.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.findDividers.Location = new System.Drawing.Point(327, 453);
            this.findDividers.Name = "findDividers";
            this.findDividers.Size = new System.Drawing.Size(709, 84);
            this.findDividers.TabIndex = 15;
            this.findDividers.Text = "Произвести факторизацию";
            this.findDividers.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(235, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(892, 74);
            this.label1.TabIndex = 14;
            this.label1.Text = "Факторизация большого числа";
            // 
            // bigIntFactorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 902);
            this.Controls.Add(this.help);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.factorizationResult);
            this.Controls.Add(this.initialNumber);
            this.Controls.Add(this.findDividers);
            this.Controls.Add(this.label1);
            this.Name = "bigIntFactorization";
            this.Text = "Факторизация большого числа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox factorizationResult;
        private System.Windows.Forms.TextBox initialNumber;
        private System.Windows.Forms.Button findDividers;
        private System.Windows.Forms.Label label1;
    }
}