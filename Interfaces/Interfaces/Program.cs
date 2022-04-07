using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            rectangle rec = new rectangle();
            Circle circle = new Circle();
            double a = 10;
            double b = 20;
            double c = 1.0;
            double area = 0.0;
            double perimeter = 0.0;
            rec.Height = a;
            rec.Width = b;
            area = rec.Area();
            Console.WriteLine("Area of rectangle is : {0:F}", area);
            perimeter = rec.perimeter();
            Console.WriteLine("Perimeter of rectangle is : {0:F}", perimeter);
            // Console.ReadLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Circle area and perimeter");
            circle.radius = c;
            area = circle.Area();
            Console.WriteLine("Area of circle is : {0:F}", area);
            perimeter = circle.perimeter();
            Console.WriteLine("Perimeter of circle is : {0:F}", perimeter);
            Console.ReadLine();

        }
    }
}
