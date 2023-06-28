using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using proyecto_DBP.Models;
using proyecto_DBP.Services;

namespace proyecto_DBP.Controllers
{
    public class ProductoController : Controller
    {
        private readonly IProducto _producto;
        public ProductoController(IProducto producto) 
        {
            _producto= producto;    
        }

        public IActionResult Index()
        {
             return View(_producto.GetAllProducts());
        }
        [Route("Producto/Comprar/{codigo}")]
        public IActionResult Comprar(string codigo)
        {
            var objObtenido = _producto.GetProduct(codigo);
            return View(objObtenido);
        }

    }
}
