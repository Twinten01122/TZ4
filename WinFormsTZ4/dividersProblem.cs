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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsTZ4
{
    public partial class dividersProblem : Form
    {
        public dividersProblem()
        {
            InitializeComponent();
        }

        private void findGCD_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(initialNumber1.Text, out int n) || !int.TryParse(initialNumber2.Text, out int m) || !int.TryParse(initialNumber3.Text, out int k))
                    throw new Exception("Вы ввели не число или не целое число.");

                if (n <= 0 || m <= 0 || k <= m)
                    throw new Exception("Вы ввели неположительное число или верхняя граница интервала не превышает нижнюю.");
                
                (numbersResult.Text, dividersResult.Text) = Numbers.Task(m, k, n);
            }
            catch (Exception ex)
            {
                Form form = new error(ex.Message);
                form.ShowDialog();
            }
        }

        private void help_Click(object sender, EventArgs e)
        {
            Form form = new help("dividersProblem");
            form.ShowDialog();
        }

    }
}
