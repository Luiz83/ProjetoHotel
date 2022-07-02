using System.Text.Json.Serialization;

namespace ProjetoHotel.Web.DTOs
{
    public class ModelBaseDTO
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("datacadastro")]
        public DateTime DataCadastro { get; set; }
         [JsonPropertyName("dataultimaatualizacao")]
        public DateTime DataUltimaAtualizacao { get; set; }
    }
}