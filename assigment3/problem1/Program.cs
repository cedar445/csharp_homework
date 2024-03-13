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
            try
            {
                Rectangle rec = new Rectangle(2, 3);
                Console.WriteLine($"Area of rectangle is {rec.Area()}");
                Square sq = new Square(3, 4);
                Console.WriteLine($"Area of Square is {sq.Area()}");
                Triangle tr = new Triangle(3, 4);
                Console.WriteLine($"Area of Triangle is {tr.Area()}");
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine("something went wrong");
            }
        }
    }
    public class Rectangle
    {
        public int width { get; set; }
        public int height { get; set; }
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
            if(width<=0|| height<=0)
            {
                throw new ArgumentException("width and heigth must bigger than 0");
            }
        }
        public int Area()
        {
            return width * height;
        }
    }
    public class Square : Rectangle
    {
        public Square(int width, int height):base(width, height) { }
    }
    public class Triangle
    {
        public int bottom {  get; set; }
        public int height { get; set; }
        public Triangle(int bottom, int height)
        {
            this.bottom = bottom;
            this.height = height;
            if (bottom<=0 || height <= 0)
            {
                throw new ArgumentException("bootom and height must bigger than 0");
            }
        }
        public double Area ()
        {
            double tmp = bottom * height;
            return tmp / 2;
        }
    }
}
