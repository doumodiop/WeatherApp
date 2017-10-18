using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
namespace WeatherApp
{
    public class DataService
    {
        public static async Task<dynamic> getDataFromService(string queryString)
        {

            HttpClient client = new HttpClient();
            var response = await client.GetAsync(queryString);


            dynamic data = null;

            if (response != null)
            {
                String json = response.Content.ReadAsStringAsync().Result;
                data = JsonConvert.DeserializeObject(json);

            }
            return data;
        }
    }
}
