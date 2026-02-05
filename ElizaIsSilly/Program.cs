using System;
using System.Collections.Generic;
using System.Text;

namespace ElizaIsSilly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Doctor.Intro());

            var userInput = "";
            userInput = Console.ReadLine();


            while (!userInput.Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                
                userInput = Console.ReadLine();
                String response = Doctor.Response(userInput);
                Console.WriteLine(response);
            }
        }
    }
}
