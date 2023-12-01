public class Usuario : Persona //Se define la subclase de Persona Usuario
{
// Propiedades a la clase hija
 public string TipoUsuario{get; set;}


//Metodos Constructor
 public Usuario(){
 }
 public Usuario(string nombre, string apellido, string id, string tipoUsuario) : base(nombre,
apellido, id)
 {
 TipoUsuario = tipoUsuario;
 }
 public override void MostrarInformacion() //Metodo sobre escrito para mostrar la informacion
 {
 Console.WriteLine($"{TipoUsuario}: {nombre} {apellido}, ID: {id}");
 }
}