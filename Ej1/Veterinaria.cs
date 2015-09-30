using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    /// <summary>
    /// Representa el lugar que contiene a todos los distintos 
    /// animales PERRO, GATO
    /// </summary>
    public class Veterinaria
    {
        /// <summary>
        /// lista de animales
        /// </summary>
        private Animal[] iAnimales = new Animal[4];

        /// <summary>
        /// atributo para saber la cantidad de animales de la lista
        /// </summary>
        private int tamaño = 0;

        /// <summary>
        /// Permite agregar un animal a la lista de animales
        /// </summary>
        /// <param name="pAnimal"></param>
        public void AceptarAnimal(Animal pAnimal)
        {
            //se controla que la lista de animales no este llena
            if (tamaño < 4)
            {
                if ((tamaño == 0) && (this.iAnimales[0]==null))
                {
                    this.iAnimales[this.tamaño] = pAnimal;
                    

                } else
                {
                    this.tamaño++;
                    this.iAnimales[this.tamaño] = pAnimal;
                }
                
            }
        }

        /// <summary>
        /// permite iterer la lista de animales 
        /// pasandole el mensaje hacer ruido a cada instacia que contiene
        /// </summary>
        public void HacerRuidos()
        {
            for (int i = 0; i <= this.tamaño; i++)
            {
                this.iAnimales[i].HacerRuido();
            }
        }


    }
}
