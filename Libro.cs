public class Libro //Se crea la clase Publica Libro
{
    //A continuacion se definen las propiedades de libros, estas son publicas para poder acceder a ellas desde otras clases

    public string Id{get; set;}
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Isbn { get; set; }
    public bool Prestado { get; set; } = false;

    //Metodo constructor 
    public Libro(){
    }
    public Libro(string id, string titulo, string autor, string isbn)
    {
        Id = id;
        Titulo = titulo;
        Autor = autor;
        Isbn = isbn;
        Prestado = false;
    }

    //Metodo para mostrar la informacion del libro 
    public void MostrarInformacion()
    {
        Console.WriteLine($"Id: {Id},Libro: {Titulo}, Autor: {Autor}, ISBN: {Isbn}, Prestado: {Prestado}");
    }

    // Metodo para cambiar la propiedad Prestado a True lo que indica que ha sido Prestado
    public void RegistrarLibroPrestado(){
        if (!Prestado){ // Prestado = False, !Prestado = Cierto
            Prestado = true;
            Console.WriteLine("Libro prestado");
        }
        else{
            Console.WriteLine("Libro ya esta prestado");
        }
    }

    //Metodo Para cambiar un libro prestado a False
    public void RegistrarLibroEntregado(){
        if (Prestado){ // Prestado = True
            Prestado = false;
            Console.WriteLine("Libro entregado");
        }
        else{
            Console.WriteLine("Libro ya esta entregado");
        }
    }
}