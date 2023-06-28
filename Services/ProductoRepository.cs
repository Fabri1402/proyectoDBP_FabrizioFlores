using proyecto_DBP.Models;

namespace proyecto_DBP.Services
{
    public class ProductoRepository : IProducto
    {
        private VentasC conexion = new VentasC();
        public IEnumerable<TbProducto> GetAllProducts()
        {
            return conexion.TbProductos;
        }

        public TbProducto GetProduct(string id)
        {
            var ObjProducto = (from tpro in conexion.TbProductos
                               where tpro.CodPro == id
                               select tpro).Single();
            return ObjProducto;
        }
    }
}
