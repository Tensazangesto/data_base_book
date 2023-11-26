using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            int change;
            int[] name = { 5, 14, 3, 2, 1 };
            int n = 5;
            int i, j;
            for ( i = 0; i < n-1; i++)
            {
                for (j = 0; j < n-i-1; j++)
                {
                    if (name[j] > name[j + 1])
                    {
                        change = name[j];
                        name[j] = name[j +1];
                        name[j + 1] = change;
                    }

                }
               
            }
            Console.WriteLine(string.Join(", ", name));

        }

            

         
    }
}
