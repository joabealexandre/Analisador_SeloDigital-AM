using SeloEletronicoAM.JSON;
using SeloEletronicoAM.Models;
using SeloEletronicoAM.Seladora;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SeloEletronicoAM.Controllers
{
    public class SeloController
    {
        private SeloAPI _apiSeladora = null;
        private EscritorJSON _escritorJSON = null;

        public SeloController(string url)
        {
            _apiSeladora = new SeloAPI(url);
            _escritorJSON = new EscritorJSON();
        }

        public string CompararSelosValorFundosRetornaJSON(IList<Selo> selos1, IList<Selo> selos2)
        {
            var resultado = CompararSelosValorFundos(selos1, selos2);
            var json = _escritorJSON.CriarJsonSelo(resultado);
            return json;
        }

        /// <summary>
        /// Criar dois dicionários com os selos a serem comparados
        /// </summary>
        /// <param name="selos1">Lista com selos 1</param>
        /// <param name="selos2">Lista com selos 2</param>
        /// <param name="dictioMenor">Dicionarios do selo com menor quantidade</param>
        /// <param name="dictioMaior">Dicionarios do selo com maior quantidade</param>
        public void RetornaDicionariosComSelos(IList<Selo> selos1, IList<Selo> selos2, 
            out Dictionary<string, Selo> dictioMenor, out Dictionary<string, Selo> dictioMaior)
        {
            Dictionary<string, Selo> selosDictionary1 = new Dictionary<string, Selo>();
            Dictionary<string, Selo> selosDictionary2 = new Dictionary<string, Selo>();

            ((List<Selo>)selos1).ForEach(s => selosDictionary1.Add(s.Codigo, s));
            ((List<Selo>)selos2).ForEach(s => selosDictionary2.Add(s.Codigo, s));

            if (selosDictionary1.Count < selosDictionary2.Count)
            {
                dictioMenor = selosDictionary1;
                dictioMaior = selosDictionary2;
            }
            else
            {
                dictioMenor = selosDictionary2;
                dictioMaior = selosDictionary1;
            }
        }

        public List<Selo> CompararSelosValorFundos(IList<Selo> selos1, IList<Selo> selos2)
        {
            List<Selo> selosDivergentes = new List<Selo>();
            RetornaDicionariosComSelos(selos1, selos2, out Dictionary<string, Selo> dictioMenor, out Dictionary<string, Selo> dictioMaior);

            foreach (KeyValuePair<string, Selo> item in dictioMenor)
            {
                /* TO DO: Validar se não houver selo correspondente no dicionário maior*/
                if (!ValorFundosIguais(item.Value, dictioMaior[item.Key]))
                {
                    selosDivergentes.Add(item.Value);
                }
            }

            return selosDivergentes;
        }

        public string CompararSelosGerarCSV(IList<Selo> selos1, IList<Selo> selos2)
        {
            var csv = new StringBuilder();
            decimal totalFarpam = 0;
            decimal totalFundpam = 0;
            decimal totalFundpge = 0;
            decimal totalFunetj = 0;
            RetornaDicionariosComSelos(selos1, selos2, out Dictionary<string, Selo> dictioMenor, out Dictionary<string, Selo> dictioMaior);

            foreach (KeyValuePair<string, Selo> item in dictioMenor)
            {
                /* TO DO: Validar se não houver selo correspondente no dicionário maior*/
                if (!ValorFundosIguais(item.Value, dictioMaior[item.Key]))
                {
                    AdicionarFundoArquivoCsv(csv, item.Value, dictioMaior[item.Key], totalFarpam, totalFundpam, totalFundpge, totalFunetj);
                }
            }
            return csv.ToString();
        }

        public void AdicionarFundoArquivoCsv(StringBuilder csv, Selo selo1, Selo selo2, decimal totalFarpam, decimal totalFundpam, decimal totalFundpge, decimal totalFunetj)
        {
            if (csv.Length == 0)
                AdicionarCabecalhoCsv(csv);

            totalFarpam = Math.Abs(selo1.AtoTabela.Farpam - selo2.AtoTabela.Farpam);
            totalFundpam = Math.Abs(selo1.AtoTabela.Fundpam - selo2.AtoTabela.Fundpam);
            totalFundpge = Math.Abs(selo1.AtoTabela.Fundpge - selo2.AtoTabela.Fundpge);
            totalFunetj = Math.Abs(selo1.AtoTabela.Funetj - selo2.AtoTabela.Funetj);

            var newLine = string.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10};{11};{12};{13};{14}",
                                        selo1.Codigo,
                                        selo1.AtoTabela.Farpam, selo2.AtoTabela.Farpam, totalFarpam,
                                        selo1.AtoTabela.Fundpam, selo2.AtoTabela.Fundpam, totalFundpam,
                                        selo1.AtoTabela.Fundpge, selo2.AtoTabela.Fundpge, totalFundpge,
                                        selo1.AtoTabela.Funetj, selo2.AtoTabela.Funetj, totalFunetj,
                                        selo1.InfoIsento.Isento, selo2.InfoIsento.Isento);
            csv.AppendLine(newLine);
        }

        /// <summary>
        /// Adiciona o cabeçalho do arquivo de análise CSV
        /// </summary>
        /// <param name="csv">StringBuilder com conteúdo do arquivo csv</param>
        private void AdicionarCabecalhoCsv(StringBuilder csv)
        {
            var newLine = string.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10};{11};{12};{13};{14}",
                                        "Codigo",
                                        "Farpam 1", "Farpam 2", "Diferenca Farpam",
                                        "Fundpam 1", "Fundpam 2", "Diferenca Fundpam",
                                        "Fundpge 1", "Fundpge 2", "Diferenca Fundpge",
                                        "Funetj 1", "Funetj 2", "Diferenca Funetj",
                                        "Isento 1", "Isento 2");

            csv.AppendLine(newLine);
        }

        public async Task<string> BuscarJSONSelosNaApiSeladora(IList<Selo> selos)
        {
            var selosList = await BuscarSelosNaApiSeladora(selos);
            var json = _escritorJSON.CriarJsonSelo(selosList);
            return json;
        }


        public async Task<List<Selo>> BuscarSelosNaApiSeladora(IList<Selo> selos)
        {
            List<Selo> selosList = new List<Selo>();

            foreach (var selo in selos)
            {
                var seloApi = await _apiSeladora.LerSelo(selo.Codigo);
                selosList.Add(seloApi);
                Console.WriteLine(selosList.Count);
            }

            return selosList;
        }

        /// <summary>
        /// Compara o valor total dos fundos de dois selos
        /// </summary>
        /// <param name="selo1">Selo 1</param>
        /// <param name="selo2">Selo 2</param>
        /// <param name="validarIsento">Flag para verificar se considera o campo "Isento" na comparação</param>
        /// <returns></returns>
        public bool ValorFundosIguais(Selo selo1, Selo selo2, bool validarIsento = true)
            => selo1.TotalValorFundos(validarIsento) == selo2.TotalValorFundos(validarIsento);



    }
}
