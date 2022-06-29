namespace ProjetoHotel.Lib.Models
{
    public class EstadiaXHospede : ModelBase
    {
        private Estadia Estadia { get; set; }
        private Hospede Hospede { get; set; }

        public EstadiaXHospede(int id, Estadia estadia, Hospede hospede, DateTime dataCadastro, DateTime dataUltimaAtualizacao) : 
                               base(id, dataCadastro, dataUltimaAtualizacao)
        {
            Estadia = estadia;
            Hospede = hospede;
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