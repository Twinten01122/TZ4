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
    public partial class help : Form
    {
        string task;
        public help(string task)
        {
            InitializeComponent();
            this.task = task;
            string enterTheNumber = "Введите число в поле рядом с надписью \"Введите число\".";
            switch (task)
            {
                case "dividers":
                    helpMessage.Text = "Данный метод позволяет найти все делители заданного числа, учитывая единицу и само число.\n";
                    break;
                case "factorization":
                    helpMessage.Text = "";
                    break;
                case "primes":
                    helpMessage.Text = "";
                    break;
                case "gcd":
                    helpMessage.Text = "";
                    break;
                case "lcm":
                    helpMessage.Text = "";
                    break;
                case "bigIntFactorization":
                    helpMessage.Text = "";
                    break;
                case "dividersProblem":
                    helpMessage.Text = "";
                    break;

            }
        }
    }
}
