using SeloEletronicoAM.CSV;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace SeloEletronicoAM.Testes.CSV
{
    public class LeitorCSVTests
    {
        private LeitorCSV leitor;
        private string path;

        public LeitorCSVTests()
        {
            leitor = new LeitorCSV();
            path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CSV", "Resources", "SELOS-Apenas1Selo.csv");
        }

        [Fact]
        public void LerSelos_DeveLerArquivoComUmSelo()
        {
            //Act
            var resultado = leitor.LerSelos(path);

            //Assert
            Assert.True(resultado.Count == 1);
        }
    }
}
