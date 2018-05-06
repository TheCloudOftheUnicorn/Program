using System;
using System.Collections;
using System.Collections.Generic;

namespace Module2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text:\n"+"If you want stop click on Escape+Enter");
            List<string> lineCollection = new List<string>();

            LineProcessing lProc = new LineProcessing();

            lProc.EnterConsole();
            lProc.GetLetters(lineCollection);
            Console.ReadLine();
        }
               
    }
}
