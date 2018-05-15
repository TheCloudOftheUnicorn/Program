using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2._2;
using System.Text.RegularExpressions;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string str = Console.ReadLine();

                try
                {
                    Console.WriteLine("{0}", str.ConvertStringToInt());
                }
                catch (OverflowException e) { Console.WriteLine("Ошибка: " + e.Message); }
                catch (ArgumentException e) { Console.WriteLine("Ошибка: " + e.Message); }
            }
            Console.ReadLine();
        }
    }
}
