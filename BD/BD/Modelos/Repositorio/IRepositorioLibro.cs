using BD.Modelos;

namespace BD.Modelos.Repositorio
{
    public interface IRepositorioLibro
    {
        //operaciones: agregar (Add), actualizar (Update), eliminar (Delete), obtener (Get), obtener todos (GetAll)

        //Libros
        Task<Libro> AddLibro(Libro libro);
        Task UpdateLibro(Libro libro);
        Task DeleteLibro(int id);
        Task<Libro> GetLibro(int id);
        Task<List<Libro>> GetAllLibros(); //Obtener todos los libros

    }
}
