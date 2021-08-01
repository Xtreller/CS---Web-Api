using Final_Project.Data;
using Final_Project.InputModels.User;
using Final_Project.Models;
using Final_Project.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

public class UserService : IUserService
{
    private ApplicationDbContext db;

    public UserService(ApplicationDbContext dbContext)
    {
        this.db = dbContext;
    }

    public List<ApplicationUser> All()
    {
        return this.db.Users.ToList();
    }

    public ApplicationUser GetUserById(string id)
    {
        return this.db.Users.Find(id);
    }
    public ApplicationUser GetUserByEmail(string email)
    {
        return this.db.Users.Where(user => user.Email == email).FirstOrDefault();
    }
    public ApplicationUser Login(LoginInput input)
    {
        var findUser = this.GetUserByEmail(input.Email);
        if (findUser != null)
        {
            bool isValidPassword = BCrypt.Net.BCrypt.Verify(input.Password, findUser.PasswordHash);
            if (isValidPassword)
            {
                //GenerateJwt.Generate(findUser.Id);
                return findUser;
            }
        }
        return null;
    }

    public ActionResult Logout()
    {
        throw new NotImplementedException();
    }

    public ApplicationUser Register(LoginInput input)
    {
        if (this.db.Users.ToArray().Any(user => user.Email == input.Email))
        {
            return null;
        }
        input.Password = BCrypt.Net.BCrypt.HashPassword(input.Password);
        var newUser = new ApplicationUser()
        {
            FirstName = input.FirstName,
            LastName = input.LastName,
            Email = input.Email,
            PasswordHash = input.Password,
            EmailConfirmed = true,

        };
        this.db.Users.Add(newUser);
        this.db.SaveChanges();

        return this.GetUserByEmail(newUser.Email);
    }

    public ApplicationUser updateUser(string userId, ApplicationUser newData)
    {
        throw new NotImplementedException();
    }
}

