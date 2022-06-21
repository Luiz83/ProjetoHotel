namespace ProjetoHotel.Lib.Models
{
    public class EstadiaXHospede
    {
        private int Id { get; set; }
        private Estadia Estadia { get; set; }
        private Hospede Hospede { get; set; }
        private DateTime DataCadastro { get; set; }
        private DateTime DataUltimaAtualizacao { get; set; }
    }
}