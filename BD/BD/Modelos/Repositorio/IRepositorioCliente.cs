using BD.Modelos;

namespace BD.Modelos.Repositorio
{
    public interface IRepositorioCliente
    {
        //operaciones: agregar (Add), actualizar (Update), eliminar (Delete), obtener (Get), obtener todos (GetAll)

        //Clientes
        Task<Cliente> AddCliente(Cliente cliente);
        Task UpdateCliente(Cliente cliente);
        Task DeleteCliente(int id);
        Task<Cliente> GetCliente(int id);
        Task<List<Cliente>> GetAllClientes(); //Obtener todos los clientes
    }
}
