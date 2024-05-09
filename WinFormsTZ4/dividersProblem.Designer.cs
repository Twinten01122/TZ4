namespace WinFormsTZ4
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
            this.help = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.initialNumber1 = new System.Windows.Forms.TextBox();
            this.findGCD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.initialNumber2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.initialNumber3 = new System.Windows.Forms.TextBox();
            this.numbersResult = new System.Windows.Forms.RichTextBox();
            this.dividersResult = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // help
            // 
            this.help.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.help.Location = new System.Drawing.Point(1065, 976);
            this.help.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(283, 82);
            this.help.TabIndex = 36;
            this.help.Text = "Справка";
            this.help.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(61, 606);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 46);
            this.label3.TabIndex = 35;
            this.label3.Text = "Числа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(23, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(640, 46);
            this.label2.TabIndex = 34;
            this.label2.Text = "Введите количество делителей";
            // 
            // initialNumber1
            // 
            this.initialNumber1.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.initialNumber1.Location = new System.Drawing.Point(1051, 194);
            this.initialNumber1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.initialNumber1.Name = "initialNumber1";
            this.initialNumber1.Size = new System.Drawing.Size(279, 53);
            this.initialNumber1.TabIndex = 32;
            // 
            // findGCD
            // 
            this.findGCD.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.findGCD.Location = new System.Drawing.Point(327, 464);
            this.findGCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.findGCD.Name = "findGCD";
            this.findGCD.Size = new System.Drawing.Size(709, 84);
            this.findGCD.TabIndex = 31;
            this.findGCD.Text = "Найти числа";
            this.findGCD.UseVisualStyleBackColor = true;
            this.findGCD.Click += new System.EventHandler(this.findGCD_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1333, 122);
            this.label1.TabIndex = 30;
            this.label1.Text = "Нахождение чисел с заданным количеством делителей в интервале";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(23, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(768, 46);
            this.label4.TabIndex = 42;
            this.label4.Text = "Введите верхнюю границу интервала";
            // 
            // initialNumber2
            // 
            this.initialNumber2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.initialNumber2.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.initialNumber2.Location = new System.Drawing.Point(1051, 282);
            this.initialNumber2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.initialNumber2.Name = "initialNumber2";
            this.initialNumber2.Size = new System.Drawing.Size(279, 53);
            this.initialNumber2.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(23, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(754, 46);
            this.label5.TabIndex = 40;
            this.label5.Text = "Введите нижнюю границу интервала";
            // 
            // initialNumber3
            // 
            this.initialNumber3.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.initialNumber3.Location = new System.Drawing.Point(1051, 364);
            this.initialNumber3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.initialNumber3.Name = "initialNumber3";
            this.initialNumber3.Size = new System.Drawing.Size(279, 53);
            this.initialNumber3.TabIndex = 39;
            // 
            // numbersResult
            // 
            this.numbersResult.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.numbersResult.Location = new System.Drawing.Point(72, 681);
            this.numbersResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numbersResult.Name = "numbersResult";
            this.numbersResult.Size = new System.Drawing.Size(565, 234);
            this.numbersResult.TabIndex = 43;
            this.numbersResult.Text = "";
            // 
            // dividersResult
            // 
            this.dividersResult.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.dividersResult.Location = new System.Drawing.Point(707, 681);
            this.dividersResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dividersResult.Name = "dividersResult";
            this.dividersResult.Size = new System.Drawing.Size(565, 234);
            this.dividersResult.TabIndex = 45;
            this.dividersResult.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(696, 606);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 46);
            this.label6.TabIndex = 44;
            this.label6.Text = "Делители ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.button1.Location = new System.Drawing.Point(532, 976);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 82);
            this.button1.TabIndex = 46;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dividersProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 1072);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dividersResult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numbersResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.initialNumber2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.initialNumber3);
            this.Controls.Add(this.help);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.initialNumber1);
            this.Controls.Add(this.findGCD);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "dividersProblem";
            this.Text = "Задача на нахождение делителей";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox initialNumber1;
        private System.Windows.Forms.Button findGCD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox initialNumber2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox initialNumber3;
        private System.Windows.Forms.RichTextBox numbersResult;
        private System.Windows.Forms.RichTextBox dividersResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}