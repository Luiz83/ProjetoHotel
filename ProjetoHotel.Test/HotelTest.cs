using System;
using ProjetoHotel.Lib.Exceptions;
using ProjetoHotel.Lib.Models;
using Xunit;

namespace ProjetoHotel.Test
{
    public class HotelTest
    {
        /*[Fact]
        public void TestarSeEmailDeveSerValido()
        {
            //Arrange
            var valorEsperado = "testeemail.com";
            var hotel = CriarHotelPadrao();

            //Act e Assert
            var exception = Assert.Throws<ValidationErrorException>(() => hotel.SetEmail(valorEsperado));
            Assert.Equal("O email deve conter um @!", exception.Message);
        }
        [Fact]
        public void TestarSeTelefoneTemMenosQueQuatorzeCaracteres()
        {
            //Arrange
            var valorEsperado = "(11)4444-55556666";
            var hotel = CriarHotelPadrao();

            //Act e Assert
            var exception = Assert.Throws<ValidationErrorException>(() => hotel.SetTelefone(valorEsperado));
            Assert.Equal("O telefone deve conter no máximo 14 caracteres!", exception.Message);
        }
        public Hotel CriarHotelPadrao()
        {
            return new Hotel(1, "Hotel Uma Estrela", "Rua dos bobos", "33355000", "Hotel muito bom!", "(11)4444-5555", "teste@email.com", DateTime.Parse("12:00:00"), DateTime.Parse("23:00:00"), DateTime.Now, DateTime.Now);
        }*/
    }
}