using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    /// <summary>
    /// permite evaluar si un prestamo es viable 
    /// dependiendo del monto
    /// </summary>
    public class EvaluadorMonto:IEvaluador
    {
        private double iMontoMaximo;


        public EvaluadorMonto(double pMontoMaximo) { this.iMontoMaximo = pMontoMaximo; }


        /// <summary>
        /// devuelve verdadero si el monto del prestamo 
        /// no supera el Monto Maximo permitido
        /// </summary>
        /// <param name="pPrestamo"></param>
        /// <returns></returns>
        public  bool EsValida(SolicitudPrestamo pPrestamo)
        {
            if (pPrestamo.Monto <= this.iMontoMaximo) return true;
            else return false;
        }
    }
}
