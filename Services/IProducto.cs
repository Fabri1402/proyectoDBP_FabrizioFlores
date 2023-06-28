using proyecto_DBP.Models;

namespace proyecto_DBP.Services
{
    public interface IProducto
    {
        IEnumerable<TbProducto> GetAllProducts();
        TbProducto GetProduct(string id);
    }
}
