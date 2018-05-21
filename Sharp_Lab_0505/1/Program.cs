using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] A = new float[5];
            float[,] B = new float[3, 4];
            try
            {
                for (int i = 0; i < A.Length; i++)
                {
                    Console.Write("Enter number: ");
                    A[i] = int.Parse(Console.ReadLine());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
                return;
            }

            int rows = B.GetUpperBound(0) + 1;
            int cols = B.Length / rows;
            float bMax = B[0, 0], bSum = 0, bProduct = 1, bSumCols = 0;
            Random r = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    B[i, j] = r.Next(1, 10);
                    if (bMax < B[i, j])
                        bMax = B[i, j];
                    bSum += B[i, j];
                    bProduct *= B[i, j];
                    if (j % 2 == 1)
                        bSumCols += B[i, j];
                    Console.Write("{0} \t", B[i,j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("A max: {0}", A.Max());
            Console.WriteLine("B max: {0}", bMax);
            Console.WriteLine("A sum: {0}", A.Sum());
            Console.WriteLine("B sum: {0}", bSum);
            Console.WriteLine("A sum (% 2 == 0): {0}", A.Where(i => i % 2 == 0).Sum());
            Console.WriteLine("B sum cols % 2 == 1: {0}", bSumCols);
            Console.ReadLine();
        }
    }
}
