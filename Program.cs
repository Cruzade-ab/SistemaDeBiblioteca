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

        static void PrestamosEnLista(List<Prestamo> lista){
            foreach (Prestamo elemento in lista){
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
            //Para mostrar los datos de esta nueva lista se llama la funcion LibrosEnLista  que contienen dicha logica LibrosEnLista(AllBooks);
            var LibrosDisponibles = LibrosDeLaBiblioteca.LibrosDisponibles(); 
            var LibrosPrestados = LibrosDeLaBiblioteca.LibrosPrestados(); 
            //Se inicializan dos listas para cada situacion, *Cada vez que cambie algun estado de prestado se debe volver a llamar esta lista*
            

            // Se crean las instancias de usuarios
            Usuario usuario1 = new Usuario("Juan", "Pérez", "U001", "Estudiante");
            Usuario usuario2 = new Usuario("María", "García", "U002", "Profesor");

            ListaDeUsuarios Usuarios = new ListaDeUsuarios(usuario1, usuario2);

            var AllUsuarios = Usuarios.TodosLosUsuarios();
            var ListaEstudiantes = Usuarios.Estudiantes();
            var ListaProfesores = Usuarios.Profesores();

            Prestamo prestamo1 = new Prestamo("P01", libro1, usuario1, DateTime.Now);
            libro1.RegistrarLibroPrestado();
            prestamo1.MostrarInformacion();
            Prestamo prestamo2 = new Prestamo("P02", libro2, usuario1, DateTime.Now);
            libro2.RegistrarLibroPrestado();
            prestamo2.MostrarInformacion();
            Prestamo prestamo3 = new Prestamo("P03", libro3, usuario2, DateTime.Now);
            libro3.RegistrarLibroPrestado();
            prestamo3.MostrarInformacion();

            ListaDePrestamos Prestamos = new ListaDePrestamos(prestamo1, prestamo2);

            var AllPrestamos = Prestamos.TodosLosPrestamos();
            var PrestamosVijentes = Prestamos.prestamosSinEntregar();
            var PrestamosAntiguos = Prestamos.prestamosDevueltos();




             while (true)
            {
                Console.WriteLine("\nMenú de Gestión de Biblioteca:");
                Console.WriteLine("1. Mostrar libros");
                Console.WriteLine("2. Mostrar Usuarios");
                Console.WriteLine("3. Mostar Prestamos");
                Console.WriteLine("4. Registrar Usuario");
                Console.WriteLine("5. Registrar Libro");
                Console.WriteLine("5. Prestar un libro");
                Console.WriteLine("6. Devolver un libro");
                Console.WriteLine("7. Salir");
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
                                AllBooks = LibrosDeLaBiblioteca.TodosLosLibros();
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
                                AllUsuarios = Usuarios.TodosLosUsuarios();
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

                    case "3":
                        Console.WriteLine("1. Mostrar Todos los prestamos");
                        Console.WriteLine("2. Prestamos Actuales");
                        Console.WriteLine("3. Prestamos Pasados");
                        Console.WriteLine("4. Salir del Programa");
                        Console.Write("Elige una opción: ");

                        string subopcionPrestamos = Console.ReadLine();

                        switch (subopcionPrestamos){

                            case "1":
                                Console.WriteLine("Todos los Prestamos: ");
                                AllPrestamos = Prestamos.TodosLosPrestamos();
                                PrestamosEnLista(AllPrestamos);
                                break;
                            case "2":
                                PrestamosVijentes = Prestamos.prestamosSinEntregar(); 
                                Console.WriteLine("Todos los prestamos vijentes: ");
                                PrestamosEnLista(PrestamosVijentes);
                                break;
                                
                            case "3":
                                PrestamosAntiguos = Prestamos.prestamosDevueltos(); 

                                Console.WriteLine("Todos los prestamos pasados: ");
                                PrestamosEnLista(PrestamosAntiguos);
                                break;

                            case "4":
                                Console.WriteLine("Saliendo del programa...");
                                return; // Sale del programa

                        }
                        break;
                    case "4":

                        Console.WriteLine("Registrar usuario: ");
                        Console.WriteLine("1. Estudiante");
                        Console.WriteLine("2. Profesor");
                        Console.WriteLine("3. Salir");
                        
                        Usuario usuario = new Usuario();

                        string opcionRegistrousuario = Console.ReadLine();

                        switch(opcionRegistrousuario){
                            case "1":
                                usuario.TipoUsuario = "Estudiante";

                                Console.WriteLine("Indique el Id: ");
                                usuario.id = Console.ReadLine();

                                Console.WriteLine("Indique el nombre: ");
                                usuario.nombre = Console.ReadLine();

                                Console.WriteLine("Indique el apellido: ");
                                usuario.apellido = Console.ReadLine();

                                Console.WriteLine("Usuario registrado: ");

                                usuario.MostrarInformacion();
                                Usuarios.AgregarUsuarios(usuario);

                                break;

                            case "2":
                                usuario.TipoUsuario = "Profesor";

                                Console.Write("Indique el Id: ");
                                usuario.id = Console.ReadLine();

                                Console.Write("Indique el nombre: ");
                                usuario.nombre = Console.ReadLine();

                                Console.Write("Indique el apellido: ");
                                usuario.apellido = Console.ReadLine();

                                Console.WriteLine("Usuario registrado: ");

                                usuario.MostrarInformacion();
                                Usuarios.AgregarUsuarios(usuario);

                                break;
                            
                            case "3":
                                Console.WriteLine("Saliendo...");
                                return;
                        }
                        break;
                    case "5":
                        Console.WriteLine("Registrar nuevo Libro: ");
                        Libro libro = new Libro();

                        Console.Write("Indique el Titulo: ");
                        libro.Titulo = Console.ReadLine();

                        Console.Write("Indique el Autor: ");
                        libro.Autor = Console.ReadLine();

                        Console.Write("Indique el Isbn: ");
                        libro.Isbn = Console.ReadLine();

                        Console.WriteLine("Libro registrado: ");
                        libro.Prestado = false; 

                        libro.MostrarInformacion();
                        LibrosDeLaBiblioteca.AgregarLibro(libro);


                        
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