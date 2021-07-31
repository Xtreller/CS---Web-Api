using Final_Project.Data;
using Final_Project.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

public class UserService : IUserService
{
    private ApplicationDbContext db;

    public UserService(ApplicationDbContext dbContext)
    {
        this.db = dbContext;
    }
        
    public List<ApplicationUser> all()
    {
        return this.db.Users.ToList();
    }

    public ApplicationUser GetUserById(string id)
    {
       return this.db.Users.Find(id);
    }
    public ApplicationUser GetUserByEmail(string email)
    {
        return this.db.Users.Where(user=>user.Email == email ).FirstOrDefault();
    }
    public ApplicationUser Login(ApplicationUser user)
    {
        var findUser = this.GetUserByEmail(user.Email);
        if (findUser != null) {
            bool isValidPassword = BCrypt.Net.BCrypt.Verify(user.PasswordHash,findUser.PasswordHash);
            if (isValidPassword) {
                return findUser;
            }
        }
        return null;
    }

    public ActionResult Logout()
    {
        throw new NotImplementedException();
    }

    public ApplicationUser Register(ApplicationUser user)
    {
        if (this.db.Users.ToArray().Contains(user)) {
            return null;
        }
        user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(user.PasswordHash);
         this.db.Users.Add(user);
        this.db.SaveChanges();
        
        return this.GetUserByEmail(user.Email);
    }

    public ApplicationUser updateUser(string userId, ApplicationUser newData)
    {
        throw new NotImplementedException();
    }
}

