using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program  
    {
        static void Main(string[] args)
        {
            int[] name = { 5, 10, 15, 20, 25 };
            int min = 0;
            int max = name.Length - 1;
            int mid = (max - min) / 2;

            Console.Write("Enter the key: ");
            int key = int.Parse(Console.ReadLine());
            bool is_ok = false;
            if (name[max] == key) { Console.WriteLine("index of key: " + max); }
            else if (name[min] == key) { Console.WriteLine("index of key: " + min); }
            else
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (name[i] == key) { is_ok = true; };
                }
                while (is_ok)
                {
                    if (name[mid] < key)
                    {
                        min = mid;
                        mid = mid + (max - min) - 1;
                    }
                    else if (name[mid] > key)
                    {
                        max = mid;
                        mid = mid - (max - min) + 1;
                    }
                    else if (name[mid] == key)
                    {
                        Console.WriteLine("index of key: " + mid);
                        break;
                    }

                }
                if (!is_ok)
                {
                    Console.WriteLine("Not found");
                }
            }
            
        }
    }
}
