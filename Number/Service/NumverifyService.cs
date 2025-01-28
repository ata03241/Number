namespace Number.Service
{
    public class NumverifyService
    {
        private readonly string _apiKey;

        public NumverifyService(string apiKey)
        {
            _apiKey = apiKey;
        }

        public string GetApiKey() { 
            return _apiKey; 
        }
    }
}
