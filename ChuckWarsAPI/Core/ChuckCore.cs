using System.Net;
using System.Text;
using ChuckWarsAPI.Models;
using Newtonsoft.Json;
using ChuckWarsAPI.Core;
using RestSharp;
using ChuckWarsAPI.Entities;

namespace ChuckWarsAPI.Core
{
    public class ChuckCore
    {

        ApiCore core = new ApiCore();
        HttpClient client = new HttpClient();
        private readonly string apiUrl = "https://api.chucknorris.io/jokes/categories";
        
        private async Task<List<Catagories>> Request()
        {
            try
            {
 
                string response = await client.GetStringAsync(apiUrl);

                var data = JsonConvert.DeserializeObject<string[]>(response);

                var returnData = data.Select(array => new Catagories { name = array }).ToList();

                return returnData;
            }
            catch(Exception exception)
            {
                core.ErrorHandle(401, exception.ToString());
                throw;
            }
        
        }

        public async Task<Joke> getRandomJoke(string query)
        {
            try
            {
                string Urlchuck = "https://api.chucknorris.io/jokes/random?category=" + query.ToLower();

                var responseChuck = await client.GetStringAsync(Urlchuck);

                return JsonConvert.DeserializeObject<Joke>(responseChuck); ;
            }
            catch (Exception exception)
            {
                core.ErrorHandle(401, exception.ToString());
                throw;
            }
        }

        public async Task<List<Catagories>> getAllCategories()
        {
                return await Request(); 
        }
    }
}
