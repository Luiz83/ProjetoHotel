namespace ProjetoHotel.Lib.Models
{
    public class Quarto : ModelBase
    {
        private int Numero { get; set; }
        private int Andar { get; set; }
        private TipoDeQuarto TipoDeQuarto { get; set; }

        public Quarto(int id, int numero, int andar, TipoDeQuarto tipoDeQuarto, DateTime dataCadastro, DateTime dataUltimaAtualizacao)
                      : base(id, dataCadastro, dataUltimaAtualizacao)
        {
            Numero = numero;
            Andar = andar;
            TipoDeQuarto = tipoDeQuarto;
        }
        public void SetNumero(int numero)
        {
            Numero = numero;
        }
        public int GetNumero()
        {
            return Numero;
        }
        public void SetAndar(int andar)
        {
            Andar = andar;
        }
        public int GetAndar()
        {
            return Andar;
        }
        public void SetTipoDeQuarto(TipoDeQuarto tipoDeQuarto)
        {
            TipoDeQuarto = tipoDeQuarto;
        }
        public TipoDeQuarto GetTipoDeQuarto()
        {
            return TipoDeQuarto;
        }
    }
}