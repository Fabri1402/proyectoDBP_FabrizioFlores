using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using proyecto_DBP.Models;
using proyecto_DBP.Services;

namespace proyecto_DBP.Controllers
{
    public class SocioController : Controller
    {
        public IActionResult Index()
        {
            var objsession = HttpContext.Session.GetString("sUsuario");
            if (objsession != null)
            {
                var obj = JsonConvert.DeserializeObject<Usuario>
                    (HttpContext.Session.GetString("sUsuario"));
                ViewBag.nombreUsuario = obj.UsuNombre;
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Usuario");
            }
        }
    }
}
