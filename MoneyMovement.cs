using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenejadorTransacciones
{
    public class MoneyMovement : object, IPayable
    {
        public enum TypeEnum
        {
            Entry = 0,
            Egress = 1
        }

        private string description;

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (value.Length > 0 && value.Length < 250)
                {
                    description = value;
                }
                else
                {
                    description = value.Substring(0, 249);
                }
            }
        }

        public TypeEnum TypeMovement { get; private set; }

        private decimal amount;

        public decimal Amount
        {
            get
            {
                return amount;
            }
            set
            {
                if (value > 0)
                {
                    amount = value;
                }
                else
                {
                    throw new ArgumentException("El monto debe ser mayor a cero", nameof(Amount));
                }
            }
        }

        public MoneyMovement(string descriptionParam, TypeEnum typeMovementParam, decimal amountParam)
        {
            Description = descriptionParam;
            TypeMovement = typeMovementParam;
            Amount = amountParam;
        }

        public decimal GetPaymentAmount() => Amount;
    }
}
