using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            arr = new int[10];
            int sum = 0;
            double average;
            int max, min;
            Console.WriteLine("Please input the array(the length of array must be 10):");
            string s;
            s=Console.ReadLine();
            string tmp = "";//存储数字
            int k = 0;//下一个数字的数组下标
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i]!=' ')
                {
                    tmp += s[i];
                    if (i==s.Length-1)//处理最后一个数的特殊情况
                    {
                        arr[k] = Int32.Parse(tmp);
                        sum += arr[k];
                        k++;
                    }
                }
                else
                {
                    if (tmp != "")
                    {
                        arr[k] = Int32.Parse(tmp);
                        sum += arr[k];
                        k++;
                    }
                    tmp = "";
                }
            }
            average = sum / 10;
            max = arr[0];
            min = arr[0];
            for(int i = 0;i<10;i++)
            {
                if (arr[i] > max)
                    max = arr[i];
                if (arr[i] < min)   
                    min = arr[i];
            }
            Console.WriteLine("sum:" + sum);
            Console.WriteLine("average:"+average);
            Console.WriteLine("max:" + max);
            Console.WriteLine("min:" + min);
            Console.ReadLine();
        }
    }
}
