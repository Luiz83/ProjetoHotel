using ProjetoHotel.Lib.Exceptions;

namespace ProjetoHotel.Lib.Models
{
    public class Estadia : ModelBase
    {
        public Hospede? Responsavel { get; private set; }
        public Quarto? Quarto { get; private set; }
        public DateTime DataEntrada { get; private set; }
        public DateTime DataSaida { get; private set; }
        public int IdQuarto { get; set; }
        public int IdResponsavel { get; set; }
        public List<EstadiaXHospede> ListaDeEstadiaXHospede { get; set; }

        public Estadia(int id, Hospede responsavel, Quarto quarto, DateTime dataEntrada, DateTime dataSaida,
                       DateTime dataCadastro, DateTime dataUltimaAtualizacao)
        {
            Id = id;
            DataCadastro = dataCadastro;
            DataUltimaAtualizacao = dataUltimaAtualizacao;
            Responsavel = responsavel;
            Quarto = quarto;
            DataEntrada = dataEntrada;
            SetDataSaida(dataSaida);
        }

        public Estadia()
        {

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