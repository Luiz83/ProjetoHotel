namespace ProjetoHotel.Lib.Models
{
    public class Estadia
    {
        private int Id { get; set; }
        private Hospede Responsavel { get; set; }
        private Quarto Quarto {get;set;}
        private DateTime DataEntrada { get; set; }
        private DateTime DataSaida { get; set; }
        private DateTime DataCadastro { get; set; }
        private DateTime DataUltimaAtualizacao { get; set; }
    }
}