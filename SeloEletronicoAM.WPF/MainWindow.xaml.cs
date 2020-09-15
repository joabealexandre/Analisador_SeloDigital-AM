using SeloEletronicoAM.Controllers;
using SeloEletronicoAM.CSV;
using SeloEletronicoAM.JSON;
using SeloEletronicoAM.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SeloEletronicoAM.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly LeitorCSV _leitorCSV;
        private readonly LeitorJSON _leitorJSON;
        private readonly SeloController _seloCtrl;

        public MainWindow()
        {
            InitializeComponent();
            _leitorCSV = new LeitorCSV();
            _leitorJSON = new LeitorJSON();
            _seloCtrl = new SeloController(@"https://cidadao.portalseloam.com.br/portal-selo/selos/consulta");

        }

        private async void btnImportarCsvSeladora_Click(object sender, RoutedEventArgs e)
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
                selosList = _leitorCSV.LerSelos(caminho);
            }
            else
            {
                string json = File.ReadAllText(caminho);
                selosList = _leitorJSON.LerSelos(json);
            }

            HashSet<Selo> selosHash = new HashSet<Selo>();
            foreach (var selo in selosList)
                selosHash.Add(selo);

            Console.WriteLine($"Quantidade de selos no csv                      - {selosList.Count}");
            Console.WriteLine($"Quantidade de selos no csv (sem duplicidades)   - {selosHash.Count}");
            Console.WriteLine("\n\nImportando selos, aguarde ...\n\n");

            string jsonSelos = await _seloCtrl.BuscarJSONSelosNaApiSeladora(selosHash.ToList());
            File.WriteAllText("selosApi.json", jsonSelos);
        }
    }
}
