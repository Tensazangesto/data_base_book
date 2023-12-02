using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter space of memory : ");
            int arrmemory = int.Parse(Console.ReadLine());
            int[] name = new int [arrmemory];
            Console.Write("please enter key you want to search : ");
            int key = int.Parse(Console.ReadLine());
            for (int i = 0; i < arrmemory; i++)
            {
                Console.Write("please enter number to add in the index {0}: ", name[i]);
                
                name[i] = int.Parse(Console.ReadLine());
            }
            for (int counter = 0; counter < name.Length; counter++)
            {
                if (name[counter] == key)
                {
                    Console.WriteLine("key : {0}, index of key: {1}",name[counter], counter);
                }
            }
        }
    }
}
