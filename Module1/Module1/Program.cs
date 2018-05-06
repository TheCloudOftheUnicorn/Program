using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Module1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your path:");
            string path = @"E:\Music";

            string searchParameter = "*";

            FileSystemVisitor visitor = new FileSystemVisitor(new FileSystemVisitor.Algorithm(FileSystemVisitor.GetAllDirectionsAndFilesForSearchParameter));
            
            foreach (var item in visitor._method.Invoke(path, searchParameter))
            {
                //Thread.Sleep(1000);
                Console.WriteLine("{0}", item);
            }

            Console.ReadLine();
        }
    }
}
