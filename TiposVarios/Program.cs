using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Isto e uma string normal";
            string t = @"isto éuma string verbatim posso usar / sem chatiçes ";
            string v = "\" \u00A9\"";
           Console.WriteLine(s);
            Console.WriteLine(t);
            Console.WriteLine(v);
            Console.ReadKey();
        }
    }
}
