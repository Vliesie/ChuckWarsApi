using System.Runtime.InteropServices;

namespace ChuckWarsAPI.Entities
{
    public class Search
    {
        public string Id { get; set; }
        public List<string> result { get; set; }

        public string api { get; set; }
    }

    public class ChuckSearch
    {
        public string? error { get; set; }
        public string? Api { get; set; }
        public string Total { get; set; }
        public List<Joke> result { get; set; }

     
    }
    public class SwapiSearch
    {
        public List<SharpEntityResults<People>> swapis { get; set; }
    }

    public class ChuckSwapiSearch
    {
        public ChuckSearch? Jokes { get; set; }
        public SharpEntityResults<People>? SwapisPeople { get; set; }

        public string Error { get; set; }

    }
}
