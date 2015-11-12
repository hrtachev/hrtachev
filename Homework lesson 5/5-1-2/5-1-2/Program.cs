using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;


            while (true)
            {
                int x = int.Parse(Console.ReadLine());
                if (x <= 25)
                {
                    Console.WriteLine("wrong number");
                }
                else if (x == 25 || x <= 49)
                {
                    Console.WriteLine("Push the buton again");
                }
                else if (x == 50 || x >= 55)
                {
                    Console.WriteLine("you win");
                }
            }
        }
    }
}
