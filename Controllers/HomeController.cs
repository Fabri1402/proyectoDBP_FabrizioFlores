using Microsoft.AspNetCore.Mvc;
using proyecto_DBP.Models;
using proyecto_DBP.Services;
using System.Diagnostics;

namespace proyecto_DBP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProducto _producto;

        public HomeController(ILogger<HomeController> logger, IProducto producto)
        {
            _logger = logger;
            _producto = producto;
        }

        public IActionResult Index()
        {
            return View(_producto.GetAllProducts());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}