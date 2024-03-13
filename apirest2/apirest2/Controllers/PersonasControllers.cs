//interfaz (vista) para interactuar con la aplicación
using apirest2.Modelos;
using apirest2.Repositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileSystemGlobbing.Internal.PathSegments; //librería se manda a llamar
namespace apirest2.Controllers
{
    [ApiController] //este va a ser el controlador principal

    [Route("[controller]")] //se crea la ruta a apartir de la clase
    
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

