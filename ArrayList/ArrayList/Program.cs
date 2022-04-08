using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Numbers = new List<int>();
            Random r = new Random();
            for (int i = 0; i < Numbers.Count; i++)
            {
                int num = r.Next(0,100);
                Numbers.Add(num);
            }
            foreach (var number in Numbers)
            {
                Console.WriteLine(number+ "");
                Console.WriteLine("Average of random number is: {0}", Numbers.Average());
                Numbers.Insert(10 , 0);
                var index = Numbers.IndexOf(0);
                Console.WriteLine("index of position 0 is : {0}", index);

                var count = Numbers.Count();
                Console.WriteLine("------------");
                Console.WriteLine("Collection using list of objects");
                var Students = new List<Person>
                {
                    new Person(){FirsName="Joe", LastName="Blogs", age=23},
                    new Person(){FirstName="Steve", LastName="May", age=22},
                    new Person(){FirstName="Jack", LastName="Jones", age=24},
                    new Person(){FirstName="Tom", LastName="Jones", age=23}

                };
                Console.WriteLine("numbe of objects is: {0}", Students.Count());
                foreach (var student in Students)
                {
                    Console.WriteLine(student.FirstName);
                    Console.WriteLine(student.LastName);
                    Console.WriteLine(student.age);
                    Console.WriteLine("--------------------");

                }
                Console.ReadLine();

            }

        }
    }
}
