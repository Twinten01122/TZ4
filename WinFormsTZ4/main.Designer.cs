﻿namespace WinFormsTZ4
{
    partial class main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.bigIntFactorizationButton = new System.Windows.Forms.Button();
            this.lcmButton = new System.Windows.Forms.Button();
            this.gcdButton = new System.Windows.Forms.Button();
            this.dividersButton = new System.Windows.Forms.Button();
            this.factorizationButton = new System.Windows.Forms.Button();
            this.primesButton = new System.Windows.Forms.Button();
            this.dividersProblemButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Verdana", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(355, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Операции с числами";
            // 
            // bigIntFactorizationButton
            // 
            this.bigIntFactorizationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bigIntFactorizationButton.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigIntFactorizationButton.Location = new System.Drawing.Point(627, 349);
            this.bigIntFactorizationButton.Margin = new System.Windows.Forms.Padding(2);
            this.bigIntFactorizationButton.Name = "bigIntFactorizationButton";
            this.bigIntFactorizationButton.Size = new System.Drawing.Size(554, 152);
            this.bigIntFactorizationButton.TabIndex = 1;
            this.bigIntFactorizationButton.Text = "Факторизация большого числа";
            this.bigIntFactorizationButton.UseVisualStyleBackColor = true;
            this.bigIntFactorizationButton.Click += new System.EventHandler(this.bigIntFactorizationButton_Click);
            // 
            // lcmButton
            // 
            this.lcmButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lcmButton.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcmButton.Location = new System.Drawing.Point(11, 349);
            this.lcmButton.Margin = new System.Windows.Forms.Padding(2);
            this.lcmButton.Name = "lcmButton";
            this.lcmButton.Size = new System.Drawing.Size(554, 152);
            this.lcmButton.TabIndex = 2;
            this.lcmButton.Text = "Нахождение наименьшего общего кратного";
            this.lcmButton.UseVisualStyleBackColor = true;
            this.lcmButton.Click += new System.EventHandler(this.lcmButton_Click);
            // 
            // gcdButton
            // 
            this.gcdButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gcdButton.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcdButton.Location = new System.Drawing.Point(11, 523);
            this.gcdButton.Margin = new System.Windows.Forms.Padding(2);
            this.gcdButton.Name = "gcdButton";
            this.gcdButton.Size = new System.Drawing.Size(554, 152);
            this.gcdButton.TabIndex = 3;
            this.gcdButton.Text = "Нахождение наибольшего общего делителя";
            this.gcdButton.UseVisualStyleBackColor = true;
            this.gcdButton.Click += new System.EventHandler(this.gcdButton_Click);
            // 
            // dividersButton
            // 
            this.dividersButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dividersButton.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividersButton.Location = new System.Drawing.Point(11, 171);
            this.dividersButton.Margin = new System.Windows.Forms.Padding(2);
            this.dividersButton.Name = "dividersButton";
            this.dividersButton.Size = new System.Drawing.Size(554, 152);
            this.dividersButton.TabIndex = 4;
            this.dividersButton.Text = "Нахождение всех делителей числа";
            this.dividersButton.UseVisualStyleBackColor = true;
            this.dividersButton.Click += new System.EventHandler(this.dividersButton_Click);
            // 
            // factorizationButton
            // 
            this.factorizationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.factorizationButton.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factorizationButton.Location = new System.Drawing.Point(627, 171);
            this.factorizationButton.Margin = new System.Windows.Forms.Padding(2);
            this.factorizationButton.Name = "factorizationButton";
            this.factorizationButton.Size = new System.Drawing.Size(554, 152);
            this.factorizationButton.TabIndex = 5;
            this.factorizationButton.Text = "Факторизация числа";
            this.factorizationButton.UseVisualStyleBackColor = true;
            this.factorizationButton.Click += new System.EventHandler(this.factorizationButton_Click);
            // 
            // primesButton
            // 
            this.primesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.primesButton.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primesButton.Location = new System.Drawing.Point(627, 523);
            this.primesButton.Margin = new System.Windows.Forms.Padding(2);
            this.primesButton.Name = "primesButton";
            this.primesButton.Size = new System.Drawing.Size(554, 152);
            this.primesButton.TabIndex = 6;
            this.primesButton.Text = "Нахождение простых чисел в интервале";
            this.primesButton.UseVisualStyleBackColor = true;
            this.primesButton.Click += new System.EventHandler(this.primesButton_Click);
            // 
            // dividersProblemButton
            // 
            this.dividersProblemButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dividersProblemButton.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividersProblemButton.Location = new System.Drawing.Point(280, 696);
            this.dividersProblemButton.Margin = new System.Windows.Forms.Padding(2);
            this.dividersProblemButton.Name = "dividersProblemButton";
            this.dividersProblemButton.Size = new System.Drawing.Size(608, 152);
            this.dividersProblemButton.TabIndex = 7;
            this.dividersProblemButton.Text = "Задача на нахождение делителей";
            this.dividersProblemButton.UseVisualStyleBackColor = true;
            this.dividersProblemButton.Click += new System.EventHandler(this.dividersProblemButton_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 859);
            this.Controls.Add(this.dividersProblemButton);
            this.Controls.Add(this.primesButton);
            this.Controls.Add(this.factorizationButton);
            this.Controls.Add(this.dividersButton);
            this.Controls.Add(this.gcdButton);
            this.Controls.Add(this.lcmButton);
            this.Controls.Add(this.bigIntFactorizationButton);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "main";
            this.Text = "Операции с числами";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bigIntFactorizationButton;
        private System.Windows.Forms.Button lcmButton;
        private System.Windows.Forms.Button gcdButton;
        private System.Windows.Forms.Button dividersButton;
        private System.Windows.Forms.Button factorizationButton;
        private System.Windows.Forms.Button primesButton;
        private System.Windows.Forms.Button dividersProblemButton;
    }
}

