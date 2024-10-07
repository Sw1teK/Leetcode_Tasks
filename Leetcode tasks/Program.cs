using System;
using System.Security.Authentication.ExtendedProtection;

namespace Leetcode_tasks
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[7];
            int k = 1;
            Console.Write("Введите число: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            
            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = i;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[minIndex] > array[j])
                    {
                        minIndex = j;
                    }
                }

                int f = array[i];
                array[i] = array[minIndex];
                array[minIndex] = f;

            }
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] != array[i + 1])
                {
                    k++;
                }
            }

            Console.WriteLine(k);    
        }
      
    }
}