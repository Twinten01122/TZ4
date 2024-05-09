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
            this.task = task;
            string enterTheNumber = "Введите число в поле рядом с надписью \n\"Введите число\".";
            string textt = string.Empty;
            InitializeComponent();
            switch (task)
            {
                case "dividers":
                    textt += "Данный метод позволяет найти все делители\nзаданного числа, учитывая единицу и само число.\n" + enterTheNumber;
                    break;
                case "factorization":
                    textt += "Данный метод позволяет разложить число\nна произведение простых чисел.\n" + enterTheNumber;
                    break;
                case "primes":
                    textt += "Данный метод осуществляет поиск простых\nчисел в диапазоне от единицы до заданного\nчисла. Введите верхнюю границу интервала в\nсоответствующее поле.\n";
                    break;
                case "gcd":
                    textt += "Данный метод осуществляет поиск наибольшего\nобщего делителя для двух чисел. Введите\nчисла в соответствующие поля.\n";
                    break;
                case "lcm":
                    textt += "Данный метод осуществляет поиск наименьшего\nобщего кратного для двух чисел. Введите\nчисла в соответствующие поля.\n";
                    break;
                case "bigIntFactorization":
                    textt += "Данный метод позволяет разложить число\nна произведение простых чисел.\n" + enterTheNumber;
                    break;
                case "dividersProblem":
                    textt += "Данный метод решает следующую задачу:\nНайти числа с заданным количеством делителей\nв заданном интервале, вывести их\nи их делители.\n";
                    break;
                default:
                    break;
            }
            textt += "После нажатия на кнопку\nвы получите результат в соответствующем окне.";
            helpMessage.Text = textt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
