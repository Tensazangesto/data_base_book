using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            while (true)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("********* Welcom **********");
                    Console.WriteLine("Please enter number");
                    num[i] = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                Console.Clear();
                Console.WriteLine("index of what number?  ");
                int name = int.Parse(Console.ReadLine());
                Console.Clear();
                for (int t = 0; t < 5; t++)
                {
                    Console.WriteLine("tries: {0} , {1}", name, num[t]);


                    if (name == num[t])
                    {
                        Console.WriteLine("the index: {0}  Tries: {1}", num[t], t += 1);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
            }
	        

                
            }
        }
    }
}
