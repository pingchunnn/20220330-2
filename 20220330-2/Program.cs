using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220330_2
{
    internal class Program
    {
        public static bool CheckPrime(int n)
        {
            bool is_prime = true;

            for (int i = 2; i <= n / 2; i++)
            {
                if ((double)(n / i) == (double)n / i) //判斷是否能整除
                {
                    is_prime = false;
                    break;
                }
            }
            return is_prime;
        }
        static void Main(string[] args)
        {
            for (int i = 100; i <= 500; i++)
                if (CheckPrime(i))
                    Console.Write("{0},", i);
            Console.ReadLine();
        }
    }
}
