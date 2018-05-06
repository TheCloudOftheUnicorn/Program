using System;
using System.Collections;
using System.Collections.Generic;

namespace Module2
{
    public class LineProcessing
    {
        private List<string> _lines;
        private ConsoleKeyInfo keyKode;

        public LineProcessing()
        {
            _lines = new List<string>();
        }

        public void EnterConsole()
        {
            while (true)
            { 
                keyKode = Console.ReadKey(true);
                Console.Out.NewLine = "\n";
                keyKode.Key != ConsoleKey.Escape ? _lines.Add(Console.ReadLine()) :  break ;
            } 
        }

        public void GetLetters(List<string> lines)
        {
            foreach (var item in _lines)
            {
               Console.WriteLine(item[0]);
            }
        }
    }
}
