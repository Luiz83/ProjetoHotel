using ProjetoHotel.Lib.Exceptions;

namespace ProjetoHotel.Lib.Models
{
    public class Hospede : ModelBase
    {
        private string Nome { get; set; }
        private string Telefone { get; set; }
        private string Cpf { get; set; }
        private string Email { get; set; }
        private DateTime DataNascimento { get; set; }

        public Hospede(int id, string nome, string telefone, string cpf, string email, DateTime dataNascimento, DateTime dataCadastro,
                       DateTime dataUltimaAtualizacao) : base(id, dataCadastro, dataUltimaAtualizacao)
        {
            SetNome(nome);
            SetTelefone(telefone);
            SetCpf(cpf);
            SetEmail(email);
            SetDataNacimento(dataNascimento);
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

        public bool ValidarSeCpfSoPossuiNumeros(string cpf)
        {
            if (cpf.All(char.IsDigit))
                return true;
            throw new ValidationErrorException("Cpf só deve conter números!");
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }
        public string GetNome()
        {
            return Nome;
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
        public void SetCpf(string cpf)
        {
            ValidarSeCpfSoPossuiNumeros(cpf);
            Cpf = cpf;
        }
        public string GetCpf()
        {
            return Cpf;
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
        public void SetDataNacimento(DateTime dataNascimento)
        {
            DataNascimento = dataNascimento;
        }
        public DateTime GetDataNascimento()
        {
            return DataNascimento;
        }
    }
}