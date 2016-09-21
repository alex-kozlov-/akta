using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ParkingRepository : IParkingRepository
    {
        private ParkingContext _context;
        private ILogger<ParkingRepository> _logger;

        public ParkingRepository(ParkingContext context,
            ILogger<ParkingRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IEnumerable<Parking> GetAllParkings()
        {
            _logger.LogInformation($"Reading all parkings {DateTime.Now}");
            return _context.Parkings.ToList();
        }
    }
}
