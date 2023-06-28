using proyecto_DBP.Models;

namespace proyecto_DBP.Services
{
    public interface IReserva
    {
        void CrearReserva(Reserva reserva);
        void EliminarHorario(int horarioBorrar);
    }
}
