using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_lesson_5___1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 35; i++)
            {
                if (i == 25)
                {
                    break;
                }
                Console.Write(i);
                Console.WriteLine();
            }
        }
    }
}
