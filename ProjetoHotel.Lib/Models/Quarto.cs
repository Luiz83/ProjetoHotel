namespace ProjetoHotel.Lib.Models
{
    public class Quarto : ModelBase
    {
        private int Numero { get; set; }
        private int Andar { get; set; }
        public Hotel Hotel { get; private set; }
        public TipoDeQuarto TipoDeQuarto { get; private set; }
        public int IdTipoQuarto { get; set; }
        public int IdHotel { get; set; }
        public List<Estadia> ListaDeEstadia { get; set; }

        public Quarto(int id, int numero, int andar, TipoDeQuarto tipoDeQuarto, DateTime dataCadastro, DateTime dataUltimaAtualizacao)
        {
            Id = id;
            DataCadastro = dataCadastro;
            DataUltimaAtualizacao = dataUltimaAtualizacao;
            Numero = numero;
            Andar = andar;
            TipoDeQuarto = tipoDeQuarto;
        }
        public Quarto()
        {

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
        public void SetHotel(Hotel hotel)
        {
            Hotel = hotel;
        }
        public Hotel GetHotel()
        {
            return Hotel;
        }
    }
}