using Final_Project.Data;
using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Services
{
    public class GarageService : IGarageService
    {
        private readonly ApplicationDbContext db;
        public GarageService(ApplicationDbContext dbContext)
        {
            this.db = dbContext;
        }


        public ICollection<Garage> GetGarages()
        {
            return this.db.Garages.ToList();
        }

        public Garage DeleteGarage(int garageId)
        {
            throw new NotImplementedException();
        }

        public Garage GetGarage(int garageId)
        {
            return this.db.Garages.Where(g => g.Id == garageId).FirstOrDefault();
        }

        public Garage UpdateGarage(int garageId, object data)
        {
            throw new NotImplementedException();
        }

        public Garage AddGarage(string name,string town,string address)
        {
            var newGarage = new Garage() {
                
                Name = name,
                Town = town,
                Address = address
            };
            this.db.Garages.Add(newGarage);
            this.db.SaveChanges();

            return this.db.Garages.Where(g => g.Name == name).FirstOrDefault();
        }
    }
}
