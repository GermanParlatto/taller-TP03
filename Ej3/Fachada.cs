using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    public class Fachada
    {
        private GestorPrestamos iGestorPrestamo;

        private Cliente iCliente;

        public Fachada() { this.iGestorPrestamo = new GestorPrestamos(); }



        public void RegistrarCliente(String pNombre, String pApellido, DateTime pNacimiento, double pSueldo, DateTime pIngreso)
        {
            Empleo empleo = new Empleo(pSueldo, pIngreso);
            iCliente = new Cliente(pNombre, pApellido, pNacimiento, empleo);
            
        }



        public bool MostrarCliente()
        {
            if (this.iCliente != null)
            {
                Console.WriteLine("DATOS DEL CLIENTE");
                Console.Write("Nombre: " + this.iCliente.Nombre); Console.WriteLine(" Apellido: " + this.iCliente.Apellido);
                Console.WriteLine("Fecha de nacimiento: " + this.iCliente.FechaNacimiento);
                Console.WriteLine("Fecha de inicio laboral: " + this.iCliente.Empleo.FechaIngreso);
                Console.WriteLine("Salario: " + this.iCliente.Empleo.Sueldo);
                Console.WriteLine("Tipo de cliente: " + this.iCliente.TipoCliente);
                Console.WriteLine("------------------------------------------");
                return true;

            }
            else
            {
                Console.WriteLine("No hay cliente Registrado");
                return false;
            }
        }
        


        public void ModificarTipoCliente(TipoCliente pTipo)
        {
            this.iCliente.TipoCliente = pTipo;
        }



        /// <summary>
        /// valida el solicitud de prestamo, ingresando como parametro
        /// los datos de la solicitud y con un cliente resgistrado previamente
        /// </summary>
        /// <param name="pMonto"></param>
        /// <param name="pCuotas"></param>
        public void ValidarSolicitud(double pMonto, int pCuotas)
        {
            //---Se crea la solicitud de prestamo a validar-------------------------------------
            SolicitudPrestamo solicitud = new SolicitudPrestamo(this.iCliente, pMonto, pCuotas);

            if (iGestorPrestamo.EsValida(solicitud)) Console.WriteLine("La solicitud es VALIDA");
            else Console.WriteLine("La solictud es NO VALIDA");
        }
    }
}
