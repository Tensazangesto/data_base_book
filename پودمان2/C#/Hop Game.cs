using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine("hop");
                    Console.Beep(700, 250);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
