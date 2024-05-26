using BD.Modelos.Repositorio;
using Microsoft.EntityFrameworkCore;

namespace BD.Modelos
{
    public class RepositorioClaseCliente : IRepositorioCliente
    {
        private readonly DBContext _contexto;

        public RepositorioClaseCliente(DBContext contexto)
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
    }
}
