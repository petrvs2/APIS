//ORIGEN DE LOS DATOS
using apirest2.Modelos;
namespace apirest2.Repositorios

{
    public class ProductoRepositorio{
        private List<ProductoModel> Lista; //declaramos lista

        public ProductoRepositorio(){ //agregamos producto a la lista
            Lista = new List<ProductoModel>();
            ProductoModel Producto;
            Producto = new ProductoModel();
            Producto.Id=233;
            Producto.Precio=21;
            Producto.Nombre="Rancheritos";
            Producto.Existencia=true;
            Producto.FechaDeRegistro=DateTime.Now;
            Lista.Add(Producto);
        }

        public List<ProductoModel> ObtenerTodos(){ //retornamos todo lo que contenga la lista
            return Lista;
        }

        public int AgregarProducto(ProductoModel producto){
            Lista.Add(producto);
            return 1;
        } 

        public ProductoModel ObtenerPorId(int Id){
            ProductoModel producto;
            producto = new ProductoModel();
            producto.Precio = 12;
            producto.Nombre = "papas";
            producto.Existencia = true;
            producto.FechaDeRegistro = DateTime.Now;
            producto.Id = Id;
            return producto;
        }
    }    
}