using Final_Project.InputModels.Garages;
using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Services
{
    public interface IGarageService
    {
        public ICollection<Garage> GetGarages();
        public Garage GetGarage(int garageId);
        public Garage AddGarage(GarageInput input);
        public Garage UpdateGarage(int garageId, object data);
        public Garage DeleteGarage(int garageId);


    }
}
