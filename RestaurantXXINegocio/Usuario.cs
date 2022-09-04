using RestaurantXXIDALC;
using System.Linq;

namespace RestaurantXXINegocio
{
    public class Usuario
    {
        public int id_usuario { get; set; }
        public string nombres { get; set; }
        public string apellido_paterno { get; set; }
        public string apellido_materno { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string nombre_usuario { get; set; }
        public string contrasenia { get; set; }
        public int rol_id { get; set; }
        public string creado_en { get; set; }
        public string modificado_en { get; set; }

        DB_RESTAURANT_SXXIEntities1 db = new DB_RESTAURANT_SXXIEntities1();

        public Usuario FindByEmail(string correo)
        {
            Usuario usuario = this.db.USUARIO.Select(p => new Usuario()
            {
                id_usuario = p.id_usuario,
                nombres = p.nombres,
                apellido_paterno = p.apellido_paterno,
                apellido_materno = p.apellido_materno,
                telefono = p.telefono,
                correo = p.correo,
                nombre_usuario = p.nombre_usuario,
                contrasenia = p.contrasenia,
                rol_id = p.rol_id,
                creado_en = p.creado_en,
                modificado_en = p.modificado_en
            }).Where(p => p.correo == correo).FirstOrDefault();
            if (usuario == null) usuario = new Usuario();
            return usuario;
        }

        public bool ValidarEmailLogin(Usuario usuario)
        {
            if (usuario.correo == "" || usuario.correo == null || usuario.contrasenia == "" || usuario.contrasenia == null) return false;
            Usuario usuarioValidado = FindByEmail(usuario.correo);
            if (usuarioValidado.correo == usuario.correo && usuarioValidado.contrasenia == usuario.contrasenia)
            {
                return true;
            }
            return false;
        }
    }
}
