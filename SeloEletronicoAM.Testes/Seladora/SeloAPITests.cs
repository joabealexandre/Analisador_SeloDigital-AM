using SeloEletronicoAM.Seladora;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SeloEletronicoAM.Testes.Seladora
{
    public class SeloAPITests
    {
        private readonly string _codSelo = null;
        private readonly string _apiUrl = null;

        public SeloAPITests()
        {
            _codSelo = "PAGPRT005041MU7KWTT3DU0ANM01";
            _apiUrl = @"https://cidadao.portalseloam.com.br/portal-selo/selos/consulta";
        }

        [Fact]
        public async void Deve_Ler_Um_Selo_Da_Api()
        {
            //Arranje
            SeloAPI apiSeladora = new SeloAPI(_apiUrl);

            //Act
            var selo = await apiSeladora.LerSelo(_codSelo);

            //Assert
            Assert.Equal(_codSelo, selo.Codigo);
        }
    }
}
