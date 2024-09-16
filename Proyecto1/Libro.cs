using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    public class Libro
    {
        //Atributos 
        private string Titulo { get; set; }
        public string Autor { get; set; }
        public int NumeroPaginas { get; set; }
        public int FechaPublicacion { get; set; }

        //Constructor


        public Libro(string titulo, string autor, int fecha, int paginas)
        {
            Titulo = titulo;
            Autor = autor;
            NumeroPaginas = paginas;
            FechaPublicacion = fecha;


        }public Libro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }

        //Metodos

        public void MostrarInformacion() 
        {
            Console.WriteLine("Titulo: " + Titulo);
            Console.WriteLine($"Autor: {Autor} " );
            Console.WriteLine($"Paginas: {NumeroPaginas} " );
            Console.WriteLine($"Fecha de Publicacion: {FechaPublicacion} " );
        
        }

        public string Disponibilidad() 
        {
            return "Libro Disponible para alquiler";
        }

    }
}
