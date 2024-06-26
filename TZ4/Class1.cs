﻿using System;
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
        /// <param name="n">Число, делители которого нужно найти.</param>
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
            StringBuilder sb = new StringBuilder();
            List<int> final = new List<int>();
            
            
            for (int i = 2; i <=n; i++)
                while (n % i == 0 && n != 1)
                {
                    final.Add(i);
                    n /= i;
                }         
                    
            int c = 1;
            int j = 1;
            for (; j < final.Count; j++)
            {
                if (final[j - 1] == final[j])
                    c++;
                else
                { 
                    sb.Append(final[j - 1]).Append("^").Append(c).Append("*");
                    c = 1;
                }  
            }
            sb.Append(final[j - 1]).Append("^").Append(c);            
            return sb.ToString();
        }
        /// <summary>
        /// Нахождение всех простых чисел в диапазоне [1,n]
        /// </summary>
        /// <param name="n">Число</param>
        /// <returns>Возвращает массив, который содержыт все простые числа в диапазоне [1,n]</returns>
        public static string PrimeNum(int n)
        {
            int i = 0;
            StringBuilder sb = new StringBuilder();
            bool[] key = new bool[n]; 
         
            for (i = 2; i <= n; i++)
                key[i - 2] = true;           
            
            for (i = 2; i * i <= n; i++)
                if (key[i - 2])
                    for (int j = i * i; j <= n; j += i)
                        key[j - 2] = false;
            for (i = 2; i <= key.Length; i++)            
                if (key[i - 2])
                    sb.Append(i).Append(" ");            
            return sb.ToString();            
        }
        /// <summary>
        /// Нахождение наибольшего общего делителя
        /// </summary>
        /// <param name="n">Первое число</param>
        /// <param name="m">Второе число</param>
        /// <returns>Число, являющееся НОД для двух чисел</returns>
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
