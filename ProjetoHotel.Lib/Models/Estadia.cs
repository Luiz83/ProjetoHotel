using ProjetoHotel.Lib.Exceptions;

namespace ProjetoHotel.Lib.Models
{
    public class Estadia : ModelBase
    {
        private Hospede Responsavel { get; set; }
        private Quarto Quarto { get; set; }
        private DateTime DataEntrada { get; set; }
        private DateTime DataSaida { get; set; }

        public Estadia(int id, Hospede responsavel, Quarto quarto, DateTime dataEntrada, DateTime dataSaida,
                       DateTime dataCadastro, DateTime dataUltimaAtualizacao) : base(id, dataCadastro, dataUltimaAtualizacao)
        {
            Responsavel = responsavel;
            Quarto = quarto;
            DataEntrada = dataEntrada;
            SetDataSaida(dataSaida);
        }

        public bool ValidarDataDeSaida(DateTime saida)
        {
            if (saida > DataEntrada)
                return true;
            throw new ValidationErrorException("A data de saida deve ser maior que a de entrada!");
        }
        public void SetResponsavel(Hospede responsavel)
        {
            Responsavel = responsavel;
        }
        public Hospede GetResponsavel()
        {
            return Responsavel;
        }
        public void SetQuarto(Quarto quarto)
        {
            Quarto = quarto;
        }
        public Quarto GetQuarto()
        {
            return Quarto;
        }
        public void SetDataEntrada(DateTime dataEntrada)
        {
            DataEntrada = dataEntrada;
        }
        public DateTime GetDataEntrada()
        {
            return DataEntrada;
        }
        public void SetDataSaida(DateTime dataSaida)
        {
            ValidarDataDeSaida(dataSaida);
            DataSaida = dataSaida;
        }
        public DateTime GetDataSaida()
        {
            return DataSaida;
        }
    }
}