﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TZ4;

namespace WinFormsTZ4
{
    public partial class dividers : Form
    {
        public dividers()
        {
            InitializeComponent();
        }

        private void findDividers_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(initialNumber.Text, out int n))
                    throw new Exception("Вы ввели не число или не целое число.");

                if (n <= 0)
                    throw new Exception("Вы ввели неположительное число.");

                dividersResult.Text = Numbers.DivOfNUm(n);
            }
            catch (Exception ex)
            {
                Form form = new error(ex.Message);
                form.AutoSize = true;
                form.ShowDialog();
            }
        }

        private void help_Click_1(object sender, EventArgs e)
        {
            help form = new help("dividers");
            form.AutoSize = true;
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
