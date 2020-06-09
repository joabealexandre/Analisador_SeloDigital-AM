using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SeloEletronicoAM.Controllers;
using SeloEletronicoAM.JSON;
using SeloEletronicoAM.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SeloEletronicoAM.Testes.Controllers
{
    public class SeloControllerTests
    {
        private SeloController _seloController = null;
        private LeitorJSON _leitorJSON = null;
        private readonly string _caminhoJson = null;
        private string _json = null;
        private dynamic _jsonDynamic = null;
        private readonly string _apiUrl = @"https://cidadao.portalseloam.com.br/portal-selo/selos/consulta";

        public SeloControllerTests()
        {
            _seloController = new SeloController(_apiUrl);
            _leitorJSON = new LeitorJSON();
            _caminhoJson = Path.Combine(Environment.CurrentDirectory, "Controllers", "Resources", "selo-certidao.json");
            _json = File.ReadAllText(_caminhoJson);
            _jsonDynamic = DeserializarArquivoJson();
            _apiUrl = @"https://cidadao.portalseloam.com.br/portal-selo/selos/consulta";
        }

        [Fact]
        public void Bool_Deve_Comparar_Selos_Com_Valor_De_Fundos_Diferentes()
        {
            //Arrange
            var seloCorreto = _leitorJSON.LerSelo(_json);
            var seloIncorreto = _leitorJSON.LerSelo(_json);
            seloIncorreto.AtoTabela.Farpam = 0;

            //Act
            bool resultado = _seloController.ValorFundosIguais(seloCorreto, seloIncorreto);

            //Assert
            Assert.False(resultado);
        }

        private dynamic DeserializarArquivoJson() => JsonConvert.DeserializeObject<ExpandoObject>(_json, new ExpandoObjectConverter());
    }
}
