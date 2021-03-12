using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCollatz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> listOfLists = new List<List<int>>();
            int x;
            for (int i = 2; i < 1000; i++)
            {
                List<int> list = new List<int>();
                x = i;
                list.Add(x);
                do
                {
                    if (x % 2 == 0)
                    {
                        x = x / 2;
                        list.Add(x);
                    }
                    else
                    {
                        x = (3 * x) + 1;
                        list.Add(x);
                    }

                } while (x != 1);
                listOfLists.Add(list);
                
            }

            int max = listOfLists.Max(l => l.Count);
            
            //Console.WriteLine(max);
            
            List<int> longestList = listOfLists.Find(l => l.Count == max);

            Console.WriteLine(String.Join("\n", longestList));
            Console.WriteLine($"Length Of Chain: {longestList.Count}");
            //Console.WriteLine(listOfLists.Count);


        } 
    }
}
