public class ListaDePrestamos{
public List<Prestamo> librosPrestados{get; set;}

public ListaDePrestamos(params Prestamo[] prestamosIniciales){
        librosPrestados = new List<Prestamo>(prestamosIniciales);
    }
    public void AgregarPrestamo(Prestamo prestamo){
        librosPrestados.Add(prestamo);
    }
    public void EliminarPrestamo(Prestamo prestamo){
        librosPrestados.Add(prestamo);
    }

    public List<Prestamo> TodosLosPrestamos(){
        return librosPrestados;
    }

    public List<Prestamo> prestamosDevueltos(){
        return librosPrestados.Where(prestamo => prestamo.entregado == true).ToList();
    }

    public List<Prestamo> prestamosSinEntregar(){
        return librosPrestados.Where(prestamo => prestamo.entregado == false).ToList();
    }



}