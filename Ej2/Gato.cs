﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    public class Gato:Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("Miauuuuu");
            Console.ReadKey();
        }
    }
}
