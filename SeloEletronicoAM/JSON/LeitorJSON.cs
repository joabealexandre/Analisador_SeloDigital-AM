using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SeloEletronicoAM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace SeloEletronicoAM.JSON
{
    public class LeitorJSON
    {
        public Selo LerSelo(string json)
        {
           return JsonConvert.DeserializeObject<SeloRoot>(json).Selo;
        }

        public List<Selo> LerSelos(string json)
        {
           return JsonConvert.DeserializeObject<Selo[]>(json).ToList();
        }
    }
}
