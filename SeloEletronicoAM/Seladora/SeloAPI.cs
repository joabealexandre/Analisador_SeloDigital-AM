using SeloEletronicoAM.JSON;
using SeloEletronicoAM.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SeloEletronicoAM.Seladora
{
    public class SeloAPI : IDisposable
    {
        private readonly string _apiURL = null;
        private HttpClient _httpClient = null;
        private LeitorJSON _leitorJSON = null;

        public SeloAPI(string apiUrl)
        {
            _apiURL = apiUrl;
            _httpClient = new HttpClient();
            _leitorJSON = new LeitorJSON();
        }

        public async Task<Selo> LerSelo(string codigoSelo)
        {
            Selo selo = null;
            var urlSelo = string.Join(@"/", _apiURL, codigoSelo);

            using (var response = await _httpClient.GetAsync(urlSelo))
            {
                string conteudo = await response.Content.ReadAsStringAsync();
                selo = _leitorJSON.LerSelo(conteudo);
            }

            return selo;
        }

        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}
