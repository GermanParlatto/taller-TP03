using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            Veterinaria veterinaria = new Veterinaria();

            Perro a = new Perro();
            veterinaria.AceptarAnimal(a);

            Gato b = new Gato();
            veterinaria.AceptarAnimal(b);


            Vaca c = new Vaca();
            veterinaria.AceptarAnimal(c);

            Gallo d = new Gallo();
            veterinaria.AceptarAnimal(d);

            Pollito e = new Pollito();
            veterinaria.AceptarAnimal(e);


            veterinaria.HacerRuidos();
        }
    }
}
