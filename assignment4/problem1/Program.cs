using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace problem1
{
    public class Node<T>
    {
        public Node<T> next;
        public T value;
        public Node(T value)
        {
            this.value = value;
        }
    }
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private T sum;
        private T max;
        private T min;
        public GenericList()
        {
            head = tail = null;
        }
        public Node<T> Head
        {
            get => head;
        }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
                sum = t;
                max = t;
                min = t;
            }
            else
            {
                tail.next = n;
                tail = n;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> intlist= new GenericList<int>();
            for(int i = 0; i < 10; i++)
            {
                intlist.Add(i);
            }
            int sum = 0;
            int max = intlist.Head.value;
            int min = intlist.Head.value;
            Action<int> getSum = m => sum += m;
            Action<int> getMax = m => max = (max > m) ? max : m;
            Action<int> getMin = m => min = (min < m) ? min : m;
            Node<int> n=intlist.Head;
            while(n != null )
            {
                getSum(n.value);
                getMax(n.value);
                getMin(n.value);
                n=n.next;
            }
            Console.WriteLine($"SUM:{sum}");
            Console.WriteLine($"MAX:{max}");
            Console.WriteLine($"MIN:{min}");
            Console.ReadKey();
        }
    }
}
