using proyecto_DBP.Models;

namespace proyecto_DBP.Services
{
    public class ReservaRepository : IReserva
    {
        private VentasC conexion = new VentasC();
        public void CrearReserva(Reserva reserva)
        {
            conexion.Reservas.Add(reserva);
            conexion.SaveChanges();
        }

        public void EliminarHorario(int horarioBorrar)
        {
            var horario = conexion.Horarios.FirstOrDefault(thor => thor.IdHorario == horarioBorrar);
            if (horario != null)
            {
                conexion.Horarios.Remove(horario);
                conexion.SaveChanges();
            }
        }
    }
}
