namespace Number.Models
{
    public class Numverify
    {
        public bool Valid { get; set; }        
        public string Number { get; set; }     
        public string CountryCode { get; set; }
        public string CountryName { get; set; } 

        public string Location { get; set; }
        public string Carrier { get; set; }

        public bool isfavorite { get; set; } = false;
    }
}
