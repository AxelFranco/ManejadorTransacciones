using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenejadorTransacciones
{
    public abstract class Tax : object, IPayable
    {

        private string concept;

        private decimal valueTax;

        /// <summary>
        /// Valor del impuesto, este dependera del tipo de impuesto para cualquier impuesto este
        /// debe ser mayor a cero
        /// </summary>
        public virtual decimal ValueTax
        {
            get
            {
                return valueTax;
            }
            set
            {
                if (value > 0)
                {
                    valueTax = value;
                }
                else
                {
                    throw new ArgumentException("El valor del impuesto debe ser mayor a 0", nameof(ValueTax));
                }
            }
        }

        /// <summary>
        /// El concepto puede tener como maximo 25 caracteres, en caso contrario se
        /// truncara el resto.
        /// </summary>
        public string Concept
        {
            get
            {
                return concept;
            }
            set
            {
                if (value.Length < 25)
                {
                    concept = value;
                }
                else
                {
                    concept = value.Substring(0, 24);
                }
            }
        }

        private decimal grossAmount;

        /// <summary>
        /// El monto bruto al cual se le aplica el impuesto, debe ser mayor a cero
        /// </summary>
        public decimal GrossAmount
        {
            get
            {
                return grossAmount;
            }
            set
            {
                if (value > 0)
                {
                    grossAmount = value;
                }
                else
                {
                    throw new ArgumentException("El valor del monto bruto debe ser > 0", nameof(GrossAmount));
                }
            }
        }


        /// <summary>
        /// Inicia las propiedades de la clase abstracta Tax
        /// </summary>
        /// <param name="grossAmountParam"> debe ser mayor a 0 representa el monto bruto al cual aplica el impuesto </param>
        /// <param name="conceptParam"> debe ser menor a 25 caracteres </param>
        /// <param name="valueTax"> depende del tipo de impuesto pero debe ser mayor a cero </param>
        public Tax(decimal grossAmountParam, string conceptParam, decimal valueTax)
        {
            GrossAmount = grossAmountParam;
            Concept = conceptParam;
            ValueTax = valueTax;
        }

        /// <summary>
        /// Inicia las propiedades de la clase abstracta Tax, en funcion de un objeto heredado de Tax.
        /// </summary>
        /// <param name="taxParam"> Debe ser un Tax valido</param>
        public Tax(Tax taxParam)
            : this(taxParam.GrossAmount, taxParam.Concept, taxParam.ValueTax) { }

        public override string ToString() => $"Concepto: {this.Concept}, Valor del Impuesto: {this.ValueTax}, Monto Bruto: {this.GrossAmount}";

        public abstract decimal GetPaymentAmount();
    }
}
