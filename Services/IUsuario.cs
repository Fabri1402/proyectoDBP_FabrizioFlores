using proyecto_DBP.Models;

namespace proyecto_DBP.Services
{
    public interface IUsuario
    {
        bool ValidateUser(Usuario obj);
        IEnumerable<Usuario> GetUsuarios();
        void add(Usuario usuario);
    }
}
