namespace WinFormsTZ4
{
    partial class lcm
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
            this.lcmResult = new System.Windows.Forms.TextBox();
            this.initialNumber1 = new System.Windows.Forms.TextBox();
            this.findLCM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(113, 286);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(457, 46);
            this.label4.TabIndex = 38;
            this.label4.Text = "Введите второе число";
            // 
            // initialNumber2
            // 
            this.initialNumber2.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.initialNumber2.Location = new System.Drawing.Point(579, 284);
            this.initialNumber2.Margin = new System.Windows.Forms.Padding(2);
            this.initialNumber2.Name = "initialNumber2";
            this.initialNumber2.Size = new System.Drawing.Size(354, 53);
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
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(301, 486);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(452, 46);
            this.label3.TabIndex = 35;
            this.label3.Text = "НОK заданных чисел:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(113, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 46);
            this.label2.TabIndex = 34;
            this.label2.Text = "Введите первое число";
            // 
            // lcmResult
            // 
            this.lcmResult.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.lcmResult.Location = new System.Drawing.Point(278, 575);
            this.lcmResult.Margin = new System.Windows.Forms.Padding(2);
            this.lcmResult.Name = "lcmResult";
            this.lcmResult.Size = new System.Drawing.Size(467, 53);
            this.lcmResult.TabIndex = 33;
            // 
            // initialNumber1
            // 
            this.initialNumber1.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.initialNumber1.Location = new System.Drawing.Point(579, 202);
            this.initialNumber1.Margin = new System.Windows.Forms.Padding(2);
            this.initialNumber1.Name = "initialNumber1";
            this.initialNumber1.Size = new System.Drawing.Size(354, 53);
            this.initialNumber1.TabIndex = 32;
            // 
            // findLCM
            // 
            this.findLCM.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.findLCM.Location = new System.Drawing.Point(245, 368);
            this.findLCM.Margin = new System.Windows.Forms.Padding(2);
            this.findLCM.Name = "findLCM";
            this.findLCM.Size = new System.Drawing.Size(532, 68);
            this.findLCM.TabIndex = 31;
            this.findLCM.Text = "Найти НОK";
            this.findLCM.UseVisualStyleBackColor = true;
            this.findLCM.Click += new System.EventHandler(this.findLCM_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1000, 60);
            this.label1.TabIndex = 30;
            this.label1.Text = "Нахождение наименьшего общего кратного";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Italic);
            this.button1.Location = new System.Drawing.Point(399, 655);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 67);
            this.button1.TabIndex = 47;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lcm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 733);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.initialNumber2);
            this.Controls.Add(this.help);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lcmResult);
            this.Controls.Add(this.initialNumber1);
            this.Controls.Add(this.findLCM);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "lcm";
            this.Text = "Нахождение наименьшего общего кратного";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox initialNumber2;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lcmResult;
        private System.Windows.Forms.TextBox initialNumber1;
        private System.Windows.Forms.Button findLCM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}