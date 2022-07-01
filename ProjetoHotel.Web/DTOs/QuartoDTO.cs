using ProjetoHotel.Lib.Models;

namespace ProjetoHotel.Web.DTOs
{
    public class QuartoDTO : ModelBaseDTO
    {
        public int Numero { get; set; }
        public int Andar { get; set; }
        public Hotel Hotel { get; set; }
        public TipoDeQuarto TipoDeQuarto { get; set; }
    }
}