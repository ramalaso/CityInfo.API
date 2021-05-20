using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        //public JsonResult GetCities()
        public IActionResult GetCities()
        {
            //return new JsonResult(
            //    new List<object>(){
            //    new { id=1, Name="New Your City"},
            //    new { id = 2, Name = "Cochabamba City" }
            //});

            //return new JsonResult(CitiesDataStore.Current.Cities);
            return Ok(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            var cityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
            if(cityToReturn == null)
            {
                return NotFound();
            }

            return Ok(cityToReturn);
        }
    }
}
