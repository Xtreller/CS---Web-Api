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
        public Garage AddGarage(string name, string town, string address);
        public Garage UpdateGarage(int garageId, object data);
        public Garage DeleteGarage(int garageId);


    }
}
