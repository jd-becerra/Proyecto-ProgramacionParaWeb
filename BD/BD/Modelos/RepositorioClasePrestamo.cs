using BD.Modelos.Repositorio;
using Microsoft.EntityFrameworkCore;

namespace BD.Modelos
{
    public class RepositorioClasePrestamo : IRepositorioPrestamo
    {
        private readonly DBContext _contexto;

        public RepositorioClasePrestamo(DBContext contexto)
        {
            _contexto = contexto;
        }
        public async Task<Prestamo> AddPrestamo(Prestamo prestamo)
        {
            _contexto.Prestamos.Add(prestamo);
            await _contexto.SaveChangesAsync();
            return prestamo;
        }
        public async Task UpdatePrestamo(Prestamo prestamo)
        {
            var prestamoActualizado = await _contexto.Prestamos.FindAsync(prestamo.Id);
            if (prestamoActualizado != null)
            {
                prestamoActualizado.FechaPrestamo = prestamo.FechaPrestamo;
                prestamoActualizado.FechaEntrega = prestamo.FechaEntrega;
                prestamoActualizado.ClienteId = prestamo.ClienteId;
                prestamoActualizado.LibroId = prestamo.LibroId;
                prestamoActualizado.Completado = prestamo.Completado;
                await _contexto.SaveChangesAsync();
            }
        }
        public async Task DeletePrestamo(int id)
        {
            var prestamo = await _contexto.Prestamos.FindAsync(id);
            if (prestamo != null)
            {
                _contexto.Prestamos.Remove(prestamo);
                await _contexto.SaveChangesAsync();
            }
        }
        public async Task<Prestamo> GetPrestamo(int id)
        {
            return await _contexto.Prestamos.FindAsync(id);
        }
        public async Task<List<Prestamo>> GetAllPrestamos()
        {
            return await _contexto.Prestamos.ToListAsync();
        }
    }
}
