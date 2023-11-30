public class Usuario : Persona
{
 public string TipoUsuario{get; set;}
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