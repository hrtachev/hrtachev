using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;

            for (int i = 1; i < 100; i++)
            {
                if (i <= n)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
