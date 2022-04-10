using System;

namespace SRP
{
    /* 
      La clase Libro no cumple con el principio SRP, ya que tiene tanto la responsabilidad de conocer los atributos 
      del libro, como de almacenar en el sector y estante correspondiente. 
      Decidimos crear una nueva clase llamada Biblioteca, donde ingresamos los libros que son creados, 
      indicando el sector y el estante.
    */
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}