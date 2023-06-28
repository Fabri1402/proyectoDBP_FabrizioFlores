using Microsoft.AspNetCore.Mvc;
using proyecto_DBP.Models;
using proyecto_DBP.Services;

namespace proyecto_DBP.Controllers
{
    public class ReservaController : Controller
    {
        private readonly IHorario _horario;

        public ReservaController(IHorario horario)
        {
            _horario = horario;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        
        public IActionResult Horarios(DateTime fecha, int tamaño)
        {
            return View();
        }

        [Route("Horario/IngresarDatos/{id}")]
        public IActionResult IngresarDatos(string id)
        {
            var horario = _horario.GetHorario(id);

            ViewBag.IdHorario = horario.IdHorario;
            ViewBag.Fecha = horario.Fecha;
            ViewBag.Hora = horario.Hora;
            ViewBag.Tamaño = horario.Tamaño;

            return View();
        }
    }
}
