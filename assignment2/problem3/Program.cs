using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int []arr;
            arr = new int[101];
            for(int i = 0; i < 101; i++)
            {
                arr[i] = i;
            }
            int k = 2;//埃式筛法要去除的数
            while (k < 101)
            {
                for (int i = k + 1; i < 101; i++)
                {
                    if (arr[i] % k == 0)
                    {
                        arr[i] = 0;
                    }
                }
                k++;
                while (k < 101 && arr[k] == 0)//下一个没被筛掉的数为基数
                {
                    k++;
                }
                
            }
            for(int i = 2;i < 101; i++)
            {
                if (arr[i] != 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }Console.ReadLine();
        }
    }
}
