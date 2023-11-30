public class Usuario : Persona
{
 private string tipoUsuario;
 public Usuario(string nombre, string apellido, string id, string tipoUsuario) : base(nombre,
apellido, id)
 {
 this.tipoUsuario = tipoUsuario;
 }
 public string TipoUsuario
 {
 get { return tipoUsuario; }
 set { tipoUsuario = value; }
 }
 public override void MostrarInformacion()
 {
 Console.WriteLine($"{tipoUsuario}: {nombre} {apellido}, ID: {id}");
 }
}