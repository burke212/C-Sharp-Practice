using System;
using System.Collections.Generic;
using System.Linq;

namespace input
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize variables.
            List<string> letters = new List<string>();// Hold all letters.
            
            // Read in input. 
            ReadInput(ref letters);

            Console.WriteLine("The letters are:");

            // Print input.
            PrintInput(ref letters);

            Console.WriteLine("The reverse is:");

            ReverseInput(ref letters);

        }

        // Print the letters in reverse order.
        public static void ReverseInput(ref List<string> letters)
        {
            for (int i = 2; i >= 0; i--)
            {
                Console.WriteLine("{0}", letters[i]);
            }
        }

        // Print the 3 letters. 
        public static void PrintInput(ref List<string> letters)
        {
            for (int i = 0; i < (letters.Count() - 1); i++)
            {
                Console.WriteLine("{0}", letters[i]);
            }
        }

        // Recieve n letters from user, then adds to lst.
        // *** instead of collecting individual letters, just get them as a sentence then add to LIST as letters***
        public static void ReadInput(ref List<string> lst)
        {
            while (Console.ReadLine() != "0")
            {
                lst.Add(Console.ReadLine());
            }
        }

    }
}
