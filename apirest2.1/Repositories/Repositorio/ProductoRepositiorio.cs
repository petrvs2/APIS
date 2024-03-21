using Repositories.Models;

namespace Repositories.Repositorio
{
    public class ProductoRepositorio
    {
        private List<ProductoModel> Lista;
        int id = 0;


        private int ObtenerId()
        {
            id = id + 1;
            return id;
        }

        public ProductoModel ObtenerPorId(int Id)
        {
               ProductoModel producto;
                producto = Lista.Where(x => x.Id == id).FirstOrDefault();
                return producto;
        }

        public ProductoRepositorio()
        {
            Lista = new List<ProductoModel>();
            ProductoModel producto;
            producto = new ProductoModel();
            producto.Id = ObtenerId();
            producto.Precio = 21;
            producto.Nombre = "rancheritos";
            producto.Existencia = true;
            producto.FechaDeRegistro = DateTime.Now;
            Lista.Add(producto);
        }

        public List<ProductoModel> ObtenerTodos()
        {
            return Lista;
        }

        public int AgregarProducto(ProductoModel producto)
        {
            producto.Id = ObtenerId();
            Lista.Add(producto);
            return producto.Id;
        }
        public void Actualizar(int id, ProductoModel producto)
        {
            ProductoModel productoOriginal;

            productoOriginal = Lista.Where(x => x.Id == id).FirstOrDefault();
            productoOriginal.Precio = producto.Precio;
            productoOriginal.Nombre = producto.Nombre;
            productoOriginal.Existencia = producto.Existencia;
            //productoOriginal.Edad = producto.FechaDeRegistro;
        }

        public void Borrar(int id)
        {
            ProductoModel productoBorrar;
            productoBorrar = Lista.Where(x => x.Id == id).FirstOrDefault();
            Lista.Remove(productoBorrar);
        }
    }
}