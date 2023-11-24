using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int gad = int.Parse(Console.ReadLine());

            if (gad >= 180)
            {
                Console.WriteLine("you are tall");

            }
            else if (gad <= 150)
            {
                Console.WriteLine("you are short");

            }
            else 
            {
                Console.WriteLine("average");
            }
        }
    }
}
