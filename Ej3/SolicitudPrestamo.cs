using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    /// <summary>
    /// representa la solicitud generada por un cliente
    /// </summary>
    public class SolicitudPrestamo
    {
        private double iMonto;

        private int iCantidadCuotas;

        private Cliente iCliente;

        public  SolicitudPrestamo(Cliente pCliente, double pMonto, int pCantidadDeCuotas)
        {
            this.iCliente = pCliente;
            this.iCantidadCuotas = pCantidadDeCuotas;
            this.iMonto = pMonto;
        }

        public double Monto
        {
            get { return this.iMonto; }
        }
        
        public int CantidadCuotas
        {
            get { return this.iCantidadCuotas; }
        }

        public Cliente Clietne
        {
            get { return this.iCliente; }
        }
      
    }
}
