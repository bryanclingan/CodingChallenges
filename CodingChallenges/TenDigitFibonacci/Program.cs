using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenDigitFibonacci
{
    class Program
    {

        

        static void Main(string[] args)
        {
            /*
             What is the index of the first term in the Fibonacci sequence to contain 10 digits?
             1134903170
             */
            long x = 1;
            long y = 2;
            long z = 2;

            List<long> t = new List<long>();
            do
            {

                t.Add(z);

                z = x + y;
                x = y;
                y = z;
            } while (z < 90000000000);

            Console.WriteLine(String.Join(" ", t));
            
            //int indextendigit = t.FindIndex(h => h.ToString().Length == 10);
            Console.WriteLine("Index for first value that has 10 digits: "+ t.FindIndex(h => h.ToString().Length == 10));
            Console.WriteLine("First value that has 10 digits: "+t[t.FindIndex(h => h.ToString().Length== 10)]);
         
        }
        
    }
}
