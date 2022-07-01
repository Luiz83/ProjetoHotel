using Microsoft.EntityFrameworkCore;
using ProjetoHotel.Lib.Data.Repositorios.Interfaces;
using ProjetoHotel.Lib.Models;

namespace ProjetoHotel.Lib.Data.Repositorios
{
    public class RepositorioBase<T> : IRepositorioBase<T> where T : ModelBase 
    {
        protected readonly HotelContext _context;
        protected readonly DbSet<T> _dbset;

        public RepositorioBase(HotelContext context, DbSet<T> dbset = null)
        {
            _context = context;
            _dbset = dbset;
        }

        public List<T> BuscarTodos()
        {
            return _dbset.AsNoTracking().ToList();
        }
        public T BuscarPorId(int id)
        {
            return _dbset.AsNoTracking().First(x => x.GetId() == id);
        }
        public void Adicionar(T item)
        {
            _dbset.Add(item);
            _context.SaveChanges();
        }
        public void Deletar(int id)
        {
            var item = _dbset.Find(id);
            _dbset.Remove(item);
            _context.SaveChanges();
        }
    }
}