using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    /// <summary>
    /// Representa el genero Animal
    /// </summary>
    public abstract class Animal
    {
        /// <summary>
        /// Imprime por pantalla la "Corriendo"
        /// </summary>
        public void Correr()
        {
            Console.WriteLine("Corriendo");
            Console.ReadKey();    
        }

        /// <summary>
        /// Imprime por pantalla "Saltando"
        /// </summary>
        public void Saltar()
        {
            Console.WriteLine("Saltando");
            Console.ReadKey();
        }

        /// <summary>
        /// Es un metodo abstracto que dependiendo del 
        /// animal q se implemente, mostrara por pantalla 
        /// el ruido de dicho animal
        /// </summary>
        public abstract void HacerRuido();
    }
}
