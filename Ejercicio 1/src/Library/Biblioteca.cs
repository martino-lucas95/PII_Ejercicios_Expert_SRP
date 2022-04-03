using System;

namespace SRP
{
    public class Biblioteca
    {
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
