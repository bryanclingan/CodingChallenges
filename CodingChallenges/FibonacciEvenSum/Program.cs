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
            long x=1;
            long y=2;
            long z =1 ;
            
            List<long> evenFibonacci = new List<long>() { 2 };
            while (z<4000000)
            {
                z = x + y;
                if (z%2== 0)
                {
                    evenFibonacci.Add(z);
                }
                x = y;
                y = z;
            }
            Console.WriteLine(String.Join(" ", evenFibonacci));
            long evenFibonacciSum = evenFibonacci.Sum();
            Console.WriteLine(evenFibonacciSum);
        }
    }
}
