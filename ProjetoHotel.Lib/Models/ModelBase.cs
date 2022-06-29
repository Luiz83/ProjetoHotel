using ProjetoHotel.Lib.Exceptions;

namespace ProjetoHotel.Lib.Models
{
    public class ModelBase
    {
        protected int Id { get; set; }
        protected DateTime DataCadastro { get; set; }
        protected DateTime DataUltimaAtualizacao { get; set; }

        public ModelBase(int id, DateTime dataCadastro, DateTime dataUltimaAtualizacao)
        {
            Id = id;
            DataCadastro = dataCadastro;
            DataUltimaAtualizacao = dataUltimaAtualizacao;
        }

        public bool ValidarSeUltimaAtualizacaoEMaiorQueDataCadastro(DateTime lastUpdate)
        {
            if (lastUpdate >= DataCadastro)
                return true;
            throw new ValidationErrorException("A data da última atualização não pode ser menor que a de cadastro!");
        }
        public void SetId(int id)
        {
            Id = id;
        }
        public int GetId()
        {
            return Id;
        }
        public void SetDataCadastro(DateTime dataCadastro)
        {
            DataCadastro = dataCadastro;
        }
        public DateTime GetDataCadastro()
        {
            return DataCadastro;
        }
        public void SetDataUltimaAtualizacao(DateTime dataUltimaAtualizacao)
        {
            ValidarSeUltimaAtualizacaoEMaiorQueDataCadastro(dataUltimaAtualizacao);
            DataUltimaAtualizacao = dataUltimaAtualizacao;
        }
        public DateTime GetDataUltimaAtualizacao()
        {
            return DataUltimaAtualizacao;
        }
    }
}