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
using System.Numerics;

namespace WinFormsTZ4
{
    public partial class bigIntFactorization : Form
    {
        public bigIntFactorization()
        {
            InitializeComponent();
        }

        private void findDividers_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (!BigInteger.TryParse(initialNumber.Text, out BigInteger n))
                    throw new Exception("Вы ввели не число или не целое число.");

                if (n <= 0)
                    throw new Exception("Вы ввели неположительное число.");

                factorizationResult.Text = Numbers.BigFactorization(n);

            }
            catch (Exception ex)
            {
                Form form = new error(ex.Message);
                form.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void help_Click_1(object sender, EventArgs e)
        {
            help form = new help("bigIntFactorization");
            form.ShowDialog();
        }
    }
}
