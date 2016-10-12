using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Api
{
    [Route("api/parkings")]
    public class ParkingsController : Controller
    {
        private IParkingRepository _repository;

        public ParkingsController(IParkingRepository repository, ILoggerFactory)
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
        public IActionResult SaveParking([FromBody]ParkingViewModel parking)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var newParking = Mapper.Map<Parking>(parking);
                    return Created($"api/parkings/{parking.Name}", newParking);
                }
            }
            catch (Exception)
            {
                
            }
            return BadRequest(ModelState);
        }
    }
}
