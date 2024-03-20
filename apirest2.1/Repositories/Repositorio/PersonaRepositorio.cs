using Repositories.Models;

namespace Repositories.Repositorio
{
    
        public class PersonaRepositorio
        {
            private List<PersonaModel> Lista;
            int id = 0;

            private int ObtenerId()
            {
                id++;
                return id;
            }

            public PersonaRepositorio()
            {
                Lista = new List<PersonaModel>();
                PersonaModel persona;
                persona = new PersonaModel();
                persona.Id = ObtenerId();
                persona.Nombre = "fr";
                persona.Edad = 23;
                persona.Vive = true;
                Lista.Add(persona);
            }

            public List<PersonaModel> ObtenerTodos()
            {
                return Lista;
            }

            public int AgregarPersona(PersonaModel persona)
            {
                persona.Id = ObtenerId();
                Lista.Add(persona);
                return persona.Id;
            }

            public PersonaModel ObtenerPorId(int Id)
            {
                PersonaModel persona;
                persona = new PersonaModel();
                persona.Nombre = "fr";
                persona.Edad = 23;
                persona.Vive = true;
                persona.Id = Id;
                return persona;
            }

            public void Actualizar(int id, PersonaModel persona)
            {
                PersonaModel personaOriginal;

                personaOriginal = Lista.Where(x => x.Id == id).FirstOrDefault(); //expresión lambda x=> x.Id==id equivalente a consulta en base de datos
                personaOriginal.Edad = persona.Edad;
                personaOriginal.Nombre = persona.Nombre;
                personaOriginal.Vive = persona.Vive;

            }

            public void Borrar(int id)
            {
                PersonaModel personaBorrar;
                personaBorrar = Lista.Where(x => x.Id == id).FirstOrDefault();
                Lista.Remove(personaBorrar);
            }

        }
    }