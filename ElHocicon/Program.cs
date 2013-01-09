using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElHocicon
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = args[0];
           //var folder = @"C:\Users\spola.VMK\Documents\Visual Studio 2012\Projects\ElHocicon\ElHocicon.Test\data";

            foreach (var f in Directory.EnumerateFiles(folder))
            {
                new Procesador(f).Run();
            }
                
        }
    }
}
