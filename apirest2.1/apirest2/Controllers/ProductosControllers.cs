//interfaz (vista) para interactuar con la aplicación
using Microsoft.AspNetCore.Mvc;
using Repositories.Models;
using Repositories.Repositorio;
namespace apirest2.Controllers
{
    [ApiController] //este va a ser el controlador principal

    [Route("api/[controller]")] //se crea la ruta a apartir de la clase
    public class ProductosController : ControllerBase
    { //: sirve para hacer herencia. Controller base hace toda 
        ProductoRepositorio productoRepositorio;
        public ProductosController(ProductoRepositorio Repositorio)
        {
            productoRepositorio = Repositorio;
        }
        //la fucnión de la api controller
        [HttpGet] //método
        public IActionResult MetodoGet()
        {
            //lista de cadenas:
            /*
            List<string> lista;
            lista = new List<string>();
            lista.Add("No detectado");
            lista.Add("nuevo");

            return StatusCode(StatusCodes.Status200OK, lista); //ok, create, NotFound
*/

            List<ProductoModel> Lista1; //declaramos lista


            // productoRepositorio = new ProductoRepositorio();
            Lista1 = productoRepositorio.ObtenerTodos();
            return Ok(Lista1);
        }

        [HttpGet("{id}")]
        public IActionResult ObtenerPorID(int id)
        {
            ProductoModel producto;

            producto = productoRepositorio.ObtenerPorId(id);

            return Ok(producto); //ok puede retornar cualquier tipo de objeto
        }

        [HttpPost]

        public IActionResult AgregarProducto([FromBody] ProductoModel producto)
        { //frombody
            int id;
            // ProductoRepositorio productoRepositorio;
            //productoRepositorio = new ProductoRepositorio();
            id = productoRepositorio.AgregarProducto(producto);
            return Created("", new { Id = id }); //creación de un objeto dinámico
        }

        [HttpPut ("{id}")]
        public IActionResult ActualizarProducto(int id, ProductoModel producto){
            
            productoRepositorio.Actualizar(id, producto);
            return NoContent();
        }
        
        [HttpDelete ("{id}")]
        public IActionResult BorrarProducto(int id){
            productoRepositorio.Borrar(id);
            return NoContent();
        }
    }
}