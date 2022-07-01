namespace ProjetoHotel.Lib.Models
{
    public class ServicoXHotel : ModelBase
    {
        public Hotel Hotel { get; private set; }
        public Servico Servico { get; private set; }
        public int IdServico { get; set; }
        public int IdHotel { get; set; }

        public ServicoXHotel(int id, Hotel hotel, Servico servico, DateTime dataCadastro, DateTime dataUltimaAtualizacao)
        {
            Id = id;
            DataCadastro = dataCadastro;
            DataUltimaAtualizacao = dataUltimaAtualizacao;
            Hotel = hotel;
            Servico = servico;
        }
        public ServicoXHotel()
        {

        }
        public void SetHotel(Hotel hotel)
        {
            Hotel = hotel;
        }
        public Hotel GetHotel()
        {
            return Hotel;
        }
        public void SetServico(Servico servico)
        {
            Servico = servico;
        }
        public Servico GetServico()
        {
            return Servico;
        }
    }
}