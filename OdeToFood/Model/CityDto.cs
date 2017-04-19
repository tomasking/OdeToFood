using System.Collections.Generic;

namespace OdeToFood.Model
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int NumberOfPointsOfInterest => PointOfInterestDtos.Count;
        public List<PointOfInterestDto> PointOfInterestDtos { get; set; } = new List<PointOfInterestDto>();
    }
}
