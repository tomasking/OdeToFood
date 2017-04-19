using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Model
{
    public class CityForCreationDto
    {
        // TODO: fluent validation better for validating
        [Required(ErrorMessage = "Name is required")]
        [MaxLength(20, ErrorMessage = "Name must be under 20 characters")]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
