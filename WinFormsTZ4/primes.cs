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
    public partial class primes : Form
    {
        public primes()
        {
            InitializeComponent();
        }

        private void findPrimes_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(initialNumber2.Text, out int n))
                    throw new Exception("Вы ввели не число или не целое число.");

                if (n <=1)
                    throw new Exception("Вы ввели число меньше единицы.");

                string ans = "";

                foreach (int i in Numbers.PrimeNum(n))
                    ans += i.ToString() + " ";

                primesResult.Text = ans;
            }
            catch (Exception ex)
            {
                Form form = new error(ex.Message);
                form.ShowDialog();
            }
            
        }

        private void help_Click(object sender, EventArgs e)
        {
            Form form = new help("primes");
            form.ShowDialog();
        }
    }
}
