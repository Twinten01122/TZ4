using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Runtime.InteropServices;
namespace TZ4
{
    public class Numbers
    {
        /// <summary>
        /// Функция находит все делители числа n
        /// </summary>
        /// <param name="n">Число, делители которого нужно найти</param>
        /// <returns>Возвращает строку со всеми делителями числа n</returns>
        public static string DivOfNUm(int n)
        {         
            string finalStr = "";
            List <int> final = new List<int>(); 
            int sqrt = (int)Math.Sqrt(n);              
            for (int i = 1; i <=sqrt + 1; i++)                
                if (n % i == 0)
                {
                    if (i == sqrt)
                    {
                        if (Math.Pow(i, 2) == n)
                        {
                            final.Add(i);
                            break;
                        }
                        else 
                        {
                            final.Add(i);
                            final.Add(n / i);
                            break;
                        }
                    }
                    final.Add(i);
                    final.Add(n/i);
                }            
            final.Sort();
            for (int j = 0; j < final.Count; j++)
            {
                finalStr = finalStr + (final[j] + " ");
            }
            return finalStr;
        }
        /// <summary>
        /// Функция производит факторизацию числа 
        /// </summary>
        /// <param name="n">Число, которое нужно разложить на простые делители</param>
        /// <returns>Возвращает строку, которая является простыми делителями числа n</returns>
        public static string Factorization(int n)
        {
            List<int> final = new List<int>();
            string s = "";
            int[] prn = PrimeNum(n);
            while (n != 1)
                foreach (int i in prn)
                    if (n % i == 0)
                    {
                        final.Add(i);
                        n /= i;
                        break;
                    }
            int c = 1;
            int j = 1;
            for (; j < final.Count; j++)
            {
                if (final[j - 1] == final[j])
                    c++;
                else
                { 
                    s = s + final[j - 1].ToString() + "^" + c + "*";
                    c = 1;
                }  
            }
            s = s + final[j - 1].ToString() + "^" + c;            
            return s;
        }
        /// <summary>
        /// Нахождение всех простых чисел в диапазоне [1,n]
        /// </summary>
        /// <param name="n">Число, </param>
        /// <returns>Возвращает массив, который содержыт все простые числа в диапазоне [1,n]</returns>
        public static int[] PrimeNum(int n)
        {
            int i = 0;
            List<int> list = new List<int>();
            Dictionary<int, bool> dic = new Dictionary<int, bool>();
            
            for (i = 2; i <= n; i++)
                dic[i] = true;           
            
            for (i = 2; i * i <= n; i++)
                if (dic[i])
                    for (int j = i * i; j <= n; j += i)
                        dic[j] = false;
            for (i = 2; i <= dic.Count + 1; i++)            
                if (dic[i])
                    list.Add(i);            
            return list.ToArray();            
        }



        //Внутренняя функция
        private static int[] FacInside(int n)
        {
            List<int> final = new List<int>();
            string s = "";
            int[] prn = PrimeNum(n);
            while (n != 1)
                foreach (int i in prn)
                    if (n % i == 0)
                    {
                        final.Add(i);
                        n /= i;
                        break;
                    }           
            return final.ToArray();
        }
        static public long FindNOD(int n, int m)
        {            
            while(m != 0)
            {
                int temp = m;
                m = n % m;
                n = temp;
            }
            return n;
        }
        static public long FindNOK(int n, int m)
        {
            return n * m / FindNOD(n, m);
        }
        /// <summary>
        /// Функция для нахождения всех протых делителей для типа BigInteger (Сложность O(L(n)^(3*sqrt(2))))
        /// </summary>
        /// <param name="n">Число</param>
        /// <returns>Возвращает строкуБ содержащую все простые делители числа</returns>
        static public string BigFactorization(BigInteger n)
        {
            string s = "";
            List<BigInteger> final = new List<BigInteger>();

            for (BigInteger i = 2; i * i <= n; i++)
            {
                while (n % i == 0)
                {
                    final.Add(i);
                    n /= i;
                }
            }

            if (n > 1)
            {
                final.Add(n);
            }
            int l = 1;
            int j = 1;
            for (; j < final.Count; j++)
            {
                if (final[j - 1] == final[j])
                    l++;
                else
                {
                    s = s + final[j - 1].ToString() + "^" + l + "*";
                    l = 1;
                }
            }
            s = s + final[j - 1].ToString() + "^" + l;
            return s;
        }
        /// <summary>
        /// Функция для поиска всех чисел в указанном диапазоне с заданным количеством делителей
        /// </summary>
        /// <param name="start">Стартовое число диапазона</param>
        /// <param name="end">Конечное число диапазона</param>
        /// <param name="count">Количество делителей числа</param>
        /// <returns>Возвращает кортеж из строкБ первая строка - все числа в указанном диапазоне, вторая - их делители соответственно</returns>
        static public (string, string) Task(int start, int end, int count)            
        {            
            string[] b;
            string FinalNum = "";
            string FinalDiv = "";

            Dictionary <int, string> dic = new Dictionary<int, string>();
            for (int i = start; i <= end; i++)
            {
                string s = DivOfNUm(i);
                b = s.TrimEnd().Split(' ');               
                if (b.Length == count)
                    dic[i] = s;
            }
            foreach (System.Collections.Generic.KeyValuePair<int, string> keyValuePair in dic)
            {
                FinalNum = FinalNum + keyValuePair.Key + "\n";
                FinalDiv = FinalDiv + keyValuePair.Value + "\n";
            }      
            return (FinalNum,FinalDiv);
        }
    }
}
