using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantXXINegocio
{
    class RecetaOrden
    {
        public int id_receta_orden { get; set; }
        public int orden_id { get; set; }
        public int receta_id { get; set; }
    }
}
