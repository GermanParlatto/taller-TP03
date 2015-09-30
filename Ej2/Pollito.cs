using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    public class Pollito : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("pio pio");
            Console.ReadKey();
        }
    }
}
