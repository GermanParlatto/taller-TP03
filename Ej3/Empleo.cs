using System;

namespace Ej3
{
    /// <summary>
    /// representa los datos como Empleado
    /// del cliente
    /// </summary>
    public class Empleo
    {
        private double iSueldo;

        private DateTime iFechaIngreso;

        public Empleo(Double pSueldo, DateTime pFechaIngreso)
        {
            this.iSueldo = pSueldo;
            this.iFechaIngreso = pFechaIngreso;

        }

        public double Sueldo
        {
            get { return this.iSueldo; }
        }

        public DateTime FechaIngreso
        {
            get { return this.iFechaIngreso; }
        }
    }
}