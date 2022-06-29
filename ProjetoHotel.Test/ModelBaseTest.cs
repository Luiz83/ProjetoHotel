using System;
using ProjetoHotel.Lib.Exceptions;
using ProjetoHotel.Lib.Models;
using Xunit;

namespace ProjetoHotel.Test
{
    public class ModelBaseTest
    {
        [Fact]
        public void TestarDataUltimaAtualizacaoEMaiorQueDataCadastro()
        {
            //Arrange
            var valorEsperado = DateTime.Parse("01/01/0001");
            var modelBase = CriarModelBasePadrao();

            //Act e Assert
            var exception = Assert.Throws<ValidationErrorException>(() => modelBase.SetDataUltimaAtualizacao(valorEsperado));
            Assert.Equal("A data da última atualização não pode ser menor que a de cadastro!", exception.Message);
        }
        public ModelBase CriarModelBasePadrao()
        {
            return new ModelBase(1, DateTime.Parse("02/01/0001"), DateTime.Parse("03/01/0001"));
        }
    }
}