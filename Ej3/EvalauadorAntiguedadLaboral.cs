using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    /// <summary>
    /// reprecenta el que evaluador del banco
    /// que se basa en la antiguedad de tabajo de la persona
    /// </summary>
    public class EvalauadorAntiguedadLaboral: IEvaluador
    {
        
        private int iAntiguedadMinima;

        /// <summary>
        /// permite validar por true o false dependiendo si
        /// el cliente tiene por lo menos la antiguedad minima requerida
        /// </summary>
        /// <param name="pPrestamo"></param>
        /// <returns></returns>
        public bool EsValida(SolicitudPrestamo pPrestamo)
        {
            DateTime fechaActual = DateTime.Today;
            if (fechaActual.Year == pPrestamo.Clietne.Empleo.FechaIngreso.Year)
            {
                int antiguedad = fechaActual.Month - pPrestamo.Clietne.Empleo.FechaIngreso.Month;
                if (fechaActual < pPrestamo.Clietne.Empleo.FechaIngreso.AddMonths(antiguedad)) antiguedad--;

                if (antiguedad >= this.iAntiguedadMinima) return true;
                else return false;
            }
            else if ((fechaActual.Year - pPrestamo.Clietne.Empleo.FechaIngreso.Year) > 1) return true;

            else if ((12 - pPrestamo.Clietne.Empleo.FechaIngreso.Month) + fechaActual.Month >= iAntiguedadMinima) return true;
            else return false;
        }
        

        public  EvalauadorAntiguedadLaboral(int pAntiguedadMinima)
        {
            this.iAntiguedadMinima = pAntiguedadMinima;
        }

        
    }
}
