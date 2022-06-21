namespace ProjetoHotel.Lib.Models
{
    public class Quarto
    {
        private int Id { get; set; }
        private int Numero { get; set; }
        private int Andar { get; set; }
        private TipoDeQuarto TipoDeQuarto { get; set; }
        private DateTime DataCadastro { get; set; }
        private DateTime DataUltimaAtualizacao { get; set; }
    }
}