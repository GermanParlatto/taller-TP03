using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    /// <summary>
    /// permite gestionar la solicitud de prestamo si es valida
    /// dependiendo si cumple con los criterios de los evaluadores definidos
    /// para cada tipo de cliente
    /// </summary>
    public class GestorPrestamos
    {
        private IDictionary<TipoCliente, EvaluadorCompuesto> iEvaluadoresPorCliente;

        public GestorPrestamos()
        {
            this.iEvaluadoresPorCliente = new Dictionary<TipoCliente, EvaluadorCompuesto>();

            //-----Evaluadores en comun a TODOS los tipos de clientes--------------
            IEvaluador evaluadorEdad=new EvaluadorEdad(18,75);
            IEvaluador evaluadorAntiguedad = new EvalauadorAntiguedadLaboral(6);
            IEvaluador evaluadorSalario = new EvaluadorSueldo(5000.00);

            //-----Evaluadores para tipo "NO" CLIENTE-------------------------------
            IEvaluador evaluadorNoClienteMonto = new EvaluadorMonto(20000.00);
            IEvaluador evaluadorNoClienteCuota = new EvaluadorCantidadDeCuotas(12);

            //-----Evaluadores para tipo CLIENTE -----------------------------------
            IEvaluador evaluadorClienteMonto = new EvaluadorMonto(100000.00);
            IEvaluador evaluadorClienteCuota = new EvaluadorCantidadDeCuotas(32);

            //-----Evaluadores para tipo CLIENTE GOLD-------------------------------
            IEvaluador evaluadorClienteGoldMonto = new EvaluadorMonto(150000.00);
            IEvaluador evaluadorClienteGoldCuota = new EvaluadorCantidadDeCuotas(60);

            //-----Evaluadores para tipo CLIENTE PREMIUM----------------------------
            IEvaluador evaluadorClientePremiumMonto = new EvaluadorMonto(200000.00);
            IEvaluador evaluadorClientePremiumCuota = new EvaluadorCantidadDeCuotas(60);

            //this.iEvaluadoresPorCliente.Add(TipoCliente.Cliente, new EvaluardorCompuesto());

            //---Agregando todos los evaluadores para tipo "NO" CLIENTE-------------------------------------
            this.iEvaluadoresPorCliente[TipoCliente.NoCliente] = new EvaluadorCompuesto();
            this.iEvaluadoresPorCliente[TipoCliente.NoCliente].AgregarEvaluador(evaluadorEdad);
            this.iEvaluadoresPorCliente[TipoCliente.NoCliente].AgregarEvaluador(evaluadorAntiguedad);
            this.iEvaluadoresPorCliente[TipoCliente.NoCliente].AgregarEvaluador(evaluadorSalario);
            this.iEvaluadoresPorCliente[TipoCliente.NoCliente].AgregarEvaluador(evaluadorNoClienteMonto);
            this.iEvaluadoresPorCliente[TipoCliente.NoCliente].AgregarEvaluador(evaluadorNoClienteCuota);


            //---Agregando todos los evaluadores para tipo CLIENTE-----------------------------------------
            this.iEvaluadoresPorCliente[TipoCliente.Cliente] = new EvaluadorCompuesto();
            this.iEvaluadoresPorCliente[TipoCliente.Cliente].AgregarEvaluador(evaluadorEdad);
            this.iEvaluadoresPorCliente[TipoCliente.Cliente].AgregarEvaluador(evaluadorAntiguedad);
            this.iEvaluadoresPorCliente[TipoCliente.Cliente].AgregarEvaluador(evaluadorSalario);
            this.iEvaluadoresPorCliente[TipoCliente.Cliente].AgregarEvaluador(evaluadorClienteMonto);
            this.iEvaluadoresPorCliente[TipoCliente.Cliente].AgregarEvaluador(evaluadorClienteCuota);


            //---Agregando todos los evaluadores para tipo CLIENTE GOLD-------------------------------------
            this.iEvaluadoresPorCliente[TipoCliente.ClienteGold] = new EvaluadorCompuesto();
            this.iEvaluadoresPorCliente[TipoCliente.ClienteGold].AgregarEvaluador(evaluadorEdad);
            this.iEvaluadoresPorCliente[TipoCliente.ClienteGold].AgregarEvaluador(evaluadorAntiguedad);
            this.iEvaluadoresPorCliente[TipoCliente.ClienteGold].AgregarEvaluador(evaluadorSalario);
            this.iEvaluadoresPorCliente[TipoCliente.ClienteGold].AgregarEvaluador(evaluadorClienteGoldMonto);
            this.iEvaluadoresPorCliente[TipoCliente.ClienteGold].AgregarEvaluador(evaluadorClienteGoldCuota);


            //---Agregando todos los evaluadores para tipo CLIENTE PREMIUM-------------------------------------
            this.iEvaluadoresPorCliente[TipoCliente.ClientePremium] = new EvaluadorCompuesto();
            this.iEvaluadoresPorCliente[TipoCliente.ClientePremium].AgregarEvaluador(evaluadorEdad);
            this.iEvaluadoresPorCliente[TipoCliente.ClientePremium].AgregarEvaluador(evaluadorAntiguedad);
            this.iEvaluadoresPorCliente[TipoCliente.ClientePremium].AgregarEvaluador(evaluadorSalario);
            this.iEvaluadoresPorCliente[TipoCliente.ClientePremium].AgregarEvaluador(evaluadorClientePremiumMonto);
            this.iEvaluadoresPorCliente[TipoCliente.ClientePremium].AgregarEvaluador(evaluadorClientePremiumCuota);

        }

        public bool EsValida(SolicitudPrestamo pSolicitudPrestamo)
        {
            return this.iEvaluadoresPorCliente[pSolicitudPrestamo.Clietne.TipoCliente].EsValida(pSolicitudPrestamo);
        }
    }
}
