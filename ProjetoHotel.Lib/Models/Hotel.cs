namespace ProjetoHotel.Lib.Models
{
    public class Hotel
    {
        private int Id { get; set; }
        private string Nome { get; set; }
        private string Endereco { get; set; }
        private string Cep { get; set; }
        private string Descricao { get; set; }
        private string Telefone { get; set; }
        private string Email { get; set; }
        private DateTime HorarioCheckIn { get; set; }
        private DateTime HorarioCheckOut { get; set; }
        private DateTime DataCadastro { get; set; }
        private DateTime DataUltimaAtualizacao { get; set; }
    }
}