using ProjetoHotel.Lib.Exceptions;

namespace ProjetoHotel.Lib.Models
{
    public class Hotel : ModelBase
    {
        private string Nome { get; set; }
        private string Endereco { get; set; }
        private string Cep { get; set; }
        private string Descricao { get; set; }
        private string Telefone { get; set; }
        private string Email { get; set; }
        private DateTime HorarioCheckIn { get; set; }
        private DateTime HorarioCheckOut { get; set; }

        public Hotel(int id, string nome, string endereco, string cep, string descricao, string telefone, string email,
                     DateTime horarioCheckIn, DateTime horarioCheckOut, DateTime dataCadastro, DateTime dataUltimaAtualizacao)
                     : base(id, dataCadastro, dataUltimaAtualizacao)
        {
            Nome = nome;
            Endereco = endereco;
            Cep = cep;
            Descricao = descricao;
            SetTelefone(telefone);
            SetEmail(email);
            HorarioCheckIn = horarioCheckIn;
            HorarioCheckOut = horarioCheckOut;
        }

        public bool ValidarEmail(string email)
        {
            if (email.Contains("@"))
                return true;
            throw new ValidationErrorException("O email deve conter um @!");
        }

        public bool ValidarSeTelefoneTemNoMaximoQuatorzeCaracteres(string telefone)
        {
            if (telefone.Count() <= 14)
                return true;
            throw new ValidationErrorException("O telefone deve conter no máximo 14 caracteres!");
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }
        public string GetNome()
        {
            return Nome;
        }
        public void SetEndereco(string endereco)
        {
            Endereco = endereco;
        }
        public string GetEndereco()
        {
            return Endereco;
        }
        public void SetCep(string cep)
        {
            Cep = cep;
        }
        public string GetCep()
        {
            return Cep;
        }
        public void SetDescricao(string descricao)
        {
            Descricao = descricao;
        }
        public string GetDescricao()
        {
            return Descricao;
        }
        public void SetTelefone(string telefone)
        {
            ValidarSeTelefoneTemNoMaximoQuatorzeCaracteres(telefone);
            Telefone = telefone;
        }
        public string GetTelefone()
        {
            return Telefone;
        }
        public void SetEmail(string email)
        {
            ValidarEmail(email);
            Email = email;
        }
        public string GetEmail()
        {
            return Email;
        }
        public void SetHorarioCheckIn(DateTime horarioCheckIn)
        {
            HorarioCheckIn = horarioCheckIn;
        }
        public DateTime GetHorarioCheckIn()
        {
            return HorarioCheckIn;
        }
        public void SetDataHorarioCheckOut(DateTime horarioCheckOut)
        {
            HorarioCheckOut = horarioCheckOut;
        }
        public DateTime GetHorarioCheckOut()
        {
            return HorarioCheckOut;
        }
    }
}