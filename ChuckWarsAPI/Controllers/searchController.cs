using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ChuckWarsAPI.Core;
using Newtonsoft.Json;
using ChuckWarsAPI.Entities;
using ChuckWarsAPI.Attributes;

namespace ChuckWarsAPI.Controllers
{
  
    [Route("[controller]")]
    [ApiController]
    [ApiKey]
    public class searchController : ControllerBase
    {
        searchCore core = new searchCore();
        HttpClient client = new HttpClient();

        [HttpGet]
        public async Task<JsonResult> Search(string Query)
        {
            string Urlchuck = "https://api.chucknorris.io/jokes/search?query=" + Query.ToLower();
       
            ChuckSearch dataChuck = null;
            SharpEntityResults<People> dataSwapi = null;
            string Urlswapi = "https://swapi.dev/api/people/?search=" + Query.ToLower();

            var checkResponseChuck = await client.GetAsync(Urlchuck);
            if (checkResponseChuck.IsSuccessStatusCode)
            {
                 var responseChuck = await client.GetStringAsync(Urlchuck);
                  dataChuck = JsonConvert.DeserializeObject<ChuckSearch>(responseChuck);
            }
            var checkReponseSwapi = await client.GetAsync(Urlswapi);
            if (checkReponseSwapi.IsSuccessStatusCode)
            {
                string responseSwapi = await client.GetStringAsync(Urlswapi);
                dataSwapi = JsonConvert.DeserializeObject<SharpEntityResults<People>>(responseSwapi);
            }
            if(dataChuck != null && dataSwapi != null)
            {
                if (dataChuck.Total != "0" && dataSwapi.count > 0)
                {
                    ChuckSwapiSearch _chuckswapi = await core.SwapChucksearch(dataSwapi, dataChuck);
                    return new JsonResult(_chuckswapi);
                }
                else if (dataChuck.Total == "0" && dataSwapi.count == 0)
                {
                    var error = "No Values Found In SwAPI or ChuckAPI";

                    return new JsonResult(error);
                }
            } 
            if (dataChuck != null)
            {
                ChuckSearch chuckresults = await core.ChuckSearch(dataChuck);

                return new JsonResult(chuckresults);
            }  
            if (dataSwapi != null)
            {
                await core.Swapisearch(dataSwapi);
               SharpEntityResults<People> swapiResults = await core.Swapisearch(dataSwapi);

                return new JsonResult(swapiResults);
            }

            return null;
        }
    }
}
