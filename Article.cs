using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MenejadorTransacciones
{
    public class Article : BusinessEntity
    {
        private static Random randomNumbers = new Random();
        public enum MovementType
        {
            Inversion,
            Gastos,
            Ventas,
            Salario
        }
        public enum TaxType
        {
            Fixed,
            Proportional,
            Less,
            Both
        }
        private string concepto;
        private string movementString;

        public string Concepto
        {
            get
            {
                return concepto;
            }
            private set
            {
                if (value.Length > 0 && value.Length < 40)
                {
                    concepto = value;
                }
                else
                {
                    throw new ArgumentException("El concepto debe ser tener menos de 20 caracteres", nameof(Concepto));
                }
            }
        }

        public string Description { get; set; }

        public string MovementString
        {
            get
            {
                return movementString;
            }
            private set
            {
                if (value.Length < 30)
                {
                    if (value.Contains(";"))
                    {
                        movementString = value;
                    }
                    else
                    {
                        throw new FormatException("No contiene ;");
                    }
                }
                else
                {
                    throw new ArgumentException("La cadena debe ser menor a 30", nameof(MovementString));
                }
            }
        }

        public void SetMovementString(MovementType movementTypeP, TaxType taxTypeP, Nullable<decimal> fixedAmountP = null, Nullable<decimal> porcentualTax = null)
        {
            string[] dicMovementTypeP = { "Inv", "Gas", "Ven", "Sal" };
            string[] dicTaxTypeP = { "Fix", "Pro", "Less", "Both" };

            this.MovementString = dicMovementTypeP[(int)movementTypeP] + ";" + dicTaxTypeP[(int)taxTypeP];
            this.MovementString += ";Fix=" + fixedAmountP?.ToString() + ";Por=" + porcentualTax?.ToString();
        }

        public Article(string conceptoP, string descriptionP, MovementType movementT, TaxType taxT, Nullable<decimal> fixedAmount = null,
                Nullable<decimal> porcentual = null)
        {
            this.Concepto = conceptoP;
            this.Description = descriptionP;
            SetMovementString(movementT, taxT, fixedAmount, porcentual);
        }

        public int GetID()
        {
            Properties.MovPorUsuariosEntities porUsuariosEntities = GetEntity();
            int number = randomNumbers.Next(0, int.MaxValue);
            porUsuariosEntities.ARTICULOS.Load();
            for (bool retry = true; retry == true;)
            {
                System.Int32 countItem = porUsuariosEntities.ARTICULOS
                    .Where((Properties.ARTICULOS artP) => artP.ID == number)
                    .Count();
                if (countItem == 0)
                {
                    retry = false;
                }
                else
                {
                    number = randomNumbers.Next(0, int.MaxValue);
                    retry = true;
                }
            }
            return number;
        }
    }
}
