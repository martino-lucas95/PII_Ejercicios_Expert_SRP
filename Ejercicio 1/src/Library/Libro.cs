using System;

namespace SRP
{   
    // Los comentarios fueron realizados en el archivo Program.cs
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
