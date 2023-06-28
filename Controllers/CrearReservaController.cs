using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyecto_DBP.Models;
using proyecto_DBP.Services;

namespace proyecto_DBP.Controllers
{
    public class CrearReservaController : Controller
    {
        private readonly IReserva _reserva;
        private readonly IHorario _horario;

        public CrearReservaController(IReserva reserva, IHorario horario)
        {
            _reserva = reserva;
            _horario = horario;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CrearReserva(string nombres, string apellidos, string correo, string telefono, string idHorario)
        {
            Reserva reserva = new Reserva();
            reserva.NombreCliente = nombres;
            reserva.ApellidosCliente = apellidos;
            reserva.CorreoCliente = correo;
            reserva.TelefonoCliente = telefono;

            Horario horario = _horario.GetHorario(idHorario);

            reserva.FechaReserva = horario.Fecha;
            reserva.HoraReserva = horario.Hora;
            reserva.TamañoMesa = horario.Tamaño;
            reserva.IdHorario = horario.IdHorario;

            _reserva.CrearReserva(reserva);

            return View(reserva);
        }

        public IActionResult Confirmar(int horarioBorrar)
        {
            _reserva.EliminarHorario(horarioBorrar);
            return RedirectToAction("Index", "Home");
        }
    }
}
