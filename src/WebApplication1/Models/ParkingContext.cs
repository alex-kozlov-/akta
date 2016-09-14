using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace WebApplication1.Models
{
    public class ParkingContext : DbContext
    {
        private IConfigurationRoot _config;
        
        public DbSet<Parking> Parkings { get; set; }
        public DbSet<Bicycle> Bicycles { get; set; }

        public ParkingContext(IConfigurationRoot config, DbContextOptions options)
            :base(options)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(_config["ConnectionStrings:ParkingContextConnection"]);
        }
    }
}
