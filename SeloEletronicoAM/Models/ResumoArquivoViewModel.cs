using SeloEletronicoAM.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeloEletronicoAM.Core.Models
{
    public class ResumoArquivoViewModel
    {
        public decimal TotalEmolumentos { get; set; }

        public decimal TotalNotificacao { get; set; }

        public decimal TotalFundoFundpam { get; set; }

        public decimal TotalFundoExtJudic { get; set; }

        public decimal TotalFundoRcnpsd { get; set; }

        public decimal FundoFundpge { get; set; }

        public int TotalDeSelos { get; set; }

        public Dictionary<EAto, int> TotalDeSelosPorAto { get; set; }

    }
}
