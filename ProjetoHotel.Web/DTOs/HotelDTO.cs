using System.Text.Json.Serialization;

namespace ProjetoHotel.Web.DTOs
{
    public class HotelDTO : ModelBaseDTO
    {
        [JsonPropertyName("nome")]
        public string Nome { get; set; }
        [JsonPropertyName("endereco")]
        public string Endereco { get; set; }
        [JsonPropertyName("cep")]
        public string Cep { get; set; }
        [JsonPropertyName("descricao")]
        public string Descricao { get; set; }
        [JsonPropertyName("telefone")]
        public string Telefone { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("horariocheckin")]
        public DateTime HorarioCheckIn { get; set; }
        [JsonPropertyName("horariocheckout")]
        public DateTime HorarioCheckOut { get; set; }
    }
}