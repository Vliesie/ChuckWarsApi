using ChuckWarsAPI.Entities;
namespace ChuckWarsAPI.Models
{
    public class Catagories
    {
        public string name { get; set; }

    }

    public class ChuckResult
    {
        public string id { get; set; }
        public List<Joke> result { get; set; }
    }

}
