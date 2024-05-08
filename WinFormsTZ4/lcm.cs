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
    public partial class lcm : Form
    {
        public lcm()
        {
            InitializeComponent();
        }

        private void findLCM_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(initialNumber1.Text, out int n) || !int.TryParse(initialNumber2.Text, out int m))
                    throw new Exception("Вы ввели не число или не целое число.");
                
                if (n <= 0 || m <= 0)
                    throw new Exception("Вы ввели неположительное число.");

                lcmResult.Text = Convert.ToString(Numbers.FindNOK(n, m));
            }
            catch (Exception ex)
            {
                Form form = new error(ex.Message);
                form.ShowDialog();
            }
        }
        private void help_Click(object sender, EventArgs e)
        {
            Form form = new help("lcm");
            form.ShowDialog();
        }
    }
}
