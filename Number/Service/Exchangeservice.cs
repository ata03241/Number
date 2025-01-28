namespace Number.Service
{
    public class Exchangeservice
    {
        private readonly string _apikey;

        public Exchangeservice(string apikey)
        {
            _apikey = apikey;
        }

        public string GetApiKey()
        {
            return _apikey;
        }
    }
}
