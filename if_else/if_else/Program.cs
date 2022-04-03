using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 10;
            int lastNumber = 08;
            //Console.WriteLine("Enter first Number:");
            //firstNumber = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("Enter last number:");
            //lastNumber = Convert.ToInt16(Console.ReadLine());
            if (firstNumber > lastNumber)
            {
                Console.WriteLine("First Number is greater than last number");
            }
            else if (firstNumber == lastNumber)
            {
                Console.WriteLine("last number is greate than first number");
             }
            Console.ReadLine();
        }
    }
}
