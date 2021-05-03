using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MenejadorTransacciones
{
    public class BusinessItem : BusinessEntity, IPayable
    {
        private static Properties.MovPorUsuariosEntities mov = GetEntity();
        private static Random randomNumbers = new Random();

        private int quantity;
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value > 0)
                {
                    quantity = value;
                }
                else
                {
                    throw new ArgumentException("La cantidad debe ser mayor a 0", nameof(Quantity));
                }
            }
        }

        private decimal pricePerUnit;
        public decimal PricePerUnit
        {
            get
            {
                return pricePerUnit;
            }
            set
            {
                if (value > 0)
                {
                    pricePerUnit = value;
                }
                else
                {
                    throw new ArgumentException("PricePerUnit debe ser mayor a 0", nameof(PricePerUnit));
                }
            }
        }

        private int idArt;

        public int IDArt
        {
            get
            {
                return idArt;
            }
            private set
            {
                mov.ARTICULOS.Load();

                bool queryArt = mov.ARTICULOS
                    .Any((Properties.ARTICULOS art) => art.ID == value);

                if (queryArt)
                    idArt = value;
                else
                    throw new ArgumentException($"No existe el articulo con ID: {value}", nameof(IDArt));
            }
        }

        private int idUser;
        public int IDUser
        {
            get
            {
                return idUser;
            }
            private set
            {
                mov.USUARIOS.Load();

                bool queryUser = mov.USUARIOS
                    .Any((Properties.USUARIOS userItem) => userItem.ID == value);

                if (queryUser)
                    idUser = value;
                else
                    throw new ArgumentException($"No existe el usuario con ID: {value}", nameof(IDUser));
            }
        }
        public System.DateTime DateOfMovement { get; set; }

        public BusinessItem(decimal pricePerUnitParam, int quantityParam, int IDArticle, DateTime dateTimeP
            , int IDUserP)
        {
            PricePerUnit = pricePerUnitParam;
            Quantity = quantityParam;
            DateOfMovement = dateTimeP;
            IDArt = IDArticle;
            IDUser = IDUserP;
        }

        public int GetNumberOfMovement()
        {
            int number = randomNumbers.Next(0, int.MaxValue);
            mov.MOVIMIENTOS.Load();

            for (bool retry = true; retry == true;)
            {
                System.Int32 countItem = mov.MOVIMIENTOS
                    .Where((Properties.MOVIMIENTOS movItem) => movItem.N_de_movimiento == number)
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
        public virtual decimal GetPaymentAmount() => PricePerUnit * Quantity;
    }
}
