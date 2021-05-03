using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenejadorTransacciones
{
    /// <summary>
    /// Representa a un Impuesto por porcentaje.
    /// </summary>
    public class ProportionalTax : Tax
    {
        /// <summary>
        /// Porcentaje de aplicación del impuesto.
        /// </summary>
        public override decimal ValueTax
        {
            get
            {
                return base.ValueTax;
            }
            set
            {
                if (value > 0 && value < 100)
                {
                    base.ValueTax = value;
                }
                else
                {
                    throw new ArgumentException("El valor del impuesto debe ser mayor a 0 y menor a 100", nameof(ValueTax));
                }
            }

        }

        /// <summary>
        /// Crea un objeto tipo ProportionalTax que representa un impuesto por porcentaje
        /// </summary>
        /// <param name="grossAmountParam"> Monto bruto a aplicar el impuesto. </param>
        /// <param name="conceptParam"> Concepto que representa al impuesto. </param>
        /// <param name="valueTaxParam"> Porcentaje del impuesto a aplicar. </param>
        public ProportionalTax(decimal grossAmountParam, string conceptParam, decimal valueTaxParam)
            : base(grossAmountParam, conceptParam, valueTaxParam) { }    // El compilador llama a ValueTax de ProportionalTax, no al de Tax :D

        public ProportionalTax(ProportionalTax proportional)
            : this(proportional.GrossAmount, proportional.Concept, proportional.ValueTax) { }

        public override decimal GetPaymentAmount() => base.GrossAmount * (1 + this.ValueTax / 100);
    }
}
