namespace ProjetoHotel.Lib.Models
{
    public class ServicoXHotel : ModelBase
    {
        private Hotel Hotel { get; set; }
        private Servico Servico { get; set; }

        public ServicoXHotel(int id, Hotel hotel, Servico servico, DateTime dataCadastro, DateTime dataUltimaAtualizacao) : base(id, dataCadastro, dataUltimaAtualizacao)
        {
            Hotel = hotel;
            Servico = servico;
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