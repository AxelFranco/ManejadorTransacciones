using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenejadorTransacciones
{
    /// <summary>
    /// Representa a un Impuesto por monto fijo.
    /// </summary>
    public class FixedTax : Tax
    {
        /// <summary>
        /// Crea un objeto tipo FixedTax que representa un impuesto por monto
        /// </summary>
        /// <param name="grossAmountParam"> Monto bruto a aplicar el impuesto. </param>
        /// <param name="conceptParam"> Concepto que representa al impuesto. </param>
        /// <param name="valueTaxParam"> Porcentaje del impuesto a aplicar. </param>
        public FixedTax(decimal grossAmountParam, string conceptParam, decimal valueTaxParam)
            : base(grossAmountParam, conceptParam, valueTaxParam) { }

        public FixedTax(FixedTax fixedTaxParam)
            : this(fixedTaxParam.GrossAmount, fixedTaxParam.Concept, fixedTaxParam.ValueTax) { }

        public override decimal GetPaymentAmount() => base.GrossAmount + base.ValueTax;
    }
}
