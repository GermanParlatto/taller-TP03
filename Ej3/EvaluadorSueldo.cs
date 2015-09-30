using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    /// <summary>
    /// permite determinar si un presta es viable dependiendo
    /// del salario del cliente
    /// </summary>
   public class EvaluadorSueldo: IEvaluador
    {
        private double iSueldoMinimo;

        public EvaluadorSueldo(double pSueldoMinimo) { this.iSueldoMinimo = pSueldoMinimo; }

        /// <summary>
        /// verifica que el salario del cliente sea como minimo el 
        /// especificado por el banco
        /// </summary>
        /// <param name="pPrestamo"></param>
        /// <returns></returns>
        public bool EsValida(SolicitudPrestamo pPrestamo)
        {
            if (pPrestamo.Clietne.Empleo.Sueldo >= this.iSueldoMinimo) return true;
            else return false;
        }
    }
}
