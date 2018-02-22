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
            string t = @"isto é uma string verbatim posso usar / sem chatiçes ";
            string v = "\" \u00A9\"";
            string x = "gosto " + "de " + "gelado";
            x += " no verao";
            string j = $"{5} mais {3} e {5 + 3} ";
            string u = $@"string verbatim e interpolada / {7}";
            Console.WriteLine(j);
            Console.WriteLine(u);
            Console.WriteLine(s);
            Console.WriteLine(t);
            Console.WriteLine(v);
            Console.WriteLine(x);
            Console.ReadKey();
            Convert.to
        }
    }
}
