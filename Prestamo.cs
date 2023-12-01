public class Prestamo{

    //Clase Libro
    public string Id {get; set;}
    public Libro Libro {get; set;} 
    public Usuario Usuario{get; set;}
    public DateTime FechaPrestamo {get; set;}
    public DateTime FechaDevuelto {get; set;}

    public bool entregado{get; set;}

    public Prestamo(){
    }

    public Prestamo(string id, Libro libro, Usuario usuario, DateTime fechaPrestamo){
        Id = id;
        Libro = libro;
        Usuario = usuario;
        FechaPrestamo = fechaPrestamo;
        entregado = false;
    }

    public void EntregarLibro(){
        if (!entregado){ //Logica si es cierto, entregado = falso, !falso = Cierto
            FechaDevuelto = DateTime.Now;
            entregado = true;
        }
        else {
            Console.WriteLine("No se puede entregar ya que ha sido devuelto anteriormente.");
        }
    }

    public void MostrarInformacion(){
        if (!entregado){
            Console.WriteLine($"Id: {Id}, Libro: {Libro.Titulo}, Usuario: {Usuario.TipoUsuario}: {Usuario.nombre} {Usuario.apellido}, Fecha Prestamo: {FechaPrestamo}");
        }
        else{
            Console.WriteLine($"Id: {Id}, Libro: {Libro.Titulo}, Usuario: {Usuario.TipoUsuario}: {Usuario.nombre} {Usuario.apellido}, Fecha Prestamo: {FechaPrestamo}, Fecha de Devolucion{FechaDevuelto}");
        }
    }
}