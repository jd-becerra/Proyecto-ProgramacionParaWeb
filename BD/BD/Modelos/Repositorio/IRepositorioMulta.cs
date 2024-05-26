using BD.Modelos;

namespace BD.Modelos.Repositorio
{
    public interface IRepositorioMulta
    {
        //operaciones: agregar (Add), actualizar (Update), eliminar (Delete), obtener (Get), obtener todos (GetAll)

        //Multas
        Task<Multa> AddMulta(Multa multa);
        Task UpdateMulta(Multa multa);
        Task DeleteMulta(int id);
        Task<Multa> GetMulta(int id);
        Task<List<Multa>> GetAllMultas(); //Obtener todas las multas

    }
}
