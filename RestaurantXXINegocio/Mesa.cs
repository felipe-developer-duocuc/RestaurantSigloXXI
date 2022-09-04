using RestaurantXXIDALC;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantXXINegocio
{
    public class Mesa
    {
        public int id_mesa { get; set; }
        public string numero { get; set; }
        public int estado_mesa_id { get; set; }

        DB_RESTAURANT_SXXIEntities1 db = new DB_RESTAURANT_SXXIEntities1();

        public List<Mesa> ReadAll()
        {
            return this.db.MESA.Select(p => new Mesa()
            {
                id_mesa = p.id_mesa,
                numero = p.numero,
                estado_mesa_id = p.estado_mesa_id
            }).ToList();
        }

        public string Save()
        {
            try
            {
                /*
                DateTime fechaNacimiento = (this.FechaApertura == null ? DateTime.Now.AddDays(1) : this.FechaApertura);
                int fn = int.Parse(fechaNacimiento.ToString("yyyyMMdd"));
                int fnv = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
                if (fn > fnv || fechaNacimiento == DateTime.MinValue)
                {
                    return "La fecha de apertura debe ser menor a la fecha actual";
                }
                if (SaldoInicial < 0)
                {
                    return "El saldo minimo debe ser 0";
                }
                this.Saldo = this.SaldoInicial;
                db.SP_AGREGAR_CUENTA(this.TipoCuentaId, this.FechaApertura, this.SaldoInicial, this.Saldo, this.ClienteId);*/
                db.Mesa_Insert(this.numero, this.estado_mesa_id);
                return "1";
            }
            catch (Exception e)
            {
                string ex = e.Message;
                return "0";
            }
        }
    }
}
