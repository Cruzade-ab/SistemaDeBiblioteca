public class ListaDeLibros //Se crea una clase para representar La lista de libros
{
    private List<Libro> libros; //Como propiedad principal se crea una Lista que guarde las instancias de la clase libro.

    //Metodo constructor, el cual como argumento va a contener las instancias de x numero de libros, llamados al inicializar la instancia de ListaDeLibros en el programa Se define params 
    //para poder pasar un array con una cantidad indefinida de datos, en este caso son instancias de Libros en un array llamado librosIniciales, que cuando se crea la Instancia se guardan en ella. 
    public ListaDeLibros(params Libro[] librosIniciales) 
    {
        libros = new List<Libro>(librosIniciales);
    }

    //Metodo para agregar libros, no inicializados en un principio. Se define void ya que no devuelve un valor
     public void AgregarLibro(Libro libro)
    {
        libros.Add(libro);
    }

    //Metodo para eliminar Libros.
    public void EliminarLibro(string isbn)
    {
        libros.RemoveAll(libro => libro.Isbn == isbn);
    }

    //Metodo para buscar Libros por Isbn, se define Libro ya que devuelve un objeto de esta clase. 
    public Libro BuscarPorISBN(string isbn)
    {
        return libros.Find(libro => libro.Isbn == isbn);
    }

    //Metodo que devuelve una lista con todos los objetos en la lista de libros
    public List<Libro> TodosLosLibros()
    {
        return libros;
    }

    //Metodo que devuelve una lista con todos los objetos donde Prestado = True
    public List<Libro> LibrosPrestados()
    {
        return libros.Where(libro => libro.Prestado).ToList();
    }

    //Metodo que devuelve una lista con todos los objetos donde Prestado = False
    public List<Libro> LibrosDisponibles()
    {
        return libros.Where(libro => !libro.Prestado).ToList();
    }

}