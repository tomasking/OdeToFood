using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using OdeToFood.Model;

namespace OdeToFood.Controllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        [HttpGet]
        public IActionResult GetCities()
        {
            return Ok(new JsonResult(CitiesDataStore.Current.Cities) {StatusCode = 200});
        }

        [HttpGet("{id}", Name = "GetCity")]
        public IActionResult GetCity(int id)
        {
            var city = CitiesDataStore.Current.Cities.SingleOrDefault(c=>c.Id == id);
            if (city == null)
            {
                return NotFound();
            }

            return Ok(city);
        }

        [HttpPost]
        public IActionResult PostCity([FromBody] CityForCreationDto cityDto)
        {
            if (cityDto == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: saving logic
            
            return CreatedAtRoute("GetCity", new { id = 1 }, cityDto);
        }


        // use JsonPatchDocment when doing partial updates, return 204 no content
        // patch has operations model

        // put for updates
        // patch for partial updates
    }
}
