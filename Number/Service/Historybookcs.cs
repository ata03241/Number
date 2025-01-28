using Number.Models;

namespace Number.Service
{
    public class Historybookcs
    {
        public List<Numverify> UserDatas { get; set; } = new List<Numverify>();

        public List<Numverify> FavouriteData { get; set; } = new List<Numverify>();

        public void ToggleFavouriteUserdata(Numverify newUserdata)
        {
            if (newUserdata.isfavorite)
            {
                FavouriteData.Add(newUserdata);
            } else
            {
                if(FavouriteData.Contains(newUserdata))
                {
                    FavouriteData.Remove(newUserdata);
                }
            }

        }

        public void Adduserdata(Numverify newUserdata)
        {
            if (!UserDatas.Contains(newUserdata))
            {
             UserDatas.Add(newUserdata);
            }
        }

        public void Removetoggle(Numverify user)
        {
            UserDatas.Remove(user);
        }
    }
}

