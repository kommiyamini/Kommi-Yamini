using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 8, 9, 12, 46, 76, 82, 15, 20, 30 };

            Dictionary<int, int> divisibleCounts = new Dictionary<int, int>();

            for (int i = 1; i <= 9; i++)
            {
                divisibleCounts[i] = 0;
            }
            foreach (int num in numbers)
            {
                for (int i = 1; i <= 9; i++)
                {
                    if (num % i == 0)
                    {
                        divisibleCounts[i]++;
                    }
                }
            }
            Console.WriteLine("{");
            foreach (var kvp in divisibleCounts)
            {
                Console.WriteLine($" {kvp.Key}: {kvp.Value},");
            }
            Console.WriteLine("}");
        }
    }
}
