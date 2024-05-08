using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace TZ4
{
    public class Numbers
    {
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
        public static int[] FacInside(int n)
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

        static public string BigFactorization(BigInteger n)
        {
            string s = "";
            List <BigInteger> final = new List<BigInteger>();
            BigInteger x = 2;
            BigInteger y = 2;
            BigInteger c = 1;

            while (final.Count == 0)
            {
                x = (x * x + c) % n;
                y = (y * y + c) % n;
                y = (y * y + c) % n;

                BigInteger gcd = BigInteger.GreatestCommonDivisor(BigInteger.Abs(x-y), n);
                if (gcd != 1 && gcd != n)
                {
                    final.Add(gcd);
                    final.Add(n / gcd);
                }
            } 
            
            int l= 1;
            int j = 1;
            for (; j < final.Count; j++)
            {
                if (final[j - 1] == final[j])
                    l++;
                else
                {
                    s = s + final[j - 1].ToString() + "^" + c + "*";
                    l = 1;
                }
            }
            s = s + final[j - 1].ToString() + "^" + c;
            return s;
        }
    }
}
