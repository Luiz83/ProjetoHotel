namespace ProjetoHotel.Lib.Models
{
    public class Servico : ModelBase
    {
        private string Nome { get; set; }

        public List<ServicoXHotel> ServicoXHotelList { get; set; }

        public Servico(int id, string nome, DateTime dataCadastro, DateTime dataUltimaAtualizacao)
        {
            Id = id;
            DataCadastro = dataCadastro;
            DataUltimaAtualizacao = dataUltimaAtualizacao;
            Nome = nome;
        }
        Servico()
        {

        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }
        public string GetNome()
        {
            return Nome;
        }
    }
}