using System;
using System.Collections.Generic;

namespace SRP
{
    /* 
    Concluimos en que la clase Libro no cumplía con el principio SRP, ya que tenía tanto la 
    responsabilidad de conocer los atributos del libro, como de almacenar en el sector y estante correspondiente. 
    Por lo tanto decidimos crear una nueva clase llamada Biblioteca, donde ingresamos los libros que son creados, 
    indicando el sector y el estante.
    --Los métodos VerBiblioteca y VerLibro los utilizamos para verificar que el código funciona correctamente--
    */
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
