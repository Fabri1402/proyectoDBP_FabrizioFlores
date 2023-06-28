using proyecto_DBP.Models;

namespace proyecto_DBP.Services
{
    public class HorarioRepository : IHorario
    {
        private VentasC conexion = new VentasC();

        public Horario GetHorario(string id)
        {
            int idH = int.Parse(id);
            var ObjHorario = (from thor in conexion.Horarios
                               where thor.IdHorario == idH
                               select thor).SingleOrDefault();
            return ObjHorario;
        }

        public IEnumerable<Horario> GetHorariosDisponibles(DateTime fecha, int tamaño)
        {
            return conexion.Horarios.Where(thor => thor.Fecha.Date == fecha.Date && thor.Tamaño == tamaño).ToList();
        }
    }
}
        