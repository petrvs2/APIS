//molde para los datos, bandeja donde se reciben los datos
namespace Repositories.Models

{
    public class ProductoModel
    { //el nombre de la clase debe coincidir con el nombre del archivo, al crear un nuevo archivo crear una nueva clase

        public int Id {get;set;}
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public bool Existencia { get; set; }

        public DateTime FechaDeRegistro { get; set; }
        
    }
}
