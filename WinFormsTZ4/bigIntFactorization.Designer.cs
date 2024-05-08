﻿namespace WinFormsTZ4
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
            this.help.Location = new System.Drawing.Point(799, 655);
            this.help.Margin = new System.Windows.Forms.Padding(2);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(212, 67);
            this.help.TabIndex = 20;
            this.help.Text = "Справка";
            this.help.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(274, 486);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(511, 46);
            this.label3.TabIndex = 19;
            this.label3.Text = "Результат факторизации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(136, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 46);
            this.label2.TabIndex = 18;
            this.label2.Text = "Введите число";
            // 
            // factorizationResult
            // 
            this.factorizationResult.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.factorizationResult.Location = new System.Drawing.Point(278, 575);
            this.factorizationResult.Margin = new System.Windows.Forms.Padding(2);
            this.factorizationResult.Name = "factorizationResult";
            this.factorizationResult.ReadOnly = true;
            this.factorizationResult.Size = new System.Drawing.Size(467, 53);
            this.factorizationResult.TabIndex = 17;
            // 
            // initialNumber
            // 
            this.initialNumber.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.initialNumber.Location = new System.Drawing.Point(533, 202);
            this.initialNumber.Margin = new System.Windows.Forms.Padding(2);
            this.initialNumber.Name = "initialNumber";
            this.initialNumber.Size = new System.Drawing.Size(354, 53);
            this.initialNumber.TabIndex = 16;
            // 
            // findDividers
            // 
            this.findDividers.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.findDividers.Location = new System.Drawing.Point(223, 368);
            this.findDividers.Margin = new System.Windows.Forms.Padding(2);
            this.findDividers.Name = "findDividers";
            this.findDividers.Size = new System.Drawing.Size(576, 68);
            this.findDividers.TabIndex = 15;
            this.findDividers.Text = "Произвести факторизацию";
            this.findDividers.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(176, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(669, 60);
            this.label1.TabIndex = 14;
            this.label1.Text = "Факторизация большого числа";
            // 
            // bigIntFactorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 733);
            this.Controls.Add(this.help);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.factorizationResult);
            this.Controls.Add(this.initialNumber);
            this.Controls.Add(this.findDividers);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
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