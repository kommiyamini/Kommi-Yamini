using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumberSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Output: ");
            for (int i = 0; i < a; i++)
            {
                int oddNumber = 2 * i + 1;
                Console.Write(oddNumber);

                if (i != a - 1)
                    Console.Write(" , ");
            }
        }
    }
}
