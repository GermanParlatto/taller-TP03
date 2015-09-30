using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ej3.Test
{
    [TestClass]
    public class GestorPrestamo
    {
        [TestMethod]
        public void VerificandoValidezDePrestamo()
        {
            //---Cargando datos necesarios para realizar la prueba-----------------------
            DateTime fechaDeNacimiento = new DateTime(1991, 6, 3); 
            DateTime fechaDeIngreso = new DateTime(2015, 3, 10);
            Empleo empleo = new Empleo(6000.00, fechaDeIngreso);
            Cliente cliente = new Cliente("German", "Parlatto",fechaDeNacimiento, empleo);
            //---el cliente de prueba utilizado  es PREMIUM------------------------------
            cliente.TipoCliente = TipoCliente.ClientePremium;
            SolicitudPrestamo prestamo = new SolicitudPrestamo(cliente, 200000.00, 60);
            GestorPrestamos gestor = new GestorPrestamos();


            Assert.AreEqual(true, gestor.EsValida(prestamo));

        }
    }
}
