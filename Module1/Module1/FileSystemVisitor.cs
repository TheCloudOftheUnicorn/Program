using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Module1
{
    public class FileSystemVisitor
    {
        public delegate IEnumerable Algorithm(string path, string searchParameter);
        public Algorithm _method;

        public FileSystemVisitor(Algorithm method)
        {
            _method = method;
        }

        public static IEnumerable GetAllDirectionsAndFilesForSearchParameter(string path, string searchParameter)
        {
            foreach (var directory in Directory.EnumerateDirectories(path, searchParameter, SearchOption.AllDirectories))
            {
                yield return directory;
                foreach (var files in Directory.EnumerateFiles(path, searchParameter, SearchOption.AllDirectories))
                {
                    yield return files;
                }                
            }
        }        
    }
}
