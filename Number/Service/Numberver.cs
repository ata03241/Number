using Number.Models;

namespace Number.Service
{
    public class Numberver
    {
        public user CurrectUser { get; set; }


        public Numberver()
        {
            CurrectUser = new user
            {
                Name = "Ashok Tamang",
                Email = "pakhrintamangashok@gmail.com"
            };
        }
    }

       

    public class user{        
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
