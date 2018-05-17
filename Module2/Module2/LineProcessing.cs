using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Module2
{
    public class LineProcessing
    {
        private List<string> _lines;
        private ConsoleKeyInfo keyKode;
        bool _flag;

        public LineProcessing()
        {
            _lines = new List<string>();
        }

        public void EnterConsole()
        {
            _flag = true;            
            while (_flag)
            { 
                keyKode = Console.ReadKey(true);
                Console.Out.NewLine = "\n";
                //what the fucking operator
                //(keyKode.Key != ConsoleKey.Escape) ? (_lines.Add(Console.ReadLine())) :( _flag = false) ;
                if (keyKode.Key != ConsoleKey.Escape)
                {
                    try
                    {
                        _lines.Add(Console.ReadLine());
                    }
                    catch { throw new NullReferenceException("Ссылка пуста!"); }
                }
                else {
                    _flag = false;
                }
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
