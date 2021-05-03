using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenejadorTransacciones
{
    public class CostMovement
    {
        public int Cantidad { get; set; }
        public double PrecioUnit { get; set; }
        public string Concepto { get; set; }

        public DateTime FechaM { get; set; }

        public CostMovement( int cantidad, double precio, string conc, DateTime fechap )
        {
            Cantidad = cantidad;
            PrecioUnit = precio;
            Concepto = conc;
            FechaM = fechap;
        }
    }
}
