using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SeloEletronicoAM.CSV;
using SeloEletronicoAM.JSON;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Text;
using System.Text.Json;
using Xunit;

namespace SeloEletronicoAM.Testes.JSON
{
    public class LeitorJSONTests
    {
        private readonly string _caminhoJson = Path.Combine(Environment.CurrentDirectory, "JSON", "Resources", "selo-certidao.json");
        private string _json = null;
        private dynamic _jsonDynamic = null;
        private LeitorJSON leitor;

        public LeitorJSONTests()
        {
            this._json = File.ReadAllText(_caminhoJson);
            _jsonDynamic = DeserializarArquivoJson();
        }

        private dynamic DeserializarArquivoJson() => JsonConvert.DeserializeObject<ExpandoObject>(_json, new ExpandoObjectConverter());

        [Fact]
        public void Deve_Ler_Um_Selo()
        {
            //Arranje
            leitor = new LeitorJSON();

            //Act
            var selo = leitor.LerSelo(_json);

            //Assert
            Assert.Equal(_jsonDynamic.selo.codSelo, selo.Codigo);
        }

        [Fact]
        public void Deve_Ler_Dois_Selos()
        {
            //Arranje
            leitor = new LeitorJSON();

            //Act
            var selo = leitor.LerSelo(_json);

            //Assert
            Assert.Equal(_jsonDynamic.selo.codSelo, selo.Codigo);
        }
    }
}
