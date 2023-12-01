public class Usuario : Persona //Se define la subclase de Persona Usuario
{
// Se agregan propiedades a la clase hija
 public string TipoUsuario{get; set;}

 public Usuario(){
 }
 public Usuario(string nombre, string apellido, string id, string tipoUsuario) : base(nombre,
apellido, id)
 {
 TipoUsuario = tipoUsuario;
 }
 public override void MostrarInformacion()
 {
 Console.WriteLine($"{TipoUsuario}: {nombre} {apellido}, ID: {id}");
 }
}