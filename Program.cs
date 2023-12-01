using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        //Funcion que contiene la logica para mostrar elementos en la lista
        static void LibrosEnLista(List <Libro> lista)
        {
            foreach (Libro elemento in lista)
            {
                elemento.MostrarInformacion(); 
            }
        }

        static void UsuariosEnLista(List <Usuario> lista)
        {
            foreach (Usuario elemento in lista)
            {
                elemento.MostrarInformacion();
            }
        }
        static void Main(string[] args)
        {
            // A continuacion se definen las instancias de libros ya en la biblioteca
            Libro libro1 = new Libro("Don Quijote de la Mancha", "Miguel de Cervantes", "978-84-376-0494-7");
            Libro libro2 = new Libro("Cien Años de Soledad", "Gabriel García Márquez", "978-84-376-0492-3");
            Libro libro3 = new Libro("El Principito", "Antoine de Saint-Exupéry", "978-0156013987");
            Libro libro4 = new Libro("1984", "George Orwell", "978-0451524935");
            Libro libro5 = new Libro("El Hobbit", "J.R.R. Tolkien", "978-0547928227");
            Libro libro6 = new Libro("Fahrenheit 451", "Ray Bradbury", "978-1451673319");
            Libro libro7 = new Libro("Orgullo y Prejuicio", "Jane Austen", "978-0141439518");
            Libro libro8 = new Libro("Matar a un Ruiseñor", "Harper Lee", "978-0060935467");
            Libro libro9 = new Libro("La Odisea", "Homero", "978-0140268867");
            Libro libro10 = new Libro("El Gran Gatsby", "F. Scott Fitzgerald", "978-0743273565");

            //Se crea una instancia de la clase ListaDeLibros llamada LibrosDeLaBiblioteca ya que son los libros ya existentes en la biblioteca.
            ListaDeLibros LibrosDeLaBiblioteca = new ListaDeLibros(libro1, libro2,libro3, libro4,libro5, libro6,libro7, libro8,libro9, libro10);

            var AllBooks = LibrosDeLaBiblioteca.TodosLosLibros(); 
            //Se crea una lista AllBooks que obtiene sus valores de LibrosDeBiblioteca, lo cual la hace una lista independiente a esta instancia.
            //Nota* Utilizo var, ya que el tipo de dato List<Libro> esta definido en el metodo

            //Para mostrar los datos de esta nueva lista se llama la funcion LibrosEnLista  que contienen dicha logica
            // LibrosEnLista(AllBooks);

            var LibrosDisponibles = LibrosDeLaBiblioteca.LibrosDisponibles(); 
            var LibrosPrestados = LibrosDeLaBiblioteca.LibrosPrestados(); 
            //Se inicializan dos listas para cada situacion, *Cada vez que cambie algun estado de prestado se debe volver a llamar esta lista*
            

            // Se crean las instancias de usuarios
            Usuario usuario1 = new Usuario("Juan", "Pérez", "001", "Estudiante");
            Usuario usuario2 = new Usuario("María", "García", "002", "Profesor");

            ListaDeUsuarios Usuarios = new ListaDeUsuarios(usuario1, usuario2);

            var AllUsuarios = Usuarios.TodosLosUsuarios();
            var ListaEstudiantes = Usuarios.Estudiantes();
            var ListaProfesores = Usuarios.Profesores();

             while (true)
            {
                Console.WriteLine("\nMenú de Gestión de Biblioteca:");
                Console.WriteLine("1. Mostrar libros");
                Console.WriteLine("2. Mostrar Usuarios");
                Console.WriteLine("7. Prestar un libro");
                Console.WriteLine("8. Devolver un libro");
                Console.WriteLine("9. Salir");
                Console.Write("Elige una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("1. Mostrar Todos los libros");
                        Console.WriteLine("2. Mostrar libros disponibles");
                        Console.WriteLine("3. Mostrar libros prestados");
                        Console.WriteLine("4. Salir del Programa");
                        Console.Write("Elige una opción: ");

                        string subopcionLibros = Console.ReadLine();

                        switch (subopcionLibros){

                            case "1":
                                Console.WriteLine("Todos los libros en la biblioteca: ");
                                LibrosEnLista(AllBooks);
                                break;
                            case "2":
                                LibrosDisponibles = LibrosDeLaBiblioteca.LibrosDisponibles(); 
                                Console.WriteLine("Todos los libros disponibles: ");
                                LibrosEnLista(LibrosDisponibles);
                                break;
                                
                            case "3":
                                LibrosPrestados = LibrosDeLaBiblioteca.LibrosPrestados(); 

                                Console.WriteLine("Todos los libros prestados: ");
                                LibrosEnLista(LibrosPrestados);
                            break;

                            case "4":
                                Console.WriteLine("Saliendo del programa...");
                                return; // Sale del programa
                        }
                        break;

                    case "2":

                        Console.WriteLine("1. Mostrar Todos usuarios");
                        Console.WriteLine("2. Mostrar Estudiantes");
                        Console.WriteLine("3. Mostrar Profesores");
                        Console.WriteLine("4. Salir del Programa");
                        Console.Write("Elige una opción: ");
                        
                        string subopcionUsuarios = Console.ReadLine();

                        switch (subopcionUsuarios){

                            case "1":
                                Console.WriteLine("Todos los Usuarios");
                                UsuariosEnLista(AllUsuarios);
                                break;
                            case "2":
                                Console.WriteLine("Todos los Estudiantes");
                                ListaEstudiantes = Usuarios.Estudiantes();
                                UsuariosEnLista(ListaEstudiantes);
                                break;
                            case "3":
                                Console.WriteLine("Todos los Profesores");
                                ListaProfesores = Usuarios.Profesores();
                                UsuariosEnLista(ListaProfesores);
                                break;
                            case "4":
                                Console.WriteLine("Saliendo del programa...");
                                return; // Sale del programa
                        }
                        break;
                        

                    case "5":
                        
                    case "6":
                        
                        break;
                    case "7":
                        
                        break;
                    case "8":
                        
                        break;
                    case "9":
                        Console.WriteLine("Saliendo del programa...");
                        return; // Sale del programa

                    default:
                        Console.WriteLine("Opción no válida. Por favor, intenta de nuevo.");
                        break;
                }
            }
    }
}
}