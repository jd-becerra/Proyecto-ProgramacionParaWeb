using BD.Modelos;

namespace BD.Modelos.Repositorio
{
    public interface IRepositorio
    {
        //operaciones: agregar (Add), actualizar (Update), eliminar (Delete), obtener (Get), obtener todos (GetAll)

        //Clientes
        Task<Cliente> AddCliente(Cliente cliente);
        Task UpdateCliente(Cliente cliente);
        Task DeleteCliente(int id);
        Task<Cliente> GetCliente(int id);
        Task<List<Cliente>> GetAllClientes(); //Obtener todos los clientes

        //Libros
        Task<Libro> AddLibro(Libro libro);
        Task UpdateLibro(Libro libro);
        Task DeleteLibro(int id);
        Task<Libro> GetLibro(int id);
        Task<List<Libro>> GetAllLibros(); //Obtener todos los libros

        //Préstamos
        Task<Prestamo> AddPrestamo(Prestamo prestamo);
        Task UpdatePrestamo(Prestamo prestamo);
        Task DeletePrestamo(int id);
        Task<Prestamo> GetPrestamo(int id);
        Task<List<Prestamo>> GetAllPrestamos(); //Obtener todos los préstamos

        //Multas
        Task<Multa> AddMulta(Multa multa);
        Task UpdateMulta(Multa multa);
        Task DeleteMulta(int id);
        Task<Multa> GetMulta(int id);
        Task<List<Multa>> GetAllMultas(); //Obtener todas las multas

    }
}
