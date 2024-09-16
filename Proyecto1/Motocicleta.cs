using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    public class Motocicleta : Vehiculo
    {
        public Motocicleta(int fecha, string marca, string combustible) : base(fecha, marca, combustible)
        {

        }

        //Atributos

        public bool EsAutomatica { get; set; }
        public void LavarMotocicleta()
        {
            Console.WriteLine("Lavar Motocicleta");
        }

        public void Arrancar()
        {
            Console.WriteLine("Arrancando Motocicleta");
        }
    }
}
