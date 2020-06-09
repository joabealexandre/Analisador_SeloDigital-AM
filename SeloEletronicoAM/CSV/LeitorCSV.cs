using CsvHelper;
using SeloEletronicoAM.Classes;
using SeloEletronicoAM.Models;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace SeloEletronicoAM.CSV
{
    public class LeitorCSV : ILeitorArquivo<Selo>
    {
        /// <summary>
        /// Ler os selos de um arquivo CSV
        /// </summary>
        /// <param name="path">Caminho do arquivo CSV</param>
        /// <returns></returns>
        public IList<Selo> LerSelos(string path)
        {
            IList<Selo> selos = null;
            using (var reader = new StreamReader(path))
            {
                using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
                csv.Configuration.HasHeaderRecord = false;
                csv.Configuration.Delimiter = ";";
                csv.Configuration.RegisterClassMap<SeloMap>();
                selos = csv.GetRecords<Selo>().ToList();
            }
            return selos;
        }
    }
}
