using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plase input m,n:");
            string M, N;
            int m, n;
            Console.Write("m:");
            M=Console.ReadLine();
            m=Int32.Parse(M);
            Console.Write("n:");
            N = Console.ReadLine();
            n=Int32.Parse(N);
            int[,] arr=new int[m,n];
            Console.WriteLine("Please input the array");
            for(int i = 0; i < m; i++)
            {
                string s;
                s = Console.ReadLine();
                string tmp = "";//存储数字
                int k = 0;//下一个数字的数组下标
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j] != ' ')
                    {
                        tmp += s[j];
                        if (j == s.Length - 1)//处理最后一个数的特殊情况
                        {
                            arr[i,k] = Int32.Parse(tmp);
                            k++;
                        }
                    }
                    else
                    {
                        if (tmp != "")
                        {
                            arr[i,k] = Int32.Parse(tmp);
                            k++;
                        }
                        tmp = "";
                    }
                }
            }
            bool isTp = true;//是否是托普利兹矩阵
            int a = m - 1, b = 0;//对角线最左上下标
            for (; a > 0; a--)
            {
                int tmpa = a, tmpb = b;
                int value = arr[a, b];
                while (tmpa < m && tmpb < n)
                {
                    if (arr[tmpa, tmpb] != value)
                    {
                        isTp = false;
                    }
                    tmpa++;
                    tmpb++;
                }
            }
            for(; b<n ; b++)
            {
                int tmpa = a, tmpb = b;
                int value = arr[a, b];
                while (tmpa < m && tmpb < n)
                {
                    if (arr[tmpa, tmpb] != value)
                    {
                        isTp = false;
                    }
                    tmpa++;
                    tmpb++;
                }
            }
            if(isTp)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("Flase");
            }
            Console.ReadKey();
        }
    }
}
