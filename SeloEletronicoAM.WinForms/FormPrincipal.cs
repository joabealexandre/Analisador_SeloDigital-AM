﻿using SeloEletronicoAM.Controllers;
using SeloEletronicoAM.CSV;
using SeloEletronicoAM.JSON;
using SeloEletronicoAM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeloEletronicoAM.WinForms
{
    public partial class form1 : Form
    {
        private readonly LeitorCSV _leitorCSV;
        private readonly LeitorJSON _leitorJSON;
        private readonly SeloController _seloCtrl;

        public form1()
        {
            InitializeComponent();
            _leitorCSV = new LeitorCSV();
            _leitorJSON = new LeitorJSON();
            _seloCtrl = new SeloController(@"https://cidadao.portalseloam.com.br/portal-selo/selos/consulta");
        }

        private void form1_Load(object sender, EventArgs e)
        {
            AjustarVisualizacaoFormulario();
        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (rb_ImportarCsvSeladora.Checked)
            {
                await ImportarCsvSeladora();
            }
            else if (rbCompararSelosSalvarCsv.Checked)
            {
                CompararSelosExtrairAnalise();
            }
            else if (rbCompararSelosSalvarJson.Checked)
            {
                CompararSelosSalvarJson();
            }
        }

        /// <summary>
        /// Ler um arquivo e retornar uma lista com os selos identificados
        /// </summary>
        /// <param name="msg">Caminho do arquivo de selos</param>
        /// <returns></returns>
        public IList<Selo> LerArquivoSelo(string caminho)
        {
            FileInfo info = new FileInfo(caminho);

            if (info.Extension.ToLower() == ".csv")
            {
                return _leitorCSV.LerSelos(caminho);
            }
            else if (info.Extension.ToLower() == ".json")
            {
                return _leitorJSON.LerSelos(File.ReadAllText(caminho));
            }

            return null;
        }

        public async Task ImportarCsvSeladora()
        {
            var info = new FileInfo(txtAbrirArquivo1.Text);

            IList<Selo> selosList;
            if (info.Extension.ToLower() == ".csv")
            {
                selosList = _leitorCSV.LerSelos(info.FullName);
            }
            else
            {
                string json = File.ReadAllText(info.FullName);
                selosList = _leitorJSON.LerSelos(json);
            }

            HashSet<Selo> selosHash = new HashSet<Selo>();
            foreach (var selo in selosList)
                selosHash.Add(selo);

            txtOutput.Text = "";
            txtOutput.Text += $"Quantidade de selos no csv - {selosList.Count}" + Environment.NewLine;
            txtOutput.Text += $"Quantidade de selos no csv (sem duplicidades) - {selosHash.Count}" + Environment.NewLine;

            string jsonSelos = await _seloCtrl.BuscarJSONSelosNaApiSeladora(selosHash.ToList());
            File.WriteAllText($"{fbd_SaveFile.SelectedPath}\\selosApi.json", jsonSelos);
        }

        public void CompararSelosSalvarJson()
        {
            IList<Selo> selosUm = LerArquivoSelo(txtAbrirArquivo1.Text);
            IList<Selo> selosDois = LerArquivoSelo(txtAbrirArquivo2.Text);

            var resultado = _seloCtrl.CompararSelosValorFundosRetornaJSON(selosUm, selosDois);
            File.WriteAllText($"{fbd_SaveFile.SelectedPath}\\selosDiferentes.json", resultado);
        }

        public void CompararSelosExtrairAnalise()
        {
            IList<Selo> selosUm = LerArquivoSelo(txtAbrirArquivo1.Text);
            IList<Selo> selosDois = LerArquivoSelo(txtAbrirArquivo2.Text);

            var resultado = _seloCtrl.CompararSelosGerarCSV(selosUm, selosDois);
            File.WriteAllText($"{fbd_SaveFile.SelectedPath}\\selosDivergentes.csv", resultado);
        }

        private void btn_abrirArquivo1_Click(object sender, EventArgs e)
        {
            SelecionarArquivo(txtAbrirArquivo1);
        }

        private void btn_abrirArquivo2_Click(object sender, EventArgs e)
        {
            SelecionarArquivo(txtAbrirArquivo2);
        }

        private void SelecionarArquivo(TextBox textBox)
        {
            ofd_AbrirArquivo.Filter = "Arquivo CSV/JSON| *.csv;*.json";
            ofd_AbrirArquivo.ShowDialog();
            textBox.Text = ofd_AbrirArquivo.FileName;
            ofd_AbrirArquivo.Reset();
        }

        private void btn_SalvarArquivo1_Click(object sender, EventArgs e)
        {
            fbd_SaveFile.ShowDialog();
            txtSalvarArquivo1.Text = fbd_SaveFile.SelectedPath;
        }

        private void AjustarVisualizacaoFormulario()
        {
            txtAbrirArquivo2.Enabled = !rb_ImportarCsvSeladora.Checked;
            btn_abrirArquivo2.Enabled = !rb_ImportarCsvSeladora.Checked;

            if (rb_ImportarCsvSeladora.Checked)
            {
                PreencherInstrucoesImportarSeladora();
                btnConfirmar.Text = "Importar";
            }
            else
            {
                PreencherInstrucoesCompararSelos();
                btnConfirmar.Text = "Comparar";
            }
        }

        private void PreencherInstrucoesImportarSeladora()
        {
            txtOutput.Text = "Importar CSV da seladora \n" +
                            "Essa opção importa os selos diretamente da base de dados do tribunal.\n" +
                            "\n" +
                            "Gere um arquivo CSV (utilizar o separador ;) utilizando o script sql disponibilizado na opção “Gerar script sql”.\n" +
                            "\n" +
                            "*** Importar selos ***\n" +
                            "\n" +
                            "1. Selecione o arquivo csv na primeira opção (\"Abrir arquivo\").\n" +
                            "2. Selecione o local de destino dos selos importados na segunda opção (\"Salvar arquivo\").\n" +
                            "3. Clique em “Importar” e aguarde a conclusão do download.\n";
        }

        private void PreencherInstrucoesCompararSelos()
        {
            txtOutput.Text = "Comparar selos (Salvar resultado em JSON/CSV) \n" +
                            "Essa opção realizada a comparação selo a selo entre dois arquivos diferentes.\n" +
                            "\n" +
                            "Os dois arquivos podem estar em formado json ou csv.\n" +
                            "\n" +
                            "*** Comparar selos ***\n" +
                            "\n" +
                            "1. Selecione o arquivo csv/json na primeira opção (\"Abrir arquivo 1\").\n" +
                            "2. Selecione o arquivo csv/json na segunda opção (\"Abrir arquivo 2\").\n" +
                            "3. Selecione o local de destino para salvar o arquivo resultado (\"Salvar arquivo\").\n" +
                            "4. Clique em “Comparar” e aguarde a conclusão da comparação.\n";
        }


    }
}