namespace ProjetoHotel.Web.DTOs
{
    public class HotelDTO : ModelBaseDTO
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Cep { get; set; }
        public string Descricao { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime HorarioCheckIn { get; set; }
        public DateTime HorarioCheckOut { get; set; }
    }
}