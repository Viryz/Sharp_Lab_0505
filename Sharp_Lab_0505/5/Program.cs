using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[,] arr1 = new int[5, 5];
            int[] arr2 = new int[5 * 5];
            for (int i = 0, k = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++, k++)
                {
                    arr1[i, j] = r.Next(-100, 100);
                    arr2[k] = arr1[i, j];
                    Console.Write(arr1[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int sum = 0;
            Array.Sort(arr2);
            foreach (int item in arr2)
                sum += item;
            Console.WriteLine("Sum: {0}", sum);
            Console.ReadLine();
        }
    }
}
