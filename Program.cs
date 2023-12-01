using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        //Funciones que contienen la logica para mostrar elementos en la lista
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
            Libro libro1 = new Libro("L001" ,"Don Quijote de la Mancha", "Miguel de Cervantes", "978-84-376-0494-7");
            Libro libro2 = new Libro("L002" ,"Cien Años de Soledad", "Gabriel García Márquez", "978-84-376-0492-3");
            Libro libro3 = new Libro("L003" ,"El Principito", "Antoine de Saint-Exupéry", "978-0156013987");
            Libro libro4 = new Libro("L004" ,"1984", "George Orwell", "978-0451524935");
            Libro libro5 = new Libro("L005" ,"El Hobbit", "J.R.R. Tolkien", "978-0547928227");
            Libro libro6 = new Libro("L006" ,"Fahrenheit 451", "Ray Bradbury", "978-1451673319");
            Libro libro7 = new Libro("L007" ,"Orgullo y Prejuicio", "Jane Austen", "978-0141439518");
            Libro libro8 = new Libro("L008" ,"Matar a un Ruiseñor", "Harper Lee", "978-0060935467");
            Libro libro9 = new Libro("L009" ,"La Odisea", "Homero", "978-0140268867");
            Libro libro10 = new Libro("L010" ,"El Gran Gatsby", "F. Scott Fitzgerald", "978-0743273565");

            //Se crea una instancia de la clase ListaDeLibros llamada LibrosDeLaBiblioteca ya que son los libros ya existentes en la biblioteca.
            ListaDeLibros LibrosDeLaBiblioteca = new ListaDeLibros(libro1, libro2,libro3, libro4,libro5, libro6,libro7, libro8,libro9, libro10);

            
            var AllBooks = LibrosDeLaBiblioteca.TodosLosLibros(); 
            //Se crea una lista AllBooks que obtiene sus valores de LibrosDeBiblioteca, lo cual la hace una lista independiente a esta instancia.
            //Nota* Utilizo var, ya que el tipo de dato List<Libro> esta definido en el metodo

            var LibrosDisponibles = LibrosDeLaBiblioteca.LibrosDisponibles(); 
            var LibrosPrestados = LibrosDeLaBiblioteca.LibrosPrestados(); 
            //Se inicializan dos listas para cada situacion, *Cada vez que cambie algun estado de prestado se debe volver a llamar esta lista*
            

            // Se crean las instancias de usuarios
            Usuario usuario1 = new Usuario("Peter", "Pérez", "U001", "Estudiante");
            Usuario usuario2 = new Usuario("María", "Luisa", "U002", "Profesor");
            
            //Se inicializa la lista que recoge los usuarios ya creados como parametros
            ListaDeUsuarios Usuarios = new ListaDeUsuarios(usuario1, usuario2);

            //Se inicializan las listas con los metodos correspondientes para cada situacion
            var AllUsuarios = Usuarios.TodosLosUsuarios();
            var ListaEstudiantes = Usuarios.Estudiantes();
            var ListaProfesores = Usuarios.Profesores();
            

            //Se inicializa los prestamos, de igualmanera se le pasan los metodos correspondientes que ejecutan la logica para que sean "Prestados".
            Prestamo prestamo1 = new Prestamo("P001", libro1, usuario1, DateTime.Now);
            libro1.RegistrarLibroPrestado();
            prestamo1.MostrarInformacion();
            Prestamo prestamo2 = new Prestamo("P002", libro2, usuario1, DateTime.Now);
            libro2.RegistrarLibroPrestado();
            prestamo2.MostrarInformacion();
            Prestamo prestamo3 = new Prestamo("P003", libro3, usuario2, DateTime.Now);
            libro3.RegistrarLibroPrestado();
            prestamo3.MostrarInformacion();


            ListaDePrestamos Prestamos = new ListaDePrestamos(prestamo1, prestamo2, prestamo3); //Se inicializa la lista de Prestamos, con los prestamos ya creados

            //Se inicializan tres listas, que ejecutan los metodos correspondientes de la instancia Prestamos para su lista correspondiente
            var AllPrestamos = Prestamos.TodosLosPrestamos();
            var PrestamosVijentes = Prestamos.prestamosSinEntregar();
            var PrestamosAntiguos = Prestamos.prestamosDevueltos();


            // Se crea un While loop que contienen la logica del menu
             while (true)
            {   

                //Opciones
                Console.WriteLine("\nMenú de Gestión de Biblioteca:");
                Console.WriteLine("1. Mostrar libros");
                Console.WriteLine("2. Mostrar Usuarios");
                Console.WriteLine("3. Mostar Prestamos");
                Console.WriteLine("4. Registrar Usuario");
                Console.WriteLine("5. Registrar Libro");
                Console.WriteLine("6. Prestar un libro");
                Console.WriteLine("7. Devolver un libro");
                Console.WriteLine("8. Salir");

                Console.WriteLine("");

                Console.Write("Elige una opción: ");
                
    

                string opcion = Console.ReadLine(); //Variable para escoger que caso ejecutar

                switch (opcion)
                {
                    case "1": //Opciones de mostrar Libros
                        Console.WriteLine("1. Mostrar Todos los libros");
                        Console.WriteLine("2. Mostrar libros disponibles");
                        Console.WriteLine("3. Mostrar libros prestados");
                        Console.WriteLine("4. Salir del Programa");
                        Console.WriteLine("");
                        Console.Write("Elige una opción: ");

                        string subopcionLibros = Console.ReadLine(); //Variable para ejecutar el caso correspondiente

                        switch (subopcionLibros){

                            case "1":
                                Console.WriteLine("");
                                Console.WriteLine("Todos los libros en la biblioteca: ");
                                AllBooks = LibrosDeLaBiblioteca.TodosLosLibros(); //Se debe volver a inicializar la lista antes que llamarla(Actualiza sus valores)
                                LibrosEnLista(AllBooks); //Se muestra su Informacion con la funcion Libros en Lista
                                break;
                            case "2":
                                Console.WriteLine("");
                                LibrosDisponibles = LibrosDeLaBiblioteca.LibrosDisponibles();  //Se debe volver a inicializar la lista antes que llamarla(Actualiza sus valores)
                                Console.WriteLine("Todos los libros disponibles: ");
                                LibrosEnLista(LibrosDisponibles); //Se muestra su Informacion con la funcion Libros en Lista
                                break;
                                
                            case "3":
                                LibrosPrestados = LibrosDeLaBiblioteca.LibrosPrestados();  //Se debe volver a inicializar la lista antes que llamarla(Actualiza sus valores)
                                Console.WriteLine("");
                                Console.WriteLine("Todos los libros prestados: ");
                                LibrosEnLista(LibrosPrestados); //Se muestra su Informacion con la funcion Libros en Lista
                            break;

                            case "4":
                                Console.WriteLine("Saliendo del programa...");
                                return; // Sale del programa
                        }

                        break;

                    case "2":
                        //Opciones
                        Console.WriteLine("1. Mostrar Todos usuarios");
                        Console.WriteLine("2. Mostrar Estudiantes");
                        Console.WriteLine("3. Mostrar Profesores");
                        Console.WriteLine("4. Salir del Programa");
                        Console.WriteLine("");
                        Console.Write("Elige una opción: ");
                        
                        string subopcionUsuarios = Console.ReadLine(); //Variable para recoger las opciones

                        switch (subopcionUsuarios){

                            case "1":
                                Console.WriteLine("");
                                Console.WriteLine("Todos los Usuarios");
                                AllUsuarios = Usuarios.TodosLosUsuarios(); //Se debe volver a inicializar la lista antes que llamarla(Actualiza sus valores)
                                UsuariosEnLista(AllUsuarios);  //Se muestra su Informacion con la funcion Libros en Lista
                                break;
                            case "2":
                                Console.WriteLine("");
                                Console.WriteLine("Todos los Estudiantes");
                                ListaEstudiantes = Usuarios.Estudiantes(); //Se debe volver a inicializar la lista antes que llamarla(Actualiza sus valores)
                                UsuariosEnLista(ListaEstudiantes);//Se muestra su Informacion con la funcion Libros en Lista
                                break;
                            case "3":
                                Console.WriteLine("");
                                Console.WriteLine("Todos los Profesores");
                                ListaProfesores = Usuarios.Profesores(); //Se debe volver a inicializar la lista antes que llamarla(Actualiza sus valores)
                                UsuariosEnLista(ListaProfesores);//Se muestra su Informacion con la funcion Libros en Lista
                                break;
                            case "4":
                                Console.WriteLine("Saliendo del programa...");
                              
                                return; // Sale del programa
                        }
                        break;

                    case "3":

                    //Opciones
                        Console.WriteLine("1. Mostrar Todos los prestamos");
                        Console.WriteLine("2. Prestamos Actuales");
                        Console.WriteLine("3. Prestamos Pasados");
                        Console.WriteLine("4. Salir del Programa");
                        Console.WriteLine("");
                        Console.Write("Elige una opción: ");
 
                        string subopcionPrestamos = Console.ReadLine(); //Variable para ejecutar caso en especifico

                        switch (subopcionPrestamos){

                            case "1":
                                Console.WriteLine("");
                                Console.WriteLine("Todos los Prestamos: ");
                                AllPrestamos = Prestamos.TodosLosPrestamos(); //Se debe volver a inicializar la lista antes que llamarla(Actualiza sus valores)
                                PrestamosEnLista(AllPrestamos);//Se muestra su Informacion con la funcion Libros en Lista
                                break;
                            case "2":
                                PrestamosVijentes = Prestamos.prestamosSinEntregar(); //Se debe volver a inicializar la lista antes que llamarla(Actualiza sus valores)
                                Console.WriteLine("");
                                Console.WriteLine("Todos los prestamos vijentes: ");
                                PrestamosEnLista(PrestamosVijentes);//Se muestra su Informacion con la funcion Libros en Lista
                                break;
                                
                            case "3":
                                PrestamosAntiguos = Prestamos.prestamosDevueltos(); //Se debe volver a inicializar la lista antes que llamarla(Actualiza sus valores)
                                Console.WriteLine("");
                                Console.WriteLine("Todos los prestamos pasados: ");
                                PrestamosEnLista(PrestamosAntiguos);//Se muestra su Informacion con la funcion Libros en Lista
                                break;

                            case "4":
                                Console.WriteLine("Saliendo del programa...");
                                return; // Sale del programa

                        }
                        break;
                    case "4":

                        //Opciones de registro de estudiante
                        Console.WriteLine("Registrar usuario: ");
                        Console.WriteLine("1. Estudiante");
                        Console.WriteLine("2. Profesor");
                        Console.WriteLine("3. Salir");
                        Console.WriteLine("");
                        Console.Write("Elige una opcion: ");

                        string opcionRegistrousuario = Console.ReadLine(); //Variable para cada caso
                        
                        Usuario usuario = new Usuario(); //Se crea la instancia para asignar valores

                        

                        switch(opcionRegistrousuario){
                            case "1":
                                usuario.TipoUsuario = "Estudiante"; //Caso 1 = estudinate

                                Console.Write("Indique el Id: ");
                                usuario.id = Console.ReadLine();

                                Console.Write("Indique el nombre: ");
                                usuario.nombre = Console.ReadLine();

                                Console.Write("Indique el apellido: ");
                                usuario.apellido = Console.ReadLine();

                                Console.Write("Usuario registrado: ");

                                //Se recogen sus propiedades y se agregan a la lista correspondiente

                                usuario.MostrarInformacion();
                                Usuarios.AgregarUsuarios(usuario); 

                                break;

                            case "2":
                                usuario.TipoUsuario = "Profesor"; // Caso 2 = Profesor 
                                

                                //Se recogen sus propiedades y se agrega a la lista correspondiente

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
                        Libro libro = new Libro(); //Se inicializa el libro a registrar

                        //Se le asignan propiedades y se agrega a la lista correspondiente
                        Console.Write("Indique el Id del libro: ");
                        libro.Id = Console.ReadLine();

                        Console.Write("Indique el Titulo: ");
                        libro.Titulo = Console.ReadLine();

                        Console.Write("Indique el Autor: ");
                        libro.Autor = Console.ReadLine();

                        Console.Write("Indique el Isbn: ");
                        libro.Isbn = Console.ReadLine();
                        
                        Console.WriteLine("");
                        Console.WriteLine("Libro registrado: ");
                        libro.Prestado = false; 

                        libro.MostrarInformacion();

                        LibrosDeLaBiblioteca.AgregarLibro(libro);

                        break;
                    case "6":
                        Console.WriteLine("");
                        Console.WriteLine("Libros Disponibles: ");
                        LibrosDisponibles = LibrosDeLaBiblioteca.LibrosDisponibles(); //Se vuelve a recoger los valores libros Disponibles
                        LibrosEnLista(LibrosDisponibles); //Se muestran los Libros

                        Console.WriteLine("");

                        Console.WriteLine("Usuarios: ");
                        AllUsuarios = Usuarios.TodosLosUsuarios(); //Se vuelve a recoger los valores de la lista
                        UsuariosEnLista(AllUsuarios); //Se muestran los usuarios

                        Console.WriteLine("");

                        Console.Write("Indique el Id del libro a prestar: ");
                        string id_libro = Console.ReadLine();

                        Console.Write("Indique el Id del usuario a prestar: ");
                        string id_usuario = Console.ReadLine();

                        Console.Write("Indique el Id del prestamo correspondiente: ");
                        string id_prestamo = Console.ReadLine();

                        //Se recogen los valores necesarios en sus variables

                        Prestamo prestamo = new Prestamo();
                        //Se inicializa un libro
                        Libro libroPrestamo = LibrosDisponibles.Find(book => book.Id == id_libro); 
                        // Se recoge un libro de la lista libros disponibles donde el Id corresponda al que ingreso el usuario
                        Usuario usuarioPrestamo = AllUsuarios.Find(user=> user.id == id_usuario);
                        // Se recoge un usuario de la lista usuarioss donde el Id corresponda al que ingreso el usuario

                        //Se asignas las propiedades correspondientes

                        prestamo.Id = id_prestamo;
                        prestamo.Libro = libroPrestamo;
                        prestamo.Usuario = usuarioPrestamo;
                        prestamo.FechaPrestamo = DateTime.Now;

                        libroPrestamo.RegistrarLibroPrestado();
                        Prestamos.AgregarPrestamo(prestamo);
                        break;
                    case "7":
                        Console.WriteLine("Devolver Libro: ");
                        Console.WriteLine("");

                        LibrosPrestados = LibrosDeLaBiblioteca.LibrosPrestados();  //Se debe volver a inicializar la lista antes que llamarla(Actualiza sus valores)
                        Console.WriteLine("Todos los libros prestados: ");
                        Console.WriteLine("");
                        LibrosEnLista(LibrosPrestados); //Se muestra su Informacion con la funcion Libros en Lista
                        Console.WriteLine("");

                        PrestamosVijentes = Prestamos.prestamosSinEntregar(); //Se debe volver a inicializar la lista antes que llamarla(Actualiza sus valores)
                        Console.WriteLine("Todos los prestamos vijentes: ");
                        Console.WriteLine("");
                        PrestamosEnLista(PrestamosVijentes);//Se muestra su Informacion con la funcion Libros en Lista

                        Console.WriteLine("");

                        //Se le solicita al usuario la informacion correspondiente
                        Console.Write("Indique el Id del libro a devolver");
                        string id_libroPrestado = Console.ReadLine();

                        Console.Write("Indique el Id del prestamo a devolver");
                        string id_PrestamoDevuelto = Console.ReadLine();

                        Console.WriteLine("");

                        Prestamo prestamoDevuelto = PrestamosVijentes.Find(prestamo => prestamo.Id == id_PrestamoDevuelto);
                        Libro libroDevuelto = LibrosPrestados.Find(book => book.Id == id_libroPrestado);

                        //Se llaman los objetos para manipular sus metodos

                        prestamoDevuelto.EntregarLibro();
                        libroDevuelto.RegistrarLibroEntregado();
                        //Se ejecuta la logica de entregar

                        break;
                    case "8":
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