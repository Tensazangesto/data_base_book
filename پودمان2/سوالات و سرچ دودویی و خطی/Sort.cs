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
            int n = 5;
            int i, j;
            Console.WriteLine("please enter number of index");
            int numberindex = int.Parse(Console.ReadLine());
            int[] name = new int[numberindex];
            for (int o = 0; o < numberindex; o++)
            {
                Console.WriteLine("enter the object: ");
                name[o] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("the arr without sort = " + string.Join(", ", name));


            for (i = 0; i < n - 1; i++)
            {
                for (j = 0; j < n - i - 1; j++)
                {
                    if (name[j] > name[j + 1])
                    {
                        change = name[j];
                        name[j] = name[j + 1];
                        name[j + 1] = change;
                    }

                }

            }
            Console.WriteLine(string.Join(", ", name));

        }




    }
}

