public abstract class Persona //Se define la clase base Persona
{
    //Se definen las propiedades de la clase Persona como publicas para acceder a ellas desde cualquier parte
 public string nombre{get; set;}
 public string apellido{get; set;}
 public string id{get; set;}

public Persona(){
}
 //Metodo constructor
 public Persona(string nombre, string apellido, string id)
 {
 this.nombre = nombre;
 this.apellido = apellido;
 this.id = id;
 }

 //Se crea un metodo abstracto para mostar la informacion, que sera sobre escrito en las clases hijas
 public abstract void MostrarInformacion();
}