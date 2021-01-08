using SeloEletronicoAM.Controllers;
using SeloEletronicoAM.CSV;
using SeloEletronicoAM.JSON;
using SeloEletronicoAM.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SelosAM.ConsoleApp
{
    public class Program
    {
        private static readonly LeitorCSV leitorCSV = new LeitorCSV();
        private static readonly LeitorJSON leitorJSON = new LeitorJSON();
        private static readonly SeloController seloCtrl = new SeloController(@"https://cidadao.portalseloam.com.br/portal-selo/selos/consulta");

        public static void Main(string[] args)
        {
            MainAsync().Wait();
        }

        /// <summary>
        /// Ler um arquivo e retornar uma lista com os selos identificados
        /// </summary>
        /// <param name="msg">Mensagem a ser apresentada</param>
        /// <returns></returns>
        public static IList<Selo> LerArquivoSelo(string msg)
        {
            Console.Clear();
            string caminho;

            do
            {
                Console.WriteLine(msg);
                caminho = Console.ReadLine();

            } while (!File.Exists(caminho));

            FileInfo info = new FileInfo(caminho);

            if (info.Extension.ToLower() == ".csv")
            {
                return leitorCSV.LerSelos(caminho);
            }
            else if (info.Extension.ToLower() == ".json")
            {
                return leitorJSON.LerSelos(File.ReadAllText(caminho));
            }

            return null;
        }

        public static async Task ImportarCsvSeladora()
        {
            Console.Clear();

            string caminho;
            do
            {
                Console.WriteLine("Informe o caminho do arquivo (JSON/CSV): ");
                caminho = Console.ReadLine();

            } while (!File.Exists(caminho));

            var info = new FileInfo(caminho);

            IList<Selo> selosList;
            if (info.Extension.ToLower() == ".csv")
            {
                selosList = leitorCSV.LerSelos(caminho);
            }
            else
            {
                string json = File.ReadAllText(caminho);
                selosList = leitorJSON.LerSelos(json);
            }

            HashSet<Selo> selosHash = new HashSet<Selo>();
            foreach (var selo in selosList)
                selosHash.Add(selo);

            Console.WriteLine($"Quantidade de selos no csv                      - {selosList.Count}");
            Console.WriteLine($"Quantidade de selos no csv (sem duplicidades)   - {selosHash.Count}");
            Console.WriteLine("\n\nImportando selos, aguarde ...\n\n");

            string jsonSelos = await seloCtrl.BuscarJSONSelosNaApiSeladora(selosHash.ToList());
            File.WriteAllText("selosApi.json", jsonSelos);
        }

        public static void CompararSelosSalvarJson()
        {
            IList<Selo> selosUm = LerArquivoSelo("Informe o caminho do 1º arquivo (JSON/CSV)");
            IList<Selo> selosDois = LerArquivoSelo("Informe o caminho do 2º arquivo (JSON/CSV)");

            var resultado = seloCtrl.CompararSelosValorFundosRetornaJSON(selosUm, selosDois);
            File.WriteAllText("selosDiferentes.json", resultado);
        }

        public static void CompararSelosExtrairAnalise()
        {
            IList<Selo> selosUm = LerArquivoSelo("Informe o caminho do 1º arquivo (JSON/CSV)");
            IList<Selo> selosDois = LerArquivoSelo("Informe o caminho do 2º arquivo (JSON/CSV)");

            //var resultado = seloCtrl.CompararSelosGerarCSV(selosUm, selosDois);
            //File.WriteAllText("selosDivergentes.csv", resultado);
        }

        public static async Task MainAsync()
        {
            string opcao = "";

            Console.WriteLine("LEITOR DE SELOS AM");
            Console.WriteLine("");

            Console.WriteLine("Escolha a opção desejada:");
            Console.WriteLine("1 - Importar CSV da seladora");
            Console.WriteLine("2 - Comparar selos (Salvar resultado em JSON)");
            Console.WriteLine("3 - Comparar selos (Salvar resultado em CSV)");
            Console.WriteLine("4 - Sair\n");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                #region 1 - Importar CSV da seladora
                case "1":
                    await ImportarCsvSeladora();
                    break;
                #endregion

                # region 2 - Comparar selos (Salvar resultado em JSON)
                case "2":
                    CompararSelosSalvarJson();
                    break;
                #endregion

                #region 3 - Comparar selos (Salvar resultado em CSV)
                case "3":
                    CompararSelosExtrairAnalise();
                    break;
                #endregion

                default:
                    break;
            }
        }
    }
}
