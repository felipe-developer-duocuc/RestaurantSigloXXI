using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantXXINegocio
{
    class Inventario
    {
        public int id_solicitud_insumo { get; set; }
        public int usuario_id { get; set; }
        public string creado_en { get; set; }
        public string modificado_en { get; set; }
    }
}
