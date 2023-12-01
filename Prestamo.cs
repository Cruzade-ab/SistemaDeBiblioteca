public class Prestamo{ //Clase Prestamos

    // Se inicializan las propiedades
    public string Id {get; set;}
    public Libro Libro {get; set;} //Tiene como propiedad Objeto -Libro-
    public Usuario Usuario{get; set;} //Tiene como propiedad objeto usuario
    public DateTime FechaPrestamo {get; set;}
    public DateTime FechaDevuelto {get; set;}

    public bool entregado{get; set;}


    //Metodo Constructor
    public Prestamo(){
    }

    public Prestamo(string id, Libro libro, Usuario usuario, DateTime fechaPrestamo){
        Id = id;
        Libro = libro;
        Usuario = usuario;
        FechaPrestamo = fechaPrestamo;
        entregado = false;
    }


    //Metodo para registrar un Libro como entregado, lo cual se le asigna la Fecha de Devolucion y se registra como entregado = true.
    public void EntregarLibro(){
        if (!entregado){ //(Logica si es cierto), entregado = falso, !falso = Cierto
            FechaDevuelto = DateTime.Now;
            entregado = true;
        }
        else {
            Console.WriteLine("No se puede entregar ya que ha sido devuelto anteriormente.");
        }
    }


    //Metodo Para mostrar la informacion
    public void MostrarInformacion(){
        if (!entregado){
            Console.WriteLine($"Id: {Id}, Libro: {Libro.Titulo}, Usuario: {Usuario.TipoUsuario}: {Usuario.nombre} {Usuario.apellido}, Fecha Prestamo: {FechaPrestamo}");
        }
        else{
            Console.WriteLine($"Id: {Id}, Libro: {Libro.Titulo}, Usuario: {Usuario.TipoUsuario}: {Usuario.nombre} {Usuario.apellido}, Fecha Prestamo: {FechaPrestamo}, Fecha de Devolucion{FechaDevuelto}");
        }
    }
}