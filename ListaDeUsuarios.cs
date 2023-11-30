public class ListaDeUsuarios{
    private List<Usuario> usuarios;

    public ListaDeUsuarios(params Usuario[] usuariosIniciales){
        usuarios = new List<Usuario>(usuariosIniciales);
    }

    public void AgregarUsuarios(Usuario usuario){
        usuarios.Add(usuario);
    }
    public void EliminarUsuarios(Usuario usuario){
        usuarios.Remove(usuario);
    }

    public List<Usuario> TodosLosUsuarios(){
        return usuarios;
    }

    public List<Usuario> Estudiantes(){
        return usuarios.Where(usuario => usuario.TipoUsuario == "Estudiante").ToList();
    }

    public List<Usuario> Profesores(){
        return usuarios.Where(usuario => usuario.TipoUsuario == "Profesor").ToList();
    }

}