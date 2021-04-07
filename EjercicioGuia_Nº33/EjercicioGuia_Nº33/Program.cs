using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGuia_Nº33
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libros = new Libro();
            libros[0] = "Pepito la galletita";
            libros[1] = "Bizcochitos con mate";
            Console.WriteLine(libros[0]);
            Console.WriteLine(libros[1]);
            libros[0] = "Tortafritas";
            Console.WriteLine(libros[0]);
            Console.ReadLine();
        }
    }
}
