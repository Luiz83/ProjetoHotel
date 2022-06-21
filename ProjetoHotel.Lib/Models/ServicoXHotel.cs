namespace ProjetoHotel.Lib.Models
{
    public class ServicoXHotel
    {
        private int Id { get; set; }
        private Hotel Hotel { get; set; }
        private Servico Servico { get; set; }
        private DateTime DataCadastro { get; set; }
        private DateTime DataUltimaAtualizacao { get; set; }
    }
}