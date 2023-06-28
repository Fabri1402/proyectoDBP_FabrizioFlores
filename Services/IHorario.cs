using proyecto_DBP.Models;

namespace proyecto_DBP.Services
{
    public interface IHorario
    {
        IEnumerable<Horario> GetHorariosDisponibles(DateTime fecha, int tamaño);
        Horario GetHorario(string id);
    }
}
