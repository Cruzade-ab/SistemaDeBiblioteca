public class ListaDeUsuarios{ //Clase ListaDeUsuarios
    private List<Usuario> usuarios; //Propiedad Lista que contienen como objeto Usuario


    //Metodo constructor el cual se le pasa un arreglo de objetos, que se inicializan en la lista
    public ListaDeUsuarios(params Usuario[] usuariosIniciales){
        usuarios = new List<Usuario>(usuariosIniciales);
    }


    //Metodos para Agregar, o Eliminar un usuario de la lista usuarios
    public void AgregarUsuarios(Usuario usuario){
        usuarios.Add(usuario);
    }
    public void EliminarUsuarios(Usuario usuario){
        usuarios.Remove(usuario);
    }



    //Metodo para Inicializar una lista con todos los valores de usuario
    public List<Usuario> TodosLosUsuarios(){
        return usuarios;
    }


    //Metodo para crear una lista donde los usuarios sean estudiantes
    public List<Usuario> Estudiantes(){
        return usuarios.Where(usuario => usuario.TipoUsuario == "Estudiante").ToList();
    }


    //Metodo para crear una lista donde los usuarios sean estudiantes
    public List<Usuario> Profesores(){
        return usuarios.Where(usuario => usuario.TipoUsuario == "Profesor").ToList();
    }

}