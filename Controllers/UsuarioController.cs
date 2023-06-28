using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using proyecto_DBP.Models;
using proyecto_DBP.Services;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace proyecto_DBP.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuario _usuario;

        public UsuarioController(IUsuario usuario)
        {
            _usuario= usuario;  
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult IndexCrear()
        {
            return View();
        }
        public IActionResult Validar(Usuario usuario)
        {
            if (_usuario.ValidateUser(usuario) == true)
            {
                HttpContext.Session.SetString("sUsuario",JsonConvert.SerializeObject(usuario));
                return RedirectToAction("Index","Socio");
            }
            else
            {
                return View("index");
            }            
        }

        public IActionResult add(Usuario usuario)
        {
            _usuario.add(usuario);
            return View("Index");
        }
    }
}
