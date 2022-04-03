using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine("Enter Positive Number");
            x=Convert.ToInt32(Console.ReadLine());
            if(x>=0)
            {
                switch(x)
                {
                    case 0:
                        Console.WriteLine("Value is zero");
                        break;
                     case 1:
                        Console.WriteLine("Value is one");
                        break ;
                     case 2:
                        Console.WriteLine("Value is two");
                        break;
                    case 3:
                        Console.WriteLine("Value is three");
                        break;
                    default:
                        Console.WriteLine("Value is greater than 3");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Value is negative");
            }
            Console.ReadLine();
         }
    }
}
