using System;
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
    public partial class gcd : Form
    {
        public gcd()
        {
            InitializeComponent();
        }
        private void findGCD_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(initialNumber1.Text, out int n)|| !int.TryParse(initialNumber2.Text, out int m))
                    throw new Exception("Вы ввели не число или не целое число.");

                if (n <= 0 || m <= 0)
                    throw new Exception("Вы ввели неположительное число.");


                gcdResult.Text = Convert.ToString(Numbers.FindNOD(n, m));
            }
            catch (Exception ex)
            {
                error form = new error(ex.Message);
                form.AutoSize = true;
                form.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void help_Click_1(object sender, EventArgs e)
        {
            help form = new help("gcd");
            form.AutoSize = true;
            form.ShowDialog();
        }
    }
}
