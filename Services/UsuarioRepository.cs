using proyecto_DBP.Models;
using System.Reflection.Metadata;

namespace proyecto_DBP.Services
{
    public class UsuarioRepository : IUsuario
    {
        private VentasC conexion = new VentasC();
       
        public IEnumerable<Usuario> GetUsuarios()
        {
            return conexion.Usuarios;
        }
        public void add(Usuario usuario)
        {
            conexion.Usuarios.Add(usuario);
            conexion.SaveChanges();
        }

        public bool ValidateUser(Usuario obj)
        {
            var objUsuario =(from tusu in conexion.Usuarios
                    where tusu.UsuNombre == obj.UsuNombre
                    && tusu.UsuClave == obj.UsuClave
                    select tusu).FirstOrDefault();
            if (objUsuario == null)
            {
                return false;
            }
            else
            {
                return true;
            }                
        }
    }
}