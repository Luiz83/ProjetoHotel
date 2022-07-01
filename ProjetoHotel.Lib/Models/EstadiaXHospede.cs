namespace ProjetoHotel.Lib.Models
{
    public class EstadiaXHospede : ModelBase
    {
        public Estadia Estadia { get; private set; }
        public Hospede Hospede { get; private set; }
        public int IdHospede { get; set; }
        public int IdEstadia { get; set; }

        public EstadiaXHospede(int id, Estadia estadia, Hospede hospede, DateTime dataCadastro, DateTime dataUltimaAtualizacao)

        {
            Id = id;
            DataCadastro = dataCadastro;
            DataUltimaAtualizacao = dataUltimaAtualizacao;
            Estadia = estadia;
            Hospede = hospede;
        }
        public EstadiaXHospede()
        {

        }
        public void SetEstadia(Estadia estadia)
        {
            Estadia = estadia;
        }
        public Estadia GetEstadia()
        {
            return Estadia;
        }
        public void SetHospede(Hospede hospede)
        {
            Hospede = hospede;
        }
        public Hospede GetHospede()
        {
            return Hospede;
        }
    }
}