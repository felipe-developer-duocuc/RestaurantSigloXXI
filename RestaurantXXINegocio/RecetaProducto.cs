using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantXXINegocio
{
    class RecetaProducto
    {
        public int id_receta_producto{ get; set; } 
        public int receta_id { get; set; }
        public int producto_id { get; set; }
    }
}
