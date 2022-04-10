using System;
using System.Collections.Generic;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");
            libro1.VerLibro();
            
            Console.WriteLine();

            Biblioteca BibliotecaUcu = new Biblioteca();
            BibliotecaUcu.AlmacenarLibro(libro1, "Programación", "Diseño");
            BibliotecaUcu.AlmacenarLibro(libro2, "Programación", "Lenguajes");
            BibliotecaUcu.VerBiblioteca();
        }
    }
}
