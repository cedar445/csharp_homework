using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleFactory factory = new SimpleFactory();
            List<MyShape> shapes = factory.Create();
            Console.WriteLine(factory.AreaSum(shapes));
            Console.ReadKey();
        }
    }
    public abstract class Shape
    {
        public abstract int Area();
    }
    public class MyShape:Shape
    {
        public int width { get; set; }
        public int height { get; set; }
        public MyShape(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        override public int Area () { return width * height; }
    }
    public class SimpleFactory
    {
        public SimpleFactory() { }
        public List<MyShape> Create()
        {
            List<MyShape> ms=new List<MyShape>();
            for(int i = 0; i < 10; i++)
            {
                ms.Add(new MyShape(i, i));
            }
            return ms;
        }
        public int AreaSum(List<MyShape> ms)
        {
            int sum = 0;
            foreach(MyShape m in ms)
            {
                sum += m.Area();
            }
            return sum;
        }
    }
}
