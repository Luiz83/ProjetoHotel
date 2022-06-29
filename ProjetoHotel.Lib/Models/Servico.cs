namespace ProjetoHotel.Lib.Models
{
    public class Servico : ModelBase
    {
        private string Nome { get; set; }

        public Servico(int id, string nome, DateTime dataCadastro, DateTime dataUltimaAtualizacao) : base(id, dataCadastro, dataUltimaAtualizacao)
        {
            Nome = nome;
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