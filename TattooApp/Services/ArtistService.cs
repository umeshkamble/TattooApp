using TattooApp.Models;

namespace TattooApp.Services
{
    public class ArtistService
    {
        static ArtistService _instance;

        public static ArtistService Instance
        {
            get
            {
                _instance ??= new ArtistService();

                return _instance;
            }
        }

        public List<Artists> GetArtists()
        {
            return new List<Artists>
            {
                new Artists
                {
                    Name="Umesh",
                    Image="artista.png",
                },
                new Artists
                {
                    Name="Arjun",
                    Image="artistb.png",
                },
                new Artists
                {
                    Name="Rafi",
                    Image="artistc.png",
                },
                new Artists
                {
                    Name="Fawas",
                    Image="artista.png",
                },

            };
        }
    }
}

