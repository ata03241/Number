namespace Number.Models
{
    public class Country
    {
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public string DialingCode { get; set; }
        public string FlagIcon { get; set; }

        public List<Country> GetCountryList()
        {
            return new List<Country>
            {
                new Country { CountryName = "Sweden", CountryCode = "SE", DialingCode = "+46", FlagIcon = "🇸🇪" },
                new Country { CountryName = "United States", CountryCode = "US", DialingCode = "+1", FlagIcon = "🇺🇸" },
                new Country { CountryName = "India", CountryCode = "IN", DialingCode = "+91", FlagIcon = "🇮🇳" },
                new Country { CountryName = "United Kingdom", CountryCode = "GB", DialingCode = "+44", FlagIcon = "🇬🇧" },
                new Country { CountryName = "Canada", CountryCode = "CA", DialingCode = "+1", FlagIcon = "🇨🇦" },
                new Country { CountryName = "Australia", CountryCode = "AU", DialingCode = "+61", FlagIcon = "🇦🇺" },
                new Country { CountryName = "Germany", CountryCode = "DE", DialingCode = "+49", FlagIcon = "🇩🇪" },
                new Country { CountryName = "France", CountryCode = "FR", DialingCode = "+33", FlagIcon = "🇫🇷" },
                new Country { CountryName = "Japan", CountryCode = "JP", DialingCode = "+81", FlagIcon = "🇯🇵" },
                new Country { CountryName = "China", CountryCode = "CN", DialingCode = "+86", FlagIcon = "🇨🇳" },
                new Country { CountryName = "Brazil", CountryCode = "BR", DialingCode = "+55", FlagIcon = "🇧🇷" },
                new Country { CountryName = "Mexico", CountryCode = "MX", DialingCode = "+52", FlagIcon = "🇲🇽" },
                new Country { CountryName = "South Korea", CountryCode = "KR", DialingCode = "+82", FlagIcon = "🇰🇷" },
                new Country { CountryName = "Italy", CountryCode = "IT", DialingCode = "+39", FlagIcon = "🇮🇹" },
                new Country { CountryName = "Spain", CountryCode = "ES", DialingCode = "+34", FlagIcon = "🇪🇸" },
                new Country { CountryName = "Russia", CountryCode = "RU", DialingCode = "+7", FlagIcon = "🇷🇺" },
                new Country { CountryName = "South Africa", CountryCode = "ZA", DialingCode = "+27", FlagIcon = "🇿🇦" },
                new Country { CountryName = "Argentina", CountryCode = "AR", DialingCode = "+54", FlagIcon = "🇦🇷" },
                new Country { CountryName = "Nigeria", CountryCode = "NG", DialingCode = "+234", FlagIcon = "🇳🇬" },
                new Country { CountryName = "Egypt", CountryCode = "EG", DialingCode = "+20", FlagIcon = "🇪🇬" },
                new Country { CountryName = "Pakistan", CountryCode = "PK", DialingCode = "+92", FlagIcon = "🇵🇰" },
                new Country { CountryName = "Bangladesh", CountryCode = "BD", DialingCode = "+880", FlagIcon = "🇧🇩" },
                new Country { CountryName = "Italy", CountryCode = "IT", DialingCode = "+39", FlagIcon = "🇮🇹" },
                new Country { CountryName = "Turkey", CountryCode = "TR", DialingCode = "+90", FlagIcon = "🇹🇷" },
                new Country { CountryName = "Indonesia", CountryCode = "ID", DialingCode = "+62", FlagIcon = "🇮🇩" },
                new Country { CountryName = "Malaysia", CountryCode = "MY", DialingCode = "+60", FlagIcon = "🇲🇾" },
                new Country { CountryName = "Singapore", CountryCode = "SG", DialingCode = "+65", FlagIcon = "🇸🇬" },
                new Country { CountryName = "Thailand", CountryCode = "TH", DialingCode = "+66", FlagIcon = "🇹🇭" },
                new Country { CountryName = "Vietnam", CountryCode = "VN", DialingCode = "+84", FlagIcon = "🇻🇳" },
                new Country { CountryName = "Ukraine", CountryCode = "UA", DialingCode = "+380", FlagIcon = "🇺🇦" },
                new Country { CountryName = "Philippines", CountryCode = "PH", DialingCode = "+63", FlagIcon = "🇵🇭" },
                new Country { CountryName = "Saudi Arabia", CountryCode = "SA", DialingCode = "+966", FlagIcon = "🇸🇦" },
                new Country { CountryName = "Chile", CountryCode = "CL", DialingCode = "+56", FlagIcon = "🇨🇱" },
                new Country { CountryName = "Colombia", CountryCode = "CO", DialingCode = "+57", FlagIcon = "🇨🇴" }
            };
        }
    }
}
