//ORIGEN DE LOS DATOS
using apirest2.Modelos;
namespace apirest2.Repositorios

{

    /// <summary>
    /// TAREA
    /// </summary>
    public class PersonaRepositorio{
        private List<PersonaModel> Lista;

        public PersonaRepositorio(){
            Lista = new List<PersonaModel>();
            PersonaModel persona;
            persona = new PersonaModel();
            persona.Id=43;
            persona.Nombre="fr";
            persona.Edad=23;
            persona.Vive=true;
            Lista.Add(persona);
        }

        public List<PersonaModel> ObtenerTodos(){
            return Lista;
        }

        public int AgregarPersona(PersonaModel persona){
            Lista.Add(persona);
            return 1;
        }

        public PersonaModel ObtenerPorId(int Id){
            PersonaModel persona;
            persona = new PersonaModel();
            persona.Nombre="fr";
            persona.Edad=23;
            persona.Vive=true;
            persona.Id= Id;
            return persona;
        }

    }
}