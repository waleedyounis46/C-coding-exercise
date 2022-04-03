using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size of int:{0}", sizeof(int));
            Console.WriteLine("Size of long:{0}", sizeof(long));
            Console.WriteLine("Size of double:{0}", sizeof(double));
            Console.WriteLine("size of boolean):{0}", sizeof(bool));
            Console.WriteLine("Size of char: {0}", sizeof(char));
            Console.WriteLine("size of byte: {0}", sizeof(byte));
            Console.ReadLine();
        }
    }
}
