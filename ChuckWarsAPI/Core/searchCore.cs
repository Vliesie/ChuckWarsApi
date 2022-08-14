using ChuckWarsAPI.Entities;
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Linq;


namespace ChuckWarsAPI.Core
{
    public class searchCore 
	{
        ChuckSwapiSearch chuckSwapi = new ChuckSwapiSearch();
        public async Task<ChuckSearch> ChuckSearch(ChuckSearch chuckData)
        {
            chuckData.Api = "Chuckapi";
            return chuckData;
        }
		public async Task<SharpEntityResults<People>> Swapisearch(SharpEntityResults<People> swapiData)
		{
            swapiData.Api = "SwapiApi";

            return swapiData;
        }
        public async Task<ChuckSwapiSearch> SwapChucksearch(SharpEntityResults<People> swapiData, ChuckSearch chuckData)
        {
            swapiData.Api = "SwapiAPI";
            chuckData.Api = "ChuckAPI";
            chuckSwapi.SwapisPeople = swapiData;
            chuckSwapi.Jokes = chuckData;

            return chuckSwapi;
        }
	}
}
