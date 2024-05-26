using BD.Modelos;

namespace BD.Modelos.Repositorio
{
    public interface IRepositorioPrestamo
    {
        //operaciones: agregar (Add), actualizar (Update), eliminar (Delete), obtener (Get), obtener todos (GetAll)
        //Préstamos
        Task<Prestamo> AddPrestamo(Prestamo prestamo);
        Task UpdatePrestamo(Prestamo prestamo);
        Task DeletePrestamo(int id);
        Task<Prestamo> GetPrestamo(int id);
        Task<List<Prestamo>> GetAllPrestamos(); //Obtener todos los préstamos
    }
}
