using System;

namespace SRP
{   
    // El método VerLibro se utiliza para verificar que el código funciona correctamente en Program.cs
    public class Libro
    {
        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }
        
        public void VerLibro()
        {
            Console.WriteLine($"Título = {this.Titulo}\nAutor = {this.Autor}\nCodigo = {this.Codigo}");
        }
    }
}
