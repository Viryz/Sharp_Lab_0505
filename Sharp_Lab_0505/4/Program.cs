using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();
            Console.WriteLine("Count of words: {0}", str.Split(new[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries).Length);
            Console.ReadLine();
        }
    }
}
