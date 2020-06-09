using SeloEletronicoAM.JSON;
using SeloEletronicoAM.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SeloEletronicoAM.Testes.JSON
{
    public class EscritorJSONTests
    {
        private Selo _selo = null;

        public EscritorJSONTests()
        {
            _selo = new Selo
            {
                AtoTabela = new AtoTabela { Emolumento = 1, Farpam = 1, Fundpam = 1, Fundpge = 1, Funetj = 1 },
                Codigo = "1",
                InfoIsento = new InfoIsento { Isento = false }
            };
        }

        //[Fact]
        //public void Deve_Gerar_Um_JSON_De_Um_Selo()
        //{
        //    //Arranje
        //    EscritorJSON escritor = new EscritorJSON();

        //    //Act
        //    var resultado = escritor.CriarJsonSelo(_selo);

        //    //Assert
        //    Assert.Equal(_selo.Codigo, resultado)
        //}
    }
}
