public class Libro //Se crea la clase Publica Libro
{
    //A continuacion se definen las propiedades de libros, estas son publicas para poder acceder a ellas desde otras clases
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Isbn { get; set; }
    public bool Prestado { get; set; }

    //Metodo constructor 
    public Libro(){
    }
    public Libro(string titulo, string autor, string isbn)
    {
        Titulo = titulo;
        Autor = autor;
        Isbn = isbn;
        Prestado = false;
    }

    //Metodo para mostrar la informacion del libro 
    public void MostrarInformacion()
    {
        Console.WriteLine($"Libro: {Titulo}, Autor: {Autor}, ISBN: {Isbn}, Prestado: {Prestado}");
    }

    public void RegistrarLibroPrestado(){
        if (!Prestado){
            Prestado = true;
            Console.WriteLine("Libro prestado");
        }
        else{
            Console.WriteLine("Libro ya esta prestado");
        }
    }
    public void RegistrarLibroEntregado(){
        if (Prestado){
            Prestado = false;
            Console.WriteLine("Libro entregado");
        }
        else{
            Console.WriteLine("Libro ya esta entregado");
        }
    }
}