using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            while (true)
            {
                int i = int.Parse(Console.ReadLine());
                if (i == 15)
                {
                    break;
                }
                else if (i > 40)
                {
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine(number);
        }
    }
}
