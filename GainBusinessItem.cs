using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenejadorTransacciones
{
    public class GainBusinessItem : BusinessItem
    {
        private decimal gainValue;

        public decimal GainValue
        {
            get
            {
                return gainValue;
            }
            set
            {
                if (value > 0)
                {
                    gainValue = value;
                }
                else
                {
                    throw new ArgumentException("La ganancia debe ser mayor a 0", nameof(GainValue));
                }
            }
        }

        public GainBusinessItem(decimal pricePerUnitParam, int quantityParam, decimal gainValueParam, int IDArtparam, DateTime dateTime, int IDUserParam)
            : base(pricePerUnitParam, quantityParam,IDArtparam, dateTime, IDUserParam)
        {
            GainValue = gainValueParam;
        }

        public override decimal GetPaymentAmount() => base.GetPaymentAmount() + GainValue;
    }
}
