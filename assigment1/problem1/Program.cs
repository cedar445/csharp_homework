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
            string s1, s2;
            double a = 0, b = 0;
            Console.WriteLine("Please input the numbers:");
            s1 = Console.ReadLine();
            a = Double.Parse(s1);
            s2 = Console.ReadLine();
            b= Double.Parse(s2);
            string c = "";
            Console.WriteLine("Please input the operator:");
            c = Console.ReadLine();
            if(c == "+")
            {
                Console.WriteLine($"result is:{a + b}");
            }
            else if(c == "-")
            {
                Console.WriteLine($"result is:{a - b}");
            }
            else if (c == "*")
            {
                Console.WriteLine($"result is:{a * b}");
            }
            else if (c == "/")
            {
                Console.WriteLine($"result is:{a / b}");
            }
            Console.ReadLine();
        }
    }
}
