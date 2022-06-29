using ProjetoHotel.Lib.Exceptions;

namespace ProjetoHotel.Lib.Models
{
    public class TipoDeQuarto : ModelBase
    {
        private string Nome { get; set; }
        private string Descricao { get; set; }
        private int OcupacaoMaxima { get; set; }
        private int CamaCasal { get; set; }
        private int CamaSolteiro { get; set; }
        private double Valor { get; set; }

        public TipoDeQuarto(int id, string nome, string descricao, int ocupacaoMaxima, int camaCasal, int camaSolteiro, double valor,
                            DateTime dataCadastro, DateTime dataUltimaAtualizacao) : base(id, dataCadastro, dataUltimaAtualizacao)
        {
            Nome = nome;
            Descricao = descricao;
            CamaCasal = camaCasal;
            CamaSolteiro = camaSolteiro;
            SetOcupacaoMaxima(ocupacaoMaxima);
            Valor = valor;
        }

        public bool ValidarOcupacaoMaximaPermitida(int ocupacao)
        {
            if (ocupacao <= ((CamaCasal * 2) + CamaSolteiro))
                return true;
            throw new ValidationErrorException("A ocupação máxima não pode exceder o limite de pessoas por cama!");
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }
        public string GetNome()
        {
            return Nome;
        }
        public void SetDescricao(string descricao)
        {
            Descricao = descricao;
        }
        public string GetDescricao()
        {
            return Descricao;
        }
        public void SetOcupacaoMaxima(int ocupacaoMaxima)
        {
            ValidarOcupacaoMaximaPermitida(ocupacaoMaxima);
            OcupacaoMaxima = ocupacaoMaxima;
        }
        public int GetOcupacaoMaxima()
        {
            return OcupacaoMaxima;
        }
        public void SetCamaCasal(int camaCasal)
        {
            CamaCasal = camaCasal;
        }
        public int GetCamaCasal()
        {
            return CamaCasal;
        }
        public void SetCamaSolteiro(int camaSolteiro)
        {
            CamaSolteiro = camaSolteiro;
        }
        public int GetCamaSolteiro()
        {
            return CamaSolteiro;
        }
        public void SetValor(double valor)
        {
            Valor = valor;
        }
        public double GetValor()
        {
            return Valor;
        }
    }
}