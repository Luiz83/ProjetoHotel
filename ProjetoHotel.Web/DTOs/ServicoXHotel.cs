using ProjetoHotel.Lib.Models;

namespace ProjetoHotel.Web.DTOs
{
    public class ServicoXHotel : ModelBaseDTO
    {
        public Hotel Hotel { get; set; }
        public Servico Servico { get; set; }
    }
}