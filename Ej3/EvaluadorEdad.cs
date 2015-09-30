using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    /// <summary>
    /// permite evaluar si un prestamo es viable 
    /// dependiendo de la edad
    /// </summary>
    public class EvaluadorEdad : IEvaluador
    {
        private int iEdadMinima, iEdadMaxima;

        /// <summary>
        /// valida si la edad del cliente se encuentra entre 
        /// los Rangos de edadMinima y edadMaima
        /// </summary>
        /// <param name="pPrestamo"></param>
        /// <returns></returns>
        public bool EsValida(SolicitudPrestamo pPrestamo)
        {
            //las 3 siguientes permite calcular la edad de la persona que solicita el prestamo
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - pPrestamo.Clietne.FechaNacimiento.Year;
            if (fechaActual < pPrestamo.Clietne.FechaNacimiento.AddYears(edad)) edad--;

            if ((edad > this.iEdadMinima)&& (edad < this.iEdadMaxima)) return true;
            else return false;
        }

        /// <summary>
        /// representa un objeto que evaluara si la solicitud de prestamo es viable
        /// dependiendo la edad de la persona
        /// </summary>
        /// <param name="pEdadMinima">Edad Minima para solicitar prestamo</param>
        /// <param name="pEdadMaxima">Edad Maxima para solicitar prestamo</param>
        public EvaluadorEdad (int pEdadMinima, int pEdadMaxima)
        {
            this.iEdadMinima = pEdadMinima;
            this.iEdadMaxima = pEdadMaxima;
        }
    }
}
