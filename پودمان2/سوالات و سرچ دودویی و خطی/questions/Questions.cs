using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 1, 1, 2, 3, 4, 1 };
            int key = 1;
            /* LastIndexOf*/
            /*for (int i = test.Length - 1; i >= 0; i--)
            {
                if (key == test[i])
                {
                    Console.WriteLine("the key is {0} and index is {1}", test[i], i);
                    break;
                }
            }*/

            /* Index OF*/
            /*for (int i = 0; i < test.Length; i++)
            {
                if (key == test[i])
                {
                    Console.WriteLine("the key is {0} and index is {1}", test[i], i);
                    break;
                }
            }*/


            /*Binery search*/

            /*int[] name = { 5, 10, 15, 20, 25 };
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
            }*/

            /* Reverse */

            int[] array = { 1, 2, 3, 4, 5 };


            int length = array.Length;


            for (int i = 0; i < length / 2; i++)
            {

                int temp = array[i];
                array[i] = array[length - i - 1];
                array[length - i - 1] = temp;
            }


            Console.WriteLine("The reversed array is:");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
        }

    }
}
