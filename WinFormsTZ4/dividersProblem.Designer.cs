﻿namespace WinFormsTZ4
{
    partial class dividersProblem
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
            this.label2 = new System.Windows.Forms.Label();
            this.gcdResult = new System.Windows.Forms.TextBox();
            this.initialNumber1 = new System.Windows.Forms.TextBox();
            this.findGCD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(151, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(563, 57);
            this.label4.TabIndex = 38;
            this.label4.Text = "Введите второе число";
            // 
            // initialNumber2
            // 
            this.initialNumber2.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.initialNumber2.Location = new System.Drawing.Point(741, 290);
            this.initialNumber2.Name = "initialNumber2";
            this.initialNumber2.Size = new System.Drawing.Size(470, 65);
            this.initialNumber2.TabIndex = 37;
            // 
            // help
            // 
            this.help.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.help.Location = new System.Drawing.Point(1111, 809);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(239, 81);
            this.help.TabIndex = 36;
            this.help.Text = "Справка";
            this.help.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(401, 598);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(561, 57);
            this.label3.TabIndex = 35;
            this.label3.Text = "НОД заданных чисел:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(151, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(569, 57);
            this.label2.TabIndex = 34;
            this.label2.Text = "Введите первое число";
            // 
            // gcdResult
            // 
            this.gcdResult.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.gcdResult.Location = new System.Drawing.Point(371, 708);
            this.gcdResult.Name = "gcdResult";
            this.gcdResult.Size = new System.Drawing.Size(621, 65);
            this.gcdResult.TabIndex = 33;
            // 
            // initialNumber1
            // 
            this.initialNumber1.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.initialNumber1.Location = new System.Drawing.Point(741, 190);
            this.initialNumber1.Name = "initialNumber1";
            this.initialNumber1.Size = new System.Drawing.Size(470, 65);
            this.initialNumber1.TabIndex = 32;
            // 
            // findGCD
            // 
            this.findGCD.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.findGCD.Location = new System.Drawing.Point(327, 483);
            this.findGCD.Name = "findGCD";
            this.findGCD.Size = new System.Drawing.Size(709, 84);
            this.findGCD.TabIndex = 31;
            this.findGCD.Text = "Найти НОД";
            this.findGCD.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(64, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1234, 74);
            this.label1.TabIndex = 30;
            this.label1.Text = "Нахождение наибольшего общего делителя";
            // 
            // dividersProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 902);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.initialNumber2);
            this.Controls.Add(this.help);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gcdResult);
            this.Controls.Add(this.initialNumber1);
            this.Controls.Add(this.findGCD);
            this.Controls.Add(this.label1);
            this.Name = "dividersProblem";
            this.Text = "dividersProblem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox initialNumber2;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gcdResult;
        private System.Windows.Forms.TextBox initialNumber1;
        private System.Windows.Forms.Button findGCD;
        private System.Windows.Forms.Label label1;
    }
}