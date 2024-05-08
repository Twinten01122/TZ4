using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TZ4;
using System.Numerics;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int i = 0;


            int[] f = { 8, 12, 14, 15, 120, 225, 487, 522 };
            string s = Numbers.BigFactorization();
            
            for (i = 0; i < f.Length; i++)
            {

                string s = Numbers.Factorization(f[i]);
                //Console.WriteLine(s);
            }
        }

        static void BigIntFactorizationTest()
        {
            string initialNumber;
            string ansCorr;
            string ansLib;
            int count1 = 0;

            Console.WriteLine("\nФакторизация больших чисел");

            var primeFactorsArr = new string[20][];
            primeFactorsArr[0] = new string[] { "123456789123456789", "3^2 * 7^1 * 11^1 * 13^1 * 19^1 * 3607^1 * 3803^1 * 52579^1" };
            primeFactorsArr[1] = new string[] { "35687864325168786", "2^1 * 3^1 * 19^1 * 53^1 * 199^1 * 2381^1 * 12466007^1" };
            primeFactorsArr[2] = new string[] { "55555555555555555555", "5^1 * 11^1 * 41^1 * 101^1 * 271^1 * 3541^1 * 9091^1 * 27961^1" };
            primeFactorsArr[3] = new string[] { "62626262616860", "2^2 * 5^1 * 43^2 * 167^1 * 3019^1 * 3359^1" };
            primeFactorsArr[4] = new string[] { "333333333333", "3^2 * 7^1 * 11^1 * 13^1 * 37^1 * 101^1 * 9901^1" };
            primeFactorsArr[5] = new string[] { "10000000000000", "2^13 * 5^13" };
            primeFactorsArr[6] = new string[] { "302030402004", "2^2 * 3^2 * 59^1 * 71^1 * 257^1 * 7793^1" };
            primeFactorsArr[7] = new string[] { "555555555500", "2^2 * 5^3 * 11^1 * 41^1 * 271^1 * 9091^1" };
            primeFactorsArr[8] = new string[] { "666666666666", "2^1 * 3^2 * 7^1 * 11^1 * 13^1 * 37^1 * 101^1 * 9901^1" };
            primeFactorsArr[9] = new string[] { "3300220085685", "3^1 * 5^1 * 64627^1 * 3404377^1" };
            primeFactorsArr[10] = new string[] { "658300129986", "2^1 * 3^1 * 17^1 * 23^1 * 89^1 * 421^1 * 7489^1" };
            primeFactorsArr[11] = new string[] { "999999999999001235", "5^1 * 13^1 * 17^1 * 29^1 * 43^1 * 1277^1 * 5381^1 * 105613^1" };
            primeFactorsArr[12] = new string[] { "7863012222256563125", "5^4 * 13^1 * 29^1 * 1777^1 * 75503^1 * 248723^1" };
            primeFactorsArr[13] = new string[] { "454545454454523012", "2^2 * 3^1 * 7^1 * 37^1 * 4057^1 * 123289^1 * 292393^1" };
            primeFactorsArr[14] = new string[] { "10025669898975", "3^1 * 5^2 * 17^1 * 35597^1 * 220897^1" };
            primeFactorsArr[15] = new string[] { "7630001852319", "3^3 * 7^1 * 11^1 * 61^1 * 131^1 * 459271^1" };
            primeFactorsArr[16] = new string[] { "9630702123487", "1175297^1 * 8194271^1" };
            primeFactorsArr[17] = new string[] { "549004758852", "2^2 * 3^1 * 11^2 * 19^1 * 23^1 * 41^1 * 47^1 * 449^1" };
            primeFactorsArr[18] = new string[] { "8871114770023", "11^1 * 227^1 * 35531^1 * 99989^1" };
            primeFactorsArr[19] = new string[] { "1662583120447", "37^1 * 73^1 * 1327^1 * 463861^1" };

            foreach (var test in primeFactorsArr)
            {
                initialNumber = test[0];
                ansCorr = test[1];
                ansLib = Numbers.BigFactorization(BigInteger.Parse(initialNumber));

                Console.WriteLine($"\nЗаданное число: {initialNumber}");
                Console.WriteLine($"Ожидаемый результат: {ansCorr}");
                Console.WriteLine($"Результат работы программы: {ansLib}");
                count1 += Checking(ansLib, ansCorr);
            }
        }

        static int Checking(string s1, string s2)
        {
            if (s1 == s2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Success!");
                Console.ResetColor();
                return 1;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Fail!");
                Console.ResetColor();
                return 0;
            }
        }
    }
}
