using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fistNumber = 2;
            int secondNumber = 3;

            int @class = 1;
            var sub = 7;

            int answer;

            string prompt = ". Press ENTER when ready";

            Console.WriteLine("Think of a number between 1 and 10" + prompt);
            Console.ReadKey();
            Console.WriteLine("Multiply your number by " + fistNumber + prompt);
            Console.ReadKey();
            Console.WriteLine("Now multiply the result by " + secondNumber + prompt);
            Console.ReadKey();
            Console.WriteLine("Divide the result by the number you originally thought of" + prompt);
            Console.ReadKey();
            Console.WriteLine("Now subtract " + sub + prompt);
            Console.ReadKey();


        }
    }
}
