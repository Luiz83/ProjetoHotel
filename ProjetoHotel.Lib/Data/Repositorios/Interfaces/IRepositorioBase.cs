using ProjetoHotel.Lib.Models;

namespace ProjetoHotel.Lib.Data.Repositorios.Interfaces
{
    public interface IRepositorioBase<T> where T : ModelBase
    {
        public List<T> BuscarTodos();
        public T BuscarPorId(int id);
        public void Adicionar(T item);
        public void Deletar(int id);
    }
}