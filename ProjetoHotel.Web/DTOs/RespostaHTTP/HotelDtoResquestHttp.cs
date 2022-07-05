namespace ProjetoHotel.Web.DTOs.RespostaHTTP
{
    public class HotelDtoResquestHttp
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cep { get; set; }
        public string descricao { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public DateTime checkin { get; set; }
        public DateTime checkout { get; set; }
    }
}