using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenejadorTransacciones
{
    ///<summary>
    /// Interface que representa los elementos pagables
    ///</summary>
    public interface IPayable
    {

        /// <summary>
        /// Devuelve el monto de pago del objeto.
        /// </summary>
        /// <returns></returns>
        decimal GetPaymentAmount();
    }
}