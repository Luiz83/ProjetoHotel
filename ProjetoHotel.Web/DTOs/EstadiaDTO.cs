using ProjetoHotel.Lib.Models;

namespace ProjetoHotel.Web.DTOs
{
    public class EstadiaDTO : ModelBaseDTO
    {
        public Hospede Responsavel { get; set; }
        public Quarto Quarto { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
    }
}