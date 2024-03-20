//interfaz (vista) para interactuar con la aplicación
using Microsoft.AspNetCore.Mvc;
using Repositories.Models;
using Repositories.Repositorio; //librería se manda a llamar
namespace apirest2.Controllers
{


    [Route("api/[controller]")] //se crea la ruta a apartir de la clase
    [ApiController] //este va a ser el controlador principal
        /// <summary>
        /// /TAREA
        /// </summary>
        public class PersonasController : ControllerBase 
        {

            PersonaRepositorio personaRepositorio;
            public PersonasController(PersonaRepositorio Repositorio)
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

            [HttpPut ("{id}")]
            public IActionResult ActualizarPersona(int id, PersonaModel persona){
                    personaRepositorio.Actualizar(id, persona);
                    return NoContent();
            }

            [HttpDelete ("{id}")]

            public IActionResult BorrarPersona(int id){
                    personaRepositorio.Borrar(id);
                    return NoContent();
            }
        }

    }

