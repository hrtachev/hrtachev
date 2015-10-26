using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упражнение_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string card = (Console.ReadLine());

            switch (card)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                    Console.WriteLine("Valid card");
                    break;

                case "J":
                case "K":
                    Console.WriteLine("Valid card");
                    break;

                default:
                    Console.WriteLine("Default");
                    break;

            }
        }
    }
}
