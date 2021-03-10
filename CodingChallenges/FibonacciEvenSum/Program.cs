using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {

            /*By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.*/
            long x =1;
            long y=2;
            long z =1 ;
            
            List<long> evenFibonacci = new List<long>() { 2 };
            do
            {
                z = x + y;
                if (z % 2 == 0)
                {
                    evenFibonacci.Add(z);
                }
                x = y;
                y = z;
            } while (z < 4000000);
            Console.WriteLine(String.Join(" ", evenFibonacci));
            
            Console.WriteLine(evenFibonacci.Sum());
        }
    }
}
