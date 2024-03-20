using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input n (range 1 - n):");
            string s;
            s = Console.ReadLine();
            int n;
            n = Int32.Parse(s);
            for(int i = 1; i <= 3; i++)
            {
                if (i <= n)
                {
                    Console.Write(i + " ");
                }
            }
            for(int i = 4; i < n; i++)
            {
                bool ifPrime = true;
                for(int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        ifPrime = false;
                        break;
                    }
                }
                if (ifPrime)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
