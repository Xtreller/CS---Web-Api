using Final_Project.Data;
using Final_Project.InputModels.Garages;
using Final_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Final_Project.Services
{
    public class GarageService : IGarageService
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly ApplicationDbContext db;
        public GarageService(ApplicationDbContext dbContext,SignInManager<ApplicationUser> signInManager,UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
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

        public Garage AddGarage(GarageInput input)
        {
            var newGarage = new Garage() {

                Name = input.Name,
                Town = input.Town,
                Address = input.Address,
                OwnerId = input.User_Id
            };

            this.db.Garages.Add(newGarage);
            this.db.SaveChanges();

            return this.GetGarage(newGarage.Id);
        }
    }
}
