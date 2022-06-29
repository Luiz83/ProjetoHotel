using System;
using ProjetoHotel.Lib.Exceptions;
using ProjetoHotel.Lib.Models;
using Xunit;

namespace ProjetoHotel.Test
{
    public class EstadiaTest
    {
        [Fact]
        public void TestarSeOcupacaoMaximaEValida()
        {
            //Arrange
            var valorEsperado = DateTime.Parse("01/01/0001");
            var estadia = CriarEstadiaPadrao();

            //Act e Assert
            var exception = Assert.Throws<ValidationErrorException>(() => estadia.SetDataSaida(valorEsperado));
            Assert.Equal("A data de saida deve ser maior que a de entrada!", exception.Message);
        }
        public Estadia CriarEstadiaPadrao()
        {
            var hospede = new Hospede(1, "Luiz", "(11)4444-5555", "11122233345", "teste@email.com", DateTime.Parse("30/04/1998"), DateTime.Now, DateTime.Now);
            var tipoDeQuarto = new TipoDeQuarto(1, "Standart Casal", "Quarto simples para casal", 2, 1, 0, 150, DateTime.Now, DateTime.Now);
            var quarto = new Quarto(1, 22, 2, tipoDeQuarto, DateTime.Now, DateTime.Now);
            return new Estadia(1, hospede, quarto, DateTime.Parse("02/01/0001"), DateTime.Parse("03/01/0001"), DateTime.Now, DateTime.Now);
        }
    }
}