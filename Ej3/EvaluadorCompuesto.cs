using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    /// <summary>
    /// representa la lista de los evaluadores que se especifican 
    /// para un tipo de empleado es pecifico
    /// </summary>
    public class EvaluadorCompuesto : IEvaluador
    {
        private IList<IEvaluador> iEvaluadores;

        public EvaluadorCompuesto()
        {
            this.iEvaluadores = new List<IEvaluador>();
        }

        public bool EsValida(SolicitudPrestamo pPrestamo)
        {
            IEnumerator<IEvaluador> enumerador = this.iEvaluadores.GetEnumerator();

            bool esValida = true;

            while (esValida && enumerador.MoveNext())
            {
                esValida = enumerador.Current.EsValida(pPrestamo);
            }

            return esValida;
        }

        public void AgregarEvaluador(IEvaluador pEvaluador)
        {
            this.iEvaluadores.Add(pEvaluador);
        }
    }
}
