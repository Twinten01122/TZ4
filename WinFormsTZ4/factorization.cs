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
    public partial class factorization : Form
    {
        public factorization()
        {
            InitializeComponent();
        }

        private void factorize_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(initialNumber.Text, out int n))
                    throw new Exception("Вы ввели не число или не целое число.");

                if (n <= 0)
                    throw new Exception("Вы ввели неположительное число.");


                factorizationResult.Text = Numbers.Factorization(n);
            }
            catch (Exception ex)
            {
                Form form = new error(ex.Message);
                form.ShowDialog();
            }
        }
        private void help_Click(object sender, EventArgs e)
        {
            Form form = new help("factorization");
            form.ShowDialog();
        }
    }
}
