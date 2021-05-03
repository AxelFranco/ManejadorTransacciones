using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MenejadorTransacciones
{
    public class BusinessEntity
    {
        private static MenejadorTransacciones.Properties.MovPorUsuariosEntities db = new MenejadorTransacciones.Properties.MovPorUsuariosEntities();

        public static MenejadorTransacciones.Properties.MovPorUsuariosEntities GetEntity() => db;
    }
}
