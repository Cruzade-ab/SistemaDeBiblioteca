public class ListaDePrestamos{ //Clase que representa la lista de Prestamos
public List<Prestamo> librosPrestados{get; set;} //Propiedad principal que representa la lista

public ListaDePrestamos(params Prestamo[] prestamosIniciales){ //Metodo el cual se le pasa los prestamos ya inicializados y los recoge la lista librosPrestados al crearse
        librosPrestados = new List<Prestamo>(prestamosIniciales);
    }


    //Metodo para agregar Prestamo o eliminar (Permanentemente)
    public void AgregarPrestamo(Prestamo prestamo){ 
        librosPrestados.Add(prestamo);
    }
    public void EliminarPrestamo(Prestamo prestamo){
        librosPrestados.Add(prestamo);
    }


    //Se inicializa una lista con tocods los prestamos
    public List<Prestamo> TodosLosPrestamos(){
        return librosPrestados;
    }


    //Se crea un metodo para devolver prestamos Devueltos
    public List<Prestamo> prestamosDevueltos(){
        return librosPrestados.Where(prestamo => prestamo.entregado == true).ToList();
    }
    


    //Metodo donde se devuelve los prestamos sin entregar
    public List<Prestamo> prestamosSinEntregar(){
        return librosPrestados.Where(prestamo => prestamo.entregado == false).ToList();
    }



}