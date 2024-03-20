//molde para los datos, bandeja donde se reciben los datos
namespace Repositories.Models

{
    public class ProductoModel
    { //el nombre de la clase debe coincidir con el nombre del archivo, al crear un nuevo archivo crear una nueva clase
        private global::System.Int32 id;

        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public bool Existencia { get; set; }

        public DateTime FechaDeRegistro { get; set; }

        public global::System.Int32 GetId()
        {
            return id;
        }

        public void SetId(global::System.Int32 value)
        {
            id = value;
        }
    }
}
