using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Weather_System.Models;
using static System.Net.WebRequestMethods;

namespace Weather_System.Service
{
    public class WebService
    {
        private IJsonOnDeserialized jsonOnDeserialized;
        private Root_Model objectWheather;

        public Root_Model GetData(string city, string state)
        {
            try
            {
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                RestClient cliente = new RestClient("https://api.hgbrasil.com/weather");
                string requisicao = $"https://api.hgbrasil.com/weather?city_name={city},{state}&key=0a28cf98";

                RestRequest request = new RestRequest(requisicao, Method.Get);

                RestResponse response = cliente.Get(request);

                if (response.StatusCode == HttpStatusCode.OK || response.IsSuccessful)
                {
                    objectWheather = JsonSerializer.Deserialize<Root_Model>(response.Content);
                }

                return objectWheather;
            }
            catch (Exception)
            {

                throw;
            }




        }
    }
}
