using System;
using ProjetoHotel.Lib.Exceptions;
using ProjetoHotel.Lib.Models;
using Xunit;

namespace ProjetoHotel.Test
{
    public class HospedeTest
    {
        [Fact]
        public void TestarSeEmailDeveSerValido()
        {
            //Arrange
            var valorEsperado = "testeemail.com";
            var hospede = CriarHospedePadrao();

            //Act e Assert
            var exception = Assert.Throws<ValidationErrorException>(() => hospede.SetEmail(valorEsperado));
            Assert.Equal("O email deve conter um @!", exception.Message);
        }
        [Fact]
        public void TestarSeTelefoneTemMenosQueQuatorzeCaracteres()
        {
            //Arrange
            var valorEsperado = "(11)4444-55556666";
            var hospede = CriarHospedePadrao();

            //Act e Assert
            var exception = Assert.Throws<ValidationErrorException>(() => hospede.SetTelefone(valorEsperado));
            Assert.Equal("O telefone deve conter no máximo 14 caracteres!", exception.Message);
        }
        [Fact]
        public void TestarSeCpfSoTemNumeros()
        {
            //Arrange
            var valorEsperado = "444.555.666-45";
            var hospede = CriarHospedePadrao();

            //Act e Assert
            var exception = Assert.Throws<ValidationErrorException>(() => hospede.SetCpf(valorEsperado));
            Assert.Equal("Cpf só deve conter números!", exception.Message);
        }
        public Hospede CriarHospedePadrao()
        {
            return new Hospede(1, "Luiz", "(11)4444-5555", "11122233345", "teste@email.com", DateTime.Parse("30/04/1998"), DateTime.Now, DateTime.Now);
        }
    }
}