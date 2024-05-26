using BD.Modelos.Repositorio;
using Microsoft.EntityFrameworkCore;

namespace BD.Modelos
{
    public class RepositorioClaseMulta : IRepositorioMulta
    {
        private readonly DBContext _contexto;

        public RepositorioClaseMulta(DBContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<Multa> AddMulta(Multa multa)
        {
            _contexto.Multas.Add(multa);
            await _contexto.SaveChangesAsync();
            return multa;
        }
        public async Task UpdateMulta(Multa multa)
        {
            var multaActualizada = await _contexto.Multas.FindAsync(multa.Id);
            if (multaActualizada != null)
            {
                multaActualizada.FechaCreacion = multa.FechaCreacion;
                multaActualizada.FechaPago = multa.FechaPago;
                multaActualizada.Completado = multa.Completado;
                multaActualizada.Monto = multa.Monto;
                multaActualizada.PrestamoId = multa.PrestamoId;
                await _contexto.SaveChangesAsync();
            }
        }
        public async Task DeleteMulta(int id)
        {
            var multa = await _contexto.Multas.FindAsync(id);
            if (multa != null)
            {
                _contexto.Multas.Remove(multa);
                await _contexto.SaveChangesAsync();
            }
        }
        public async Task<Multa> GetMulta(int id)
        {
            return await _contexto.Multas.FindAsync(id);
        }
        public async Task<List<Multa>> GetAllMultas()
        {
            return await _contexto.Multas.ToListAsync();
        }
    }
}
