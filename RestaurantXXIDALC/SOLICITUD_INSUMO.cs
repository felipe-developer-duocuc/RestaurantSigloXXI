//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestaurantXXIDALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class SOLICITUD_INSUMO
    {
        public SOLICITUD_INSUMO()
        {
            this.SOLICITUD_INSUMO_PRODUCTO_PROVEEDOR = new HashSet<SOLICITUD_INSUMO_PRODUCTO_PROVEEDOR>();
        }
    
        public int id_solicitud_insumo { get; set; }
        public int usuario_id { get; set; }
        public string creado_en { get; set; }
        public string modificado_en { get; set; }
    
        public virtual ICollection<SOLICITUD_INSUMO_PRODUCTO_PROVEEDOR> SOLICITUD_INSUMO_PRODUCTO_PROVEEDOR { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
