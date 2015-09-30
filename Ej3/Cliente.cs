using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    /// <summary>
    /// representa la persona que solicitara el prestamo
    /// </summary>
    public class Cliente
    {
        private String iNombre;

        private String iApellido;

        private DateTime iFechaNacimiento;

        private Empleo iEmpleo;

        private TipoCliente iTipoCliente;


        public Cliente(String pNombre, String pApellido, DateTime pFechaNacimiento, Empleo pEmpleo)
        {
            this.iNombre = pNombre;
            this.iApellido = pApellido;
            this.iFechaNacimiento = pFechaNacimiento;
            this.iEmpleo = pEmpleo;
            this.iTipoCliente = 0;
        }

        public String Nombre
        {
            get { return this.iNombre; }
        }

        public String Apellido
        {
            get { return this.iApellido; }
        }

        public DateTime FechaNacimiento
        {
            get { return this.iFechaNacimiento; }
        }

        public Empleo Empleo
        {
            get { return this.iEmpleo; }
        }

        public TipoCliente TipoCliente
        {
            get { return this.iTipoCliente; }
            set { this.iTipoCliente = value; }
        }
    }
}
