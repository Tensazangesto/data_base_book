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
            // create a variable
            int a = 0;
            int b = 0;
            int x = 0;
            // create a "for" for run Script 
            for (int i = 0; ; i++)
            {
                //Welcom page
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Welcome");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("1) Setting");
                Console.WriteLine("2) Show");
                Console.WriteLine("3) Exit");
                Console.WriteLine("-----------------------------------------------");
                x = int.Parse(Console.ReadLine());
                // create a "if" for setting
                if (x == 1)
                {
                    // Setting of first "if" Setting menu
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Setting");
                    Console.WriteLine("*****************");
                    Console.WriteLine("mazrab che addy?");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("how many?");
                    b = int.Parse(Console.ReadLine());
                    Console.Clear();


                }
                // create a "eles if" for Show menu
                else if (x == 2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Clear();
                    Console.WriteLine("show");
                    Console.WriteLine("*****************");
                    Console.WriteLine("please enetr number 2 for show: ");
                    int take = int.Parse(Console.ReadLine());
                    if (take == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        for (int mt = 0; mt < b; mt++)
                        {
                            Console.WriteLine("******************** ");
                            Console.WriteLine(mt * a);
                        }
                        Console.ReadKey();
                    }
                    else if (take != 2)
                        {
                            Console.WriteLine("there is nothing i can do");
                        }
                    Console.Clear();
                }
                // ceate another "eles if" for Exit menu
                else if (x == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("EXIT");
                    Console.WriteLine("*****************");
                    break;
                }
                else if (x == null)
                {
                    Console.Clear();
                    Console.WriteLine("please enter num");
                }


            }
        }
    }
}
