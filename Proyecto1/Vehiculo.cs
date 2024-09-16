using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    public class Vehiculo
    {
        public int FechaFabricacion { get; set; }
        public string Marca { get; set; }
        public string Combustible { get; set; }

        public Vehiculo(int fecha, string marca, string combustible)
        {
            FechaFabricacion = fecha;
            Marca = marca;
            Combustible = combustible;
        }


        public void Arrancar()
        {
            Console.WriteLine("Vehiculo Encendido");
        }
    }


}
