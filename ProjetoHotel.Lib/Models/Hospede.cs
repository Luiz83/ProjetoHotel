namespace ProjetoHotel.Lib.Models
{
    public class Hospede
    {
        private int Id { get; set; }
        private string Nome { get; set; }
        private string Telefone { get; set; }
        private string Cpf { get; set; }
        private string Email { get; set; }
        private DateTime DataNascimento { get; set; }
        private DateTime DataCadastro { get; set; }
        private DateTime DataUltimaAtualizacao { get; set; }
    }
}