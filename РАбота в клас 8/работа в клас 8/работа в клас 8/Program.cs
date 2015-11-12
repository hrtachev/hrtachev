using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace работа_в_клас_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 50;
            int b = 25;
            int c = Result(a, b);

            Console.WriteLine(c);
            
        }
        private static int Result(int a, int b)
        {
            int Result = a - b;
            return Result;
        }
    }
}
