public abstract class Persona //Se define la clase base Persona
{
    //Se definen las propiedades de la clase Persona como protected para poder acceder a ellas desde sus subclases.
 protected string nombre;
 protected string apellido;
 protected string id;


 //Metodo constructor
 public Persona(string nombre, string apellido, string id)
 {
 this.nombre = nombre;
 this.apellido = apellido;
 this.id = id;
 }

 //A continuacion se definen las propiedades a travez de los metodos get y set
 public string Nombre
 {
 get { return nombre; }
 set { nombre = value; }
 }
 public string Apellido
 {
 get { return apellido; }
 set { apellido = value; }
 }
 public string Id
 {
 get { return id; }
 set { id = value; }
 }

 //Se crea un metodo abstracto para mostar la informacion, que sera sobre escrito en las clases hijas
 public abstract void MostrarInformacion();
}