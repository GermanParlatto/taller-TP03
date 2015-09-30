using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    /// <summary>
    /// permite evaluar el prestamo por cuotas
    /// </summary>
    public class EvaluadorCantidadDeCuotas : IEvaluador
    {
        /// <summary>
        /// reprecenta las cuotas que puede tener como maximo
        /// un determinado prestamo
        /// </summary>
        private int iCantidadMaximaCuotas;

        /// <summary>
        /// verifica si el prestamo es viable dependiendo de
        /// la cantidad de cuotas solicitadas
        /// </summary>
        /// <param name="pPrestamo"></param>
        /// <returns></returns>
        public bool EsValida(SolicitudPrestamo pPrestamo)
        {
            if (pPrestamo.CantidadCuotas <= iCantidadMaximaCuotas) return true;
            else return false;
        }

        public  EvaluadorCantidadDeCuotas( int pCantidadMaxima) { this.iCantidadMaximaCuotas = pCantidadMaxima; }
    }
}
