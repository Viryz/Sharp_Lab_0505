using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                {
                    Console.WriteLine("No");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Yes");
            Console.ReadLine();
        }
    }
}
