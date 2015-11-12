using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1
{
    class Program
    {
        static void Main(string[] args)

        {
            int[] arr = new int[10];
            int min = int.MaxValue;
            int max = int.MinValue;


            Console.WriteLine("Enter the number:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (max < arr[1])
                    {
                        Console.WriteLine(i);
                    }
                    else if (i % 2 == 1)
                    {
                        if (i % 2 == 1)
                        {
                            if (min < arr[1])
                            {
                                Console.WriteLine(i);
                            }
                        }
                    }
                }

            }
        }
    }
