using System.Text.Json.Serialization;

namespace Number.Models
{
    public class Exchange
    {
        [JsonPropertyName("success")]
        public bool Success {  get; set; }
        [JsonPropertyName ("timestamp")]
        public long Timestamp { get; set; }
        [JsonPropertyName("base")]
        public string Base { get; set; }
        [JsonPropertyName("date")]
        public string DateTime { get; set; }
        [JsonPropertyName("rates")]
        public Rates Rates { get; set; }
    }

    public class Rates
    {
        public decimal AUD { get; set; }
        public decimal CAD { get; set; }
        public decimal CHF { get; set; }
        public decimal GBP { get; set; }
  
        public decimal EUR { get; set; }
        public decimal USD { get; set; }

        public decimal INR { get; set; }

        public decimal MXN { get; set; }

 
 
        public decimal SEK { get; set; }
        public decimal NOK { get; set; }
        public decimal DKK { get; set; }
   
        public decimal IDR { get; set; }
        public decimal AED { get; set; }

    }
}
