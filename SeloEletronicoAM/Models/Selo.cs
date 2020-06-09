using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace SeloEletronicoAM.Models
{
    [Serializable]
    public class SeloRoot
    {
        public Selo Selo { get; set; }
    }

    [Serializable]
    public class Selo
    {
        //public int Id { get; set; }
        [JsonProperty("codSelo")]
        public string Codigo { get; set; }
        [JsonProperty("codAtoTabelaAto")]
        public AtoTabela AtoTabela { get; set; }
        //public string Especialidade { get; set; }
        //public string Escrevente { get; set; }
        [JsonProperty("infoIsento")]
        public InfoIsento InfoIsento { get; set; }
        //public bool Cancelado { get; set; }
        //public bool Indeferido { get; set; }
        //public string MotivoIndeferimento { get; set; }
        //public string IdentificadorDoAnexo { get; set; }
        //public string MotivoDaIsencao { get; set; }

        /// <summary>
        /// Retorno o valor total dos fundos
        /// </summary>
        /// <param name="validarIsento">Flag para verificar se considera o campo "Isento" no retorno do valor</param>
        /// <returns></returns>
        public decimal TotalValorFundos(bool validarIsento = true)
        {
            if (validarIsento)
                return InfoIsento.Isento ? 0 : AtoTabela.Farpam + AtoTabela.Fundpam + AtoTabela.Fundpge + AtoTabela.Funetj;
            else
                return AtoTabela.Farpam + AtoTabela.Fundpam + AtoTabela.Fundpge + AtoTabela.Funetj;
        }
    }

    [Serializable]
    public class InfoIsento
    {
        [JsonProperty("isento")]
        public bool Isento { get; set; }
    }

}
