using Microsoft.EntityFrameworkCore;
using ProjetoHotel.Lib.Data.Repositorios.Interfaces;
using ProjetoHotel.Lib.Models;

namespace ProjetoHotel.Lib.Data.Repositorios
{
    public class RepositorioHotel : RepositorioBase<Hotel>, IRepositorioHotel
    {
        private readonly HotelContext _context;
        public RepositorioHotel(HotelContext context) : base(context, context.Hoteis)
        {
            _context = context;
        }
    }
}