using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantXXINegocio
{
    class InventarioProveedor
    {
        public int id_solicitud_insumo_producto_proveedor { get; set; }
        public int solicitud_insumo_id { get; set; }
        public int producto_proveedor_id { get; set; }
        public int cantidad { get; set; }
        public int recepcion_usuario_id { get; set; }
        public int estado_solicitud_insumo_producto_proveedor_id { get; set; }
        public string observaciones { get; set; }
    }
}
