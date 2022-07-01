using ProjetoHotel.Lib.Models;

namespace ProjetoHotel.Web.DTOs
{
    public class EstadiaXHospedeDTO : ModelBaseDTO
    {
        public Estadia Estadia { get; set; }
        public Hospede Hospede { get; set; }
    }
}