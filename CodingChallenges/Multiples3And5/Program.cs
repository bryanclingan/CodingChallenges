using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             If we list all the natural numbers below 10
             that are multiples of 3 or 5, we get 3, 5,
             6 and 9. The sum of these multiples is 23.

          Find the sum of all the multiples of 3 or 5 below 1000 and print it out to the console.
             */

            List<int> multiple3s = new List<int> { };
            
            for (int i = 0; i <= 1000; i++)
            {
                int multiple3 = i * 3;
                if (multiple3 <=1000)
                {
                    multiple3s.Add(multiple3);
                }
            }
            List<int> multiple5s = new List<int> { };
            for (int i = 0; i <= 1000; i++)
            {
                int multiple5 = i * 5;
                if (multiple5 <= 1000)
                {
                    multiple5s.Add(multiple5);
                }
            }
            //Console.WriteLine(String.Join("\n",multiple3s)); //- used for testing
            //Console.WriteLine(String.Join("\n", multiple5s)); //- used for testing
            List<int> mult5and3 = multiple3s.Union(multiple5s).ToList();
            mult5and3.Sort();
            Console.WriteLine(String.Join(" ", mult5and3));
           int total = mult5and3.Sum();
            
            Console.WriteLine(total);


            //Below is a classmates code that I really liked as well not my own code but I wanted to have it here as a reference to show a different way to do this Challenge
            //int multiples5and3 = 0;
            //for (int i = 1; i <= 1000; i++)
            //{
            //    int three = i % 3;
            //    int five = i % 5;
            //    if (three== 0 || five==0)
            //    {
            //        Console.WriteLine($"{i}");
            //        multiples5and3 = multiples5and3 + i;
            //    }
            //}

            //Console.WriteLine(multiples5and3);

        }
    }
}
