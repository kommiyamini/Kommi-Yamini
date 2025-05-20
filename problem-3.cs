using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equivalent_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            if(a % 2 == 0)
            {
                a -= 1;
            }
            for (int i = 0; i < a; i++)
            {
                int oddNumber = 2 * i + 1;
                if (i != a - 1)
                {
                    Console.Write(" , ");
                }
            }

            Console.WriteLine();
        }
    }
}
