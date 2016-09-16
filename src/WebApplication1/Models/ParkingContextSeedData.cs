using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ParkingContextSeedData
    {
        private ParkingContext _context;

        public ParkingContextSeedData(ParkingContext context)
        {
            _context = context;
        }

        public async Task EnsureSeedData()
        {
            if (!_context.Parkings.Any() && !_context.Bicycles.Any())
            {
                var bycycle1 = new Bicycle()
                {
                    AddedDate = DateTime.Now,
                    BoughtDate = DateTime.Now,
                    Color = "red",
                    Cost = 200M,
                    IsAvailable = true,
                    Make = "Aist",
                    Model = "S200",
                    Name = "Aist S200 red 2"
                };

                var bycycle2 = new Bicycle()
                {
                    AddedDate = DateTime.Now,
                    BoughtDate = DateTime.Now,
                    Color = "blue",
                    Cost = 200M,
                    IsAvailable = true,
                    Make = "Aist",
                    Model = "S200",
                    Name = "Aist S200 blue"
                };

                var bycycle3 = new Bicycle()
                {
                    AddedDate = DateTime.Now,
                    BoughtDate = DateTime.Now,
                    Color = "red",
                    Cost = 200M,
                    IsAvailable = true,
                    Make = "Aist",
                    Model = "S200",
                    Name = "Aist S200 red 1"
                };

                var bycycle4 = new Bicycle()
                {
                    AddedDate = DateTime.Now,
                    BoughtDate = DateTime.Now,
                    Color = "blue",
                    Cost = 150M,
                    IsAvailable = true,
                    Make = "Aist",
                    Model = "S150",
                    Name = "Aist S150 blue"
                };
                
                var bycycle5 = new Bicycle()
                {
                    AddedDate = DateTime.Now,
                    BoughtDate = DateTime.Now,
                    Color = "yellow",
                    Cost = 2000M,
                    IsAvailable = true,
                    Make = "Aist",
                    Model = "S200SP",
                    Name = "Aist S200SP yellow 1"
                };
                
                var bycycle6 = new Bicycle()
                {
                    AddedDate = DateTime.Now,
                    BoughtDate = DateTime.Now,
                    Color = "yellow",
                    Cost = 150M,
                    IsAvailable = true,
                    Make = "Aist",
                    Model = "S150",
                    Name = "Aist S150 yellow 2"
                };
                
                var bycycle7 = new Bicycle()
                {
                    AddedDate = DateTime.Now,
                    BoughtDate = DateTime.Now,
                    Color = "red",
                    Cost = 170M,
                    IsAvailable = true,
                    Make = "Aist",
                    Model = "S300",
                    Name = "Aist S300 red"
                };

                

                var parking1 = new Parking()
                {
                    Name = "Nemiga 1",
                    Latitude = 53.906301,
                    Longitude = 27.553943,
                    Bicycles = new List<Bicycle>()
                    {
                        bycycle1, bycycle5, bycycle4, bycycle3, bycycle2,  bycycle7, bycycle6
                    }
                };



                var bycycle8 = new Bicycle()
                {
                    AddedDate = DateTime.Now,
                    BoughtDate = DateTime.Now,
                    Color = "red",
                    Cost = 150M,
                    IsAvailable = true,
                    Make = "Aist",
                    Model = "S200",
                    Name = "Aist S200 red 21"
                };

                var bycycle9 = new Bicycle()
                {
                    AddedDate = DateTime.Now,
                    BoughtDate = DateTime.Now,
                    Color = "blue",
                    Cost = 200M,
                    IsAvailable = true,
                    Make = "Aist",
                    Model = "S400",
                    Name = "Aist S200 blue 23"
                };

                var bycycle10 = new Bicycle()
                {
                    AddedDate = DateTime.Now,
                    BoughtDate = DateTime.Now,
                    Color = "red",
                    Cost = 200M,
                    IsAvailable = true,
                    Make = "Aist",
                    Model = "S400",
                    Name = "Aist S200 red 10"
                };

                var bycycle11 = new Bicycle()
                {
                    AddedDate = DateTime.Now,
                    BoughtDate = DateTime.Now,
                    Color = "blue",
                    Cost = 200M,
                    IsAvailable = true,
                    Make = "Aist",
                    Model = "S350",
                    Name = "Aist S150 blue 87"
                };

                var bycycle12 = new Bicycle()
                {
                    AddedDate = DateTime.Now,
                    BoughtDate = DateTime.Now,
                    Color = "yellow",
                    Cost = 122M,
                    IsAvailable = true,
                    Make = "Aist",
                    Model = "S100",
                    Name = "Aist S100 yellow 1"
                };

                var bycycle13 = new Bicycle()
                {
                    AddedDate = DateTime.Now,
                    BoughtDate = DateTime.Now,
                    Color = "yellow",
                    Cost = 150M,
                    IsAvailable = true,
                    Make = "Aist",
                    Model = "S150",
                    Name = "Aist S150 yellow 2"
                };

                var bycycle14 = new Bicycle()
                {
                    AddedDate = DateTime.Now,
                    BoughtDate = DateTime.Now,
                    Color = "red",
                    Cost = 170M,
                    IsAvailable = true,
                    Make = "Aist",
                    Model = "S300",
                    Name = "Aist S300 red"
                };


                var parking2 = new Parking()
                {
                    Name = "Palac Nezalezhnosci",
                    Latitude = 53.925859,
                    Longitude = 27.521365,
                    Bicycles = new List<Bicycle>()
                    {
                        bycycle14, bycycle13, bycycle12, bycycle11, bycycle10, bycycle9, bycycle8,
                    }
                };



                var bycycle20 = new Bicycle()
                {
                    AddedDate = DateTime.Now,
                    BoughtDate = DateTime.Now,
                    Color = "red",
                    Cost = 200M,
                    IsAvailable = true,
                    Make = "Aist",
                    Model = "S400",
                    Name = "Aist S200 red 10"
                };

                var bycycle21 = new Bicycle()
                {
                    AddedDate = DateTime.Now,
                    BoughtDate = DateTime.Now,
                    Color = "blue",
                    Cost = 200M,
                    IsAvailable = true,
                    Make = "Aist",
                    Model = "S350",
                    Name = "Aist S150 blue 87"
                };

                var bycycle22 = new Bicycle()
                {
                    AddedDate = DateTime.Now,
                    BoughtDate = DateTime.Now,
                    Color = "yellow",
                    Cost = 122M,
                    IsAvailable = true,
                    Make = "Aist",
                    Model = "S100",
                    Name = "Aist S100 yellow 1"
                };

                var bycycle23 = new Bicycle()
                {
                    AddedDate = DateTime.Now,
                    BoughtDate = DateTime.Now,
                    Color = "yellow",
                    Cost = 150M,
                    IsAvailable = true,
                    Make = "Aist",
                    Model = "S150",
                    Name = "Aist S150 yellow 2"
                };

                var bycycle24 = new Bicycle()
                {
                    AddedDate = DateTime.Now,
                    BoughtDate = DateTime.Now,
                    Color = "red",
                    Cost = 170M,
                    IsAvailable = true,
                    Make = "Aist",
                    Model = "S300",
                    Name = "Aist S300 red"
                };

                var parking3 = new Parking()
                {
                    Name = "Minsk Arena",
                    Latitude = 53.937142,
                    Longitude = 27.482746,
                    Bicycles = new List<Bicycle>()
                    {
                        bycycle24, bycycle23, bycycle22, bycycle21, bycycle20
                    }
                };

                var bycycle31 = new Bicycle()
                {
                    AddedDate = DateTime.Now,
                    BoughtDate = DateTime.Now,
                    Color = "red",
                    Cost = 200M,
                    IsAvailable = true,
                    Make = "Aist",
                    Model = "S200",
                    Name = "Aist S200 red 2"
                };

                var bycycle32 = new Bicycle()
                {
                    AddedDate = DateTime.Now,
                    BoughtDate = DateTime.Now,
                    Color = "blue",
                    Cost = 200M,
                    IsAvailable = true,
                    Make = "Aist",
                    Model = "S200",
                    Name = "Aist S200 blue"
                };

                var bycycle33 = new Bicycle()
                {
                    AddedDate = DateTime.Now,
                    BoughtDate = DateTime.Now,
                    Color = "red",
                    Cost = 200M,
                    IsAvailable = true,
                    Make = "Aist",
                    Model = "S200",
                    Name = "Aist S200 red 1"
                };

                var bycycle34 = new Bicycle()
                {
                    AddedDate = DateTime.Now,
                    BoughtDate = DateTime.Now,
                    Color = "blue",
                    Cost = 150M,
                    IsAvailable = true,
                    Make = "Aist",
                    Model = "S150",
                    Name = "Aist S150 blue"
                };

                var bycycle35 = new Bicycle()
                {
                    AddedDate = DateTime.Now,
                    BoughtDate = DateTime.Now,
                    Color = "yellow",
                    Cost = 2000M,
                    IsAvailable = true,
                    Make = "Aist",
                    Model = "S200SP",
                    Name = "Aist S200SP yellow 1"
                };

                var bycycle36 = new Bicycle()
                {
                    AddedDate = DateTime.Now,
                    BoughtDate = DateTime.Now,
                    Color = "yellow",
                    Cost = 150M,
                    IsAvailable = true,
                    Make = "Aist",
                    Model = "S150",
                    Name = "Aist S150 yellow 2"
                };

                var bycycle37 = new Bicycle()
                {
                    AddedDate = DateTime.Now,
                    BoughtDate = DateTime.Now,
                    Color = "red",
                    Cost = 170M,
                    IsAvailable = true,
                    Make = "Aist",
                    Model = "S300",
                    Name = "Aist S300 red"
                };

                var parking34 = new Parking()
                {
                    Name = "Gorky Park",
                    Latitude = 53.901888,
                    Longitude = 27.573072,
                    Bicycles = new List<Bicycle>()
                    {
                        bycycle31, bycycle35, bycycle34, bycycle33, bycycle32,  bycycle37, bycycle36
                    }
                };


                var bycycle41 = new Bicycle()
                {
                    AddedDate = DateTime.Now,
                    BoughtDate = DateTime.Now,
                    Color = "red",
                    Cost = 290M,
                    IsAvailable = true,
                    Make = "Aist",
                    Model = "S201m",
                    Name = "Aist S201m red 2"
                };

                var bycycle42 = new Bicycle()
                {
                    AddedDate = DateTime.Now,
                    BoughtDate = DateTime.Now,
                    Color = "blue",
                    Cost = 180M,
                    IsAvailable = true,
                    Make = "Aist",
                    Model = "S200",
                    Name = "Aist S200 blue"
                };

                var bycycle43 = new Bicycle()
                {
                    AddedDate = DateTime.Now,
                    BoughtDate = DateTime.Now,
                    Color = "red",
                    Cost = 200M,
                    IsAvailable = true,
                    Make = "Aist",
                    Model = "S200",
                    Name = "Aist S200 red 1"
                };

                var bycycle44 = new Bicycle()
                {
                    AddedDate = DateTime.Now,
                    BoughtDate = DateTime.Now,
                    Color = "blue",
                    Cost = 400M,
                    IsAvailable = true,
                    Make = "Aist",
                    Model = "S150ss",
                    Name = "Aist S150ss blue"
                };

                var bycycle45 = new Bicycle()
                {
                    AddedDate = DateTime.Now,
                    BoughtDate = DateTime.Now,
                    Color = "yellow",
                    Cost = 2000M,
                    IsAvailable = true,
                    Make = "Aist",
                    Model = "S200SP",
                    Name = "Aist S200SP yellow 1"
                };

                var bycycle46 = new Bicycle()
                {
                    AddedDate = DateTime.Now,
                    BoughtDate = DateTime.Now,
                    Color = "yellow",
                    Cost = 50M,
                    IsAvailable = true,
                    Make = "Aist",
                    Model = "S50",
                    Name = "Aist S50young yellow 2"
                };

                var bycycle47 = new Bicycle()
                {
                    AddedDate = DateTime.Now,
                    BoughtDate = DateTime.Now,
                    Color = "red",
                    Cost = 122M,
                    IsAvailable = true,
                    Make = "Aist",
                    Model = "S100",
                    Name = "Aist S100 red"
                };

                var parking5 = new Parking()
                {
                    Name = "Serabranski Park",
                    Latitude = 53.850742,
                    Longitude = 27.596052,
                    Bicycles = new List<Bicycle>()
                    {
                        bycycle41, bycycle45, bycycle44, bycycle43, bycycle42,  bycycle47, bycycle46
                    }
                };

                _context.Parkings.AddRange(new List<Parking>() { parking1, parking2, parking3, parking34, parking5 });

                _context.Bicycles.AddRange(new List<Bicycle>() { bycycle41, bycycle45, bycycle31, bycycle35, bycycle34,
                    bycycle33,bycycle14, bycycle13, bycycle12, bycycle11, bycycle10, bycycle9, bycycle8,
                    bycycle32, bycycle37, bycycle36,
                    bycycle44, bycycle43, bycycle42, bycycle24, bycycle23, bycycle22,
                    bycycle1, bycycle5, bycycle4, bycycle3, bycycle2,  bycycle7, bycycle6, bycycle21, bycycle20, bycycle47, bycycle46 });

                await _context.SaveChangesAsync();
            }
        }
    }
}
