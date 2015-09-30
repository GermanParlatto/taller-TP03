using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
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

            
            Perro c = new Perro();
            veterinaria.AceptarAnimal(c);

            veterinaria.HacerRuidos();

            

        }
    }
}
