using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFood.Model;

namespace OdeToFood
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto
                {
                    Id = 1, Name = "London", Description = "Awesome",
                    PointOfInterestDtos = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto(){ Id = 101, Name = "Camden Lock", Description = "Market etc"},
                        new PointOfInterestDto(){ Id = 102, Name = "Leicester Square", Description = "Cinemas and shit"}
                    }
                },
                new CityDto { Id = 2, Name = "Paris", Description = "La Awesome" },
                new CityDto { Id = 3, Name = "Munich", Description = "Ich Wich Awesome" },
                new CityDto { Id = 4, Name = "Rome", Description = "Awesomo" }
            };
        }
    }
}
