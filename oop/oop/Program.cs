using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            int x = 3;
            int y = 5;
            //int sum = 0;
            int multiply = 1;
            //sum = calc.Add(x, y);
            multiply = calc.Add(x, y);
            //Console.WriteLine("sum of {0} + {1} = {2}", x, y, sum);
            Console.WriteLine("sum of {0} * {1} = {2}", x, y, multiply);
            Console.ReadLine();
        }
    }
}
