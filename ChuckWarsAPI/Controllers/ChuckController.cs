using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ChuckWarsAPI.Core;
using ChuckWarsAPI.Models;
using System.Text.Json;
using Newtonsoft.Json;
using System.Net;

namespace ChuckWarsAPI.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class ChuckController : ControllerBase
    {

        ChuckCore core = new ChuckCore();

        [HttpGet()]
        public async Task<JsonResult> categories()
        {
            var categories = Task.Run(async () => await core.getAllCategories()).Result;

            return new JsonResult(categories);
        }

        [HttpGet]
        public async Task<JsonResult> randomjoke(string query)
        {
            var result = await core.getRandomJoke(query);

            return new JsonResult(result);
        }


    }
}
