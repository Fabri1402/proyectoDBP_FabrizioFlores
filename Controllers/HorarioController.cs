using Microsoft.AspNetCore.Mvc;
using proyecto_DBP.Services;

namespace proyecto_DBP.Controllers
{
    public class HorarioController : Controller
    {
        private readonly IHorario _horario;

        public HorarioController(IHorario horario)
        {
            _horario = horario;
        }
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult HorariosPorFecha(DateTime fecha, int tamaño)
        {
            var horarios = _horario.GetHorariosDisponibles(fecha, tamaño);

            return View(horarios);
        }
    }
}
