using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace SeloEletronicoAM.Models
{
    public class AtoTabela
    {
        //public int Codigo { get; set; }

        [JsonPropertyName("emolumento")]
        public decimal Emolumento { get; set; }

        [JsonPropertyName("farpam")]
        public decimal Farpam { get; set; }

        [JsonPropertyName("fundpam")]
        public decimal Fundpam { get; set; }

        [JsonPropertyName("fundpge")]
        public decimal Fundpge { get; set; }

        [JsonPropertyName("funetj")]
        public decimal Funetj { get; set; }

        [JsonPropertyName("iss")]
        public decimal ISS { get; set; }

        //[JsonPropertyName("computacao")]
        //public decimal Computacao { get; set; }

        [JsonPropertyName("valorSelo")]
        public decimal ValorSelo { get; set; }

        //[JsonPropertyName("valorAto")]
        //public decimal Valorato { get; set; }
    }
}
