using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
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
        private Animal[] iAnimales ;

        /// <summary>
        /// atributo para saber la cantidad de animales de la lista
        /// </summary>
        private int iTamano;

       
       


        public Veterinaria()
        {
            iAnimales = new Animal[6];
            iTamano = 0;
        }

        /// <summary>
        /// Permite agregar un animal a la lista de animales
        /// </summary>
        /// <param name="pAnimal"></param>
        public void AceptarAnimal(Animal pAnimal)
        {
            //se controla que la lista de animales no este llena
            if (this.iTamano < 4)
            {
                if ((this.iTamano == 0) && (this.iAnimales[0] == null))
                {
                    this.iAnimales[this.iTamano] = pAnimal;


                }
                else
                {
                    this.iTamano++;
                    this.iAnimales[this.iTamano] = pAnimal;
                }

            }
        }

        /// <summary>
        /// permite iterer la lista de animales 
        /// pasandole el mensaje hacer ruido a cada instacia que contiene
        /// </summary>
        public void HacerRuidos()
        {
            for (int i = 0; i <= this.iTamano; i++)
            {
                this.iAnimales[i].HacerRuido();
            }
        }


    }
}
