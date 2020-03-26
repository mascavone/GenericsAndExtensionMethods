using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a sentence: ");
            String str = Console.ReadLine();
            int howManyWords = str.CountWorkdsInString();
            Console.WriteLine("How many words in this sentence? " + howManyWords);
            Console.ReadKey();
        }
    }
}
