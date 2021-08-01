using Final_Project.InputModels.User;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public interface IUserService
{
    List<ApplicationUser> All();

    ApplicationUser Register(LoginInput input);
    ApplicationUser GetUserById(string id);
    ApplicationUser GetUserByEmail(string email);
    ApplicationUser Login(LoginInput input);

    ApplicationUser updateUser(string userId, ApplicationUser newData);
    ActionResult Logout();

    

}

