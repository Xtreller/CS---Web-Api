using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Services.User
{
    public interface IUserService
    {
         object getUser(string id);
        string deleteUser(string id);

        ApplicationUser register(string email, string password);
        string login(string email, string password);

    }
}
