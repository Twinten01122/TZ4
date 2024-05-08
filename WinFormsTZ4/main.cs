using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTZ4
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void dividersButton_Click(object sender, EventArgs e)
        {
            Form form = new dividers();
            form.ShowDialog();
        }

        private void lcmButton_Click(object sender, EventArgs e)
        {
            Form form = new lcm();
            form.ShowDialog();
        }

        private void gcdButton_Click(object sender, EventArgs e)
        {
            Form form = new gcd();
            form.ShowDialog();
        }

        private void factorizationButton_Click(object sender, EventArgs e)
        {
            Form form = new factorization();
            form.ShowDialog();
        }

        private void bigIntFactorizationButton_Click(object sender, EventArgs e)
        {
            Form form = new bigIntFactorization();
            form.ShowDialog();
        }

        private void primesButton_Click(object sender, EventArgs e)
        {
            Form form = new primes();
            form.ShowDialog();
        }

        private void dividersProblemButton_Click(object sender, EventArgs e)
        {
            Form form = new dividersProblem();
            form.ShowDialog();
        }
    }
}
