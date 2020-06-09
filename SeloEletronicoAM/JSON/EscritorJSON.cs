using Newtonsoft.Json;
using SeloEletronicoAM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeloEletronicoAM.JSON
{
    public class EscritorJSON
    {
        public string CriarJsonSelo(Selo selo)
        {
            return JsonConvert.SerializeObject(selo, Formatting.Indented);
        }

        public string CriarJsonSelo(List<Selo> selos)
        {
            return JsonConvert.SerializeObject(selos, Formatting.Indented);
        }
    }
}
