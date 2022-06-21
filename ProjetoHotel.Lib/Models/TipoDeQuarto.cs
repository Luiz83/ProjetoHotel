namespace ProjetoHotel.Lib.Models
{
    public class TipoDeQuarto
    {
        private int Id { get; set; }
        private string Nome { get; set; }
        private string Descricao { get; set; }
        private int OcupacaoMaxima { get; set; }
        private int CamaCasal { get; set; }
        private int CamaSolteiro { get; set; }
        private double Valor { get; set; }
        private DateTime DataNascimento { get; set; }
        private DateTime DataCadastro { get; set; }
        private DateTime DataUltimaAtualizacao { get; set; }
    }
}