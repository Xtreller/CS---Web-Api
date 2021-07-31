using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public interface IUserService
{
    List<ApplicationUser> all();

    ApplicationUser Register(ApplicationUser user);
    ApplicationUser GetUserById(string id);
    ApplicationUser GetUserByEmail(string email);
    ApplicationUser Login(ApplicationUser user);

    ApplicationUser updateUser(string userId, ApplicationUser newData);
    ActionResult Logout();

    

}

