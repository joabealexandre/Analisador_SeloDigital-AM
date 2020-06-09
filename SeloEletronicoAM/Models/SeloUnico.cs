using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace SeloEletronicoAM.Models
{
    public class SeloUnico
    {
        //public int Id { get; set; }
        [JsonPropertyName("codSelo")]
        public string Codigo { get; set; }
        [JsonPropertyName("codAtoTabelaAto")]
        public AtoTabela AtoTabela { get; set; }
    }
}
