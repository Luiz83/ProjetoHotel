using System.Text.Json.Serialization;
using ProjetoHotel.Lib.Exceptions;

namespace ProjetoHotel.Lib.Models
{
    public class Hotel : ModelBase
    {
        [JsonPropertyName("nome")]
        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public string Cep { get; private set; }
        public string Descricao { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public TimeOnly HorarioCheckIn { get; private set; }
        public TimeOnly HorarioCheckOut { get; private set; }
        public List<ServicoXHotel> ListaDeServicoXHotel { get; set; }
        public List<Quarto> ListaDeQuarto { get; set; }

        public Hotel(int id, string nome, string endereco, string cep, string descricao, string telefone, string email,
                     TimeOnly horarioCheckIn, TimeOnly horarioCheckOut, DateTime dataCadastro, DateTime dataUltimaAtualizacao)

        {
            Id = id;
            DataCadastro = dataCadastro;
            DataUltimaAtualizacao = dataUltimaAtualizacao;
            Nome = nome;
            Endereco = endereco;
            Cep = cep;
            Descricao = descricao;
            SetTelefone(telefone);
            SetEmail(email);
            HorarioCheckIn = horarioCheckIn;
            HorarioCheckOut = horarioCheckOut;
        }
        public Hotel()
        {

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
        public void SetHorarioCheckIn(TimeOnly horarioCheckIn)
        {
            HorarioCheckIn = horarioCheckIn;
        }
        public TimeOnly GetHorarioCheckIn()
        {
            return HorarioCheckIn;
        }
        public void SetDataHorarioCheckOut(TimeOnly horarioCheckOut)
        {
            HorarioCheckOut = horarioCheckOut;
        }
        public TimeOnly GetHorarioCheckOut()
        {
            return HorarioCheckOut;
        }
    }
}