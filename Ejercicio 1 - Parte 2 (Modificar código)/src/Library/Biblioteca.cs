using System;
using System.Collections.Generic;

namespace SRP
{   
    // El método VerBiblioteca se utiliza para verificar que el código funciona correctamente en Program.cs
    public class Biblioteca
    {
        public List<Tuple<Libro, string, string>> UbicacionLibros = new List<Tuple<Libro, string, string>>();

        public Biblioteca()
        {
            this.UbicacionLibros = UbicacionLibros;
        }

        public void AlmacenarLibro(Libro libro, string sector, string estante)
        {
            var ubicacion = new Tuple<Libro, string, string>(libro, sector, estante);
            this.UbicacionLibros.Add(ubicacion);
        }
        
        public void VerBiblioteca()
        {
                Console.WriteLine("Biblioteca: \n{");
                foreach(Tuple<Libro, string, string> tuplaLibro in this.UbicacionLibros)
                {
                    Console.WriteLine($"Titulo = {tuplaLibro.Item1.Titulo}\nSector = {tuplaLibro.Item2}\n"+
                    $"Estante = {tuplaLibro.Item3}\n");
                }
                Console.WriteLine("}");
        }
    }
}