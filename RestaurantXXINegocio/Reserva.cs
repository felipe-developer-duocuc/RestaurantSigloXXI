using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantXXINegocio
{
    class Reserva
    {
        public int id_reservall { get; set; }
        public string correo { get; set; }
        public DateTime fecha { get; set; }
        public int hora{ get; set; }
        public  int comensales{ get; set; }
    }
}
