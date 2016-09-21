using System.Collections.Generic;

namespace WebApplication1.Models
{
    public interface IParkingRepository
    {
        IEnumerable<Parking> GetAllParkings();
    }
}