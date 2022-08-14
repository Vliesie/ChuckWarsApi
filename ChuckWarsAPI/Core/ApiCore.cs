using Newtonsoft.Json;

namespace ChuckWarsAPI.Core
{
    public class ApiCore
    {
        public string ErrorHandle(int status, string message)
        {
            var error = new ErrorDetails()
            {
                StatusCode = status,
                Message = message
            };
             return JsonConvert.SerializeObject(error);
        }
    }

    public class ErrorDetails
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}
