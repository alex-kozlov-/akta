using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Api
{
    [Route("api/parkings")]
    public class ParkingsController : Controller
    {
        private IParkingRepository _repository;

        public ParkingsController(IParkingRepository repository)
        {
            _repository = repository;
        }
        
        [HttpGet]
        public IActionResult GetParkings()
        {
            try
            {
                return Ok(_repository.GetAllParkings());
            }
            catch (Exception ex)
            {
                return BadRequest($"Error? {ex.StackTrace}");
            }
        }
        
        [HttpPost]
        public IActionResult SaveParking([FromBody]Parking parking)
        {
            return Ok(true);
        }
    }
}
