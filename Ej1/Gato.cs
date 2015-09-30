using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    /// <summary>
    /// Esta clase representa hereda de la clase abstracta Animal
    /// </summary>
    public class Gato : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("Miauuuuu");
            Console.ReadKey();
        }
    }
}
