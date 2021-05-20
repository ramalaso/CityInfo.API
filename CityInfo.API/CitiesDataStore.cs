using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public List<CityDto> Cities { get; set; }
        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id=1,
                    Name="New Your City",
                    Description = "The one with that big park"
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Cochabamba",
                    Description = "The one with that big park"
                },
                 new CityDto()
                {
                    Id = 3,
                    Name = "La Paz",
                    Description = "The great mountains and beautiful people."
                }
            };
        }
    }
}
