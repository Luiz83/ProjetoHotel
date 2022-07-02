using ProjetoHotel.Lib.Models;

namespace ProjetoHotel.Lib.Data.Repositorios.Interfaces
{
    public interface IRepositorioBase<T> where T : ModelBase
    {
        public List<T> BuscarTodos();
        public Task<List<T>> BuscarTodosAsync();
        public T BuscarPorId(int id);
        public void Adicionar(T item);
        public Task AdicionarAsync(T item);
        public void Deletar(int id);
    }
}