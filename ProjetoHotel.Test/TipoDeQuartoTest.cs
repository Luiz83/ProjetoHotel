using System;
using ProjetoHotel.Lib.Exceptions;
using ProjetoHotel.Lib.Models;
using Xunit;

namespace ProjetoHotel.Test
{
    public class TipoDeQuartoTest
    {
        [Fact]
        public void TestarSeOcupacaoMaximaEValida()
        {
            //Arrange
            var valorEsperado = 5;
            var tipoDeQuarto = CriarTipoDeQuartoPadrao();

            //Act e Assert
            var exception = Assert.Throws<ValidationErrorException>(() => tipoDeQuarto.SetOcupacaoMaxima(valorEsperado));
            Assert.Equal("A ocupação máxima não pode exceder o limite de pessoas por cama!", exception.Message);
        }
        public TipoDeQuarto CriarTipoDeQuartoPadrao()
        {
            return new TipoDeQuarto(1, "Standart Casal", "Quarto simples para casal", 2, 1, 0, 150, DateTime.Now, DateTime.Now);
        }
    }
}