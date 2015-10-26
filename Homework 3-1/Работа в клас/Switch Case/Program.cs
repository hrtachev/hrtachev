using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a letter or string");
            string str = Console.ReadLine();
            switch (str)
            {
                case "a":
                    int nn = int.Parse(Console.ReadLine());
                    nn++;
                    Console.WriteLine(nn);
                    break;

                case "b":
                    double bb = double.Parse(Console.ReadLine());
                    bb++;
                    Console.WriteLine(bb);
                    break;

                case "c":
                    string 
                default:
                    break

            }
        }
    }
}
