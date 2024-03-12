//interfaz (vista) para interactuar con la aplicación
using apirest2.Modelos;
using apirest2.Repositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileSystemGlobbing.Internal.PathSegments; //librería se manda a llamar
namespace apirest2.Controllers
{
    [ApiController] //este va a ser el controlador principal

    [Route("[controller]")] //se crea la ruta a apartir de la clase
    public class ProductosControllers : ControllerBase
    { //: sirve para hacer herencia. Controller base hace toda 
        ProductoRepositorio productoRepositorio;
        public ProductosControllers(ProductoRepositorio Repositorio)
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

        /// <summary>
        /// /TAREA
        /// </summary>
        public class PersonasControllers : ControllerBase
        {

            PersonaRepositorio personaRepositorio;
            public PersonasControllers(PersonaRepositorio Repositorio)
            {
                personaRepositorio = Repositorio;
            }
            [HttpGet]

            public IActionResult MetodoGet() //¿cuál de los anteriores sustituye a este?
            {
                List<PersonaModel> Personas;
                Personas = personaRepositorio.ObtenerTodos();
                return Ok(Personas);
            }

            [HttpGet("{id}")]
            public IActionResult ObtenerPorId(int id)
            {
                PersonaModel persona;

                persona = personaRepositorio.ObtenerPorId(id);
                return Ok(persona);
            }

            [HttpPost]

            public IActionResult AgregarPersona([FromBody] PersonaModel persona)
            {
                int id;
                id = personaRepositorio.AgregarPersona(persona);
                return Created("", new { Id = id });
            }

        }

    }
}
