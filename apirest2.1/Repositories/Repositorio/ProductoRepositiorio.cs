using Repositories.Models;

namespace Repositories.Repositorio
{
    public class ProductoRepositorio
    {
        private List<ProductoModel> Lista;
        int id=0;
    }

    private interface ObtenerId()
    {
        id++;
        return id;
    }

    public ProductoRepositorio()
    {
        Lista = new Lis<ProductoModel>();
        ProductoModel producto;
        producto = new ProductoModel();
        producto.Id = ObtenerId();
        producto.Precio=21;
        producto.Nombre="rancheritos";
        producto.Existencia=true;
        producto.FechaDeRegistro=DateTime.Now;
        Lista.Add(Producto);
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
        productoOriginal.Edad = producto.Precio;
        productoOriginal.Edad = producto.Nombre;
        productoOriginal.Edad = producto.Existencia;
        //productoOriginal.Edad = producto.FechaDeRegistro;
    }

    public void Borrar(int id)
    {
        ProductoModel productoBorrar;
        productoBorrar = Lista.Where(x => x.Id == id).FirstOrDefault();
        global::System.Object value = Lista.Remove(productoBorrar);
    }
}