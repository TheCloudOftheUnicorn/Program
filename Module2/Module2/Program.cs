using System;
using System.Collections;
using System.Collections.Generic;

namespace Module2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("If you want stop click on Escape+Enter!" + "Enter text:\n");
                List<string> lineCollection = new List<string>();

                LineProcessing lProc = new LineProcessing();

                lProc.EnterConsole();

                Console.WriteLine("Collections of the first letter from your text:");
                lProc.GetLetters(lineCollection);
                Console.ReadLine();
            }
        }
               
    }
}
