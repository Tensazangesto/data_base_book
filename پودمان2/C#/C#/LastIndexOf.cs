using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lastindexof
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 0, 1, 2, 1, 5, 2 };
            int key = 2;
            for (int i = test.Length - 1; i >= 0 ; i--)
            {
                if (test[i] == key )
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
