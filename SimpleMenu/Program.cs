using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please choose one of the following options: ");
            Console.WriteLine("1 - Cappuccino");
            Console.WriteLine("2 - Latte");
            Console.WriteLine("3 - Espresso");
            Console.WriteLine("4 - Americano");
            Console.WriteLine("5 - Mocha");
            Console.WriteLine("6 - Macchiato");
            Console.WriteLine("Q - Quit");

            ConsoleKeyInfo userChoice = Console.ReadKey(true);
            Console.WriteLine("You chose: " + userChoice);

            var x = userChoice.Key;
            char y = userChoice.KeyChar;
            var z = userChoice.Modifiers;
            Console.WriteLine("Key: " + x);
            Console.WriteLine("KeyChar: " + y);
            Console.WriteLine("keyModifier: " + z);

        }
    }
}
