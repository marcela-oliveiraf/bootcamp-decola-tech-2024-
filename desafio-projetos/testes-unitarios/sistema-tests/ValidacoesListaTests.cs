using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace sistema_tests{
    public class ValidacoesListaTests{
        private ValidacoesLista _validacoes = new ValidacoesLista();

        [Fact]
        public void DeveRemoverNumerosNegativosDeUmaLista(){
            // Arrange
            var lista = new List<int> { 5, -1, -8, 9 };
            var resultadoEsperado = new List<int> { 5, 9 };

            // Act
            var resultado = _validacoes.RemoverNumerosNegativos(lista);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void DeveConterONumero9NaLista(){
            // Arrange
            var lista = new List<int> { 5, -1, -8, 9 };
            var numeroParaProcurar = 9;

            // Act
            var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

            // Assert
            Assert.True(resultado);
        }

        [Fact]
        public void NaoDeveConterONumero10NaLista(){
            //TODO: Implementar método de teste

            // Arrange
            var lista = new List<int> { 5, -1, -8, 9 };
            var numeroParaProcurar = 10;

            // Act

            // Assert
        }

        //TODO: Corrigir a anotação [Fact]
        public void DeveMultiplicarOsElementosDaListaPor2(){
            //TODO: Implementar método de teste

            // Arrange
            var lista = new List<int> { 5, 7, 8, 9 };
            var resultadoEsperado = new List<int> { 10, 14, 16, 18 };
            
            // Act

            // Assert
        }

        [Fact]
        public void DeveRetornar9ComoMaiorNumeroDaLista(){
            //TODO: Implementar método de teste

            // Arrange
            var lista = new List<int> { 5, -1, -8, 9 };

            // Act

            // Assert
            //TODO: Corrigir o Assert.Equal com base no retorno da chamada ao método
            Assert.Equal(9, 9);
        }

        [Fact]
        public void DeveRetornarOitoNegativoComoMenorNumeroDaLista(){
            //TODO: Implementar método de teste

            // Arrange
            var lista = new List<int> { 5, -1, -8, 9 };

            // Act
            var resultado = _validacoes.RetornarMenorNumeroLista(lista);

            // Assert
            //TODO: Corrigir o Assert.Equal com base no retorno da chamada ao método
            Assert.Equal(-8, -8);
        }
    }
}