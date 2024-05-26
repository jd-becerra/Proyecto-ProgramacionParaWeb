using BD.Modelos.Repositorio;
using Microsoft.EntityFrameworkCore;

namespace BD.Modelos
{
    public class RepositorioClaseLibro : IRepositorioLibro
    {
        private readonly DBContext _contexto;

        public RepositorioClaseLibro(DBContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<Libro> AddLibro(Libro libro)
        {
            _contexto.Libros.Add(libro);
            await _contexto.SaveChangesAsync();
            return libro;
        }
        public async Task UpdateLibro(Libro libro)
        {
            var libroActualizado = await _contexto.Libros.FindAsync(libro.Id);
            if (libroActualizado != null)
            {
                libroActualizado.Titulo = libro.Titulo;
                libroActualizado.Autor = libro.Autor;
                libroActualizado.Edicion = libro.Edicion;
                libroActualizado.Genero = libro.Genero;
                libroActualizado.Año = libro.Año;
                libroActualizado.ISBN = libro.ISBN;
                await _contexto.SaveChangesAsync();
            }
        }
        public async Task DeleteLibro(int id)
        {
            var libro = await _contexto.Libros.FindAsync(id);
            if (libro != null)
            {
                _contexto.Libros.Remove(libro);
                await _contexto.SaveChangesAsync();
            }
        }
        public async Task<Libro> GetLibro(int id)
        {
            return await _contexto.Libros.FindAsync(id);
        }
        public async Task<List<Libro>> GetAllLibros()
        {
            return await _contexto.Libros.ToListAsync();
        }

    }
}
