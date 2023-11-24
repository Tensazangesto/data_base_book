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
            Console.WriteLine("Welcome");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("1) Setting");
            Console.WriteLine("2) Show");
            Console.WriteLine("3) Exit");
            Console.WriteLine("-----------------------------------------------");
            int x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                Console.WriteLine("Setting");
                Console.WriteLine("*****************");
                Console.WriteLine("mazrab che addy?");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("how many?");
                int b = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("please enetr number two for show: ");
                int take = int.Parse(Console.ReadLine());
                if (take == 2)
                {
                    for (int i = 1; i <= num; i++)
                    {
                        Console.WriteLine(a * b);
                    }
                }
                else
                {
                    Console.Clear();  
                }

 
            }
            
            
  
        }
    }
}
