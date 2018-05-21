using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 5, M = 5;
            Random r = new Random();
            int[] arr1 = new int[N];
            int[] arr2 = new int[M];
            for (int i = 0; i < N; i++)
            {
                Console.Write("Enter number for first array: ");
                arr1[i] = int.Parse(Console.ReadLine());
                Console.Write("Enter number for second array: ");
                arr2[i] = int.Parse(Console.ReadLine());
            }
            IEnumerable<int> arr = arr1.Intersect(arr2);
            foreach (int item in arr)
                Console.Write(item.ToString() + " ");
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
