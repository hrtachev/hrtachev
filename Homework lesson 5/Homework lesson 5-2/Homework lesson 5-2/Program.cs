using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_lesson_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 200; i++)
            {
                if (i % 3 == 1 && i % 7 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
