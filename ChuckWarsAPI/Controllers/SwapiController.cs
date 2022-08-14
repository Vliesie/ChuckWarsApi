using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ChuckWarsAPI.Models;
using ChuckWarsAPI.Data;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ChuckWarsAPI.Entities;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ChuckWarsAPI.Core;
using System.Text.Json;

namespace ChuckWarsAPI.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]

    public class SwapiController : ControllerBase
    {
        StarWarsCore starCore = new StarWarsCore();

        [HttpGet()]
        public JsonResult People()
        {
            var people = new List<People>();
            var page = "";
            var pageNumber = 1;

            while (page != null)
            {
                var starPeople = starCore.GetAllPeople(pageNumber.ToString());
                List<People> warResults = starPeople.results;
                people.AddRange(warResults);
                page = starPeople.next;
                pageNumber++;
            }

            return new JsonResult(people);

        }
        

    }
}
