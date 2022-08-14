using ChuckWarsAPI.Entities;
using System.Collections.Generic;


namespace ChuckWarsAPI.Models
{
    public class StarWars : SharpEntity
    {
        public int id { get; set; }
        public List<People> _peoples;
    }

    public class SwapiPeople
    {
        public List<People> people { get; set; }
    }
}



