using BD.Modelos.Repositorio;
using Microsoft.EntityFrameworkCore;

//https://github.com/Aval0G/BD-Tortilleria.git
namespace BD.Modelos
{
    public class RepositorioClase : IRepositorio
    {
        private readonly DBContext _contexto;

        public RepositorioClase(DBContext contexto)
        {
            _contexto = contexto;
        }

        //Get all ya implementado
        public async Task<Cliente> AddCliente(Cliente cliente)
        {
            _contexto.Clientes.Add(cliente);
            await _contexto.SaveChangesAsync();
            return cliente;
        }
        public async Task UpdateCliente(Cliente cliente)
        {
            var clienteActualizado = await _contexto.Clientes.FindAsync(cliente.Id);
            if (clienteActualizado != null) {
                clienteActualizado.Nombre = cliente.Nombre;
                clienteActualizado.Apellido = cliente.Apellido;
                clienteActualizado.Dirección = cliente.Dirección;
                clienteActualizado.Teléfono = cliente.Teléfono;
                clienteActualizado.Correo = cliente.Correo;

                _contexto.Entry(clienteActualizado).State = EntityState.Modified;

                await _contexto.SaveChangesAsync();
            }
        }
        public async Task DeleteCliente(int id)
        {
            var cliente = await _contexto.Clientes.FindAsync(id);
            if (cliente != null)
            {
                _contexto.Clientes.Remove(cliente);
                await _contexto.SaveChangesAsync();
            }
        }
        public async Task<Cliente> GetCliente(int id)
        {
            return await _contexto.Clientes.FindAsync(id);
        }
        public async Task<List<Cliente>> GetAllClientes()
        {
            return await _contexto.Clientes.ToListAsync();
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
