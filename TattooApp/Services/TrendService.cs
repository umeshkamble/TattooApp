using System;
using TattooApp.Models;

namespace TattooApp.Services
{
	public class TrendService
	{
        static TrendService _instance;

        public static TrendService Instance
        {
            get
            {
                _instance ??= new TrendService();

                return _instance;
            }
        }

        public List<Artists> GetTrends()
        {
            return new List<Artists>
            {
                new Artists
                {
                    Name="By Umesh",
                    Image="tattoo1.png",
                },
                new Artists
                {
                    Name="By Arjun",
                    Image="tattoo2.png",
                },
                new Artists
                {
                    Name="By Rafi",
                    Image="tattoo3.png",
                },
                new Artists
                {
                    Name="By Fawas",
                    Image="tattoo4.png",
                },

            };
        }
    }
}

