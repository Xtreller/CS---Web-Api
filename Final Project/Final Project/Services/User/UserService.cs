using Final_Project.Data;
using Final_Project.Models;
using Microsoft.AspNetCore.Identity;
using System;


namespace Final_Project.Services.User
{
    public class UserService : IUserService
    {
        private ApplicationDbContext db;

        public UserService(ApplicationDbContext dbContext)
        {
            this.db = dbContext;
        }
        public string deleteUser(string id)
        {
            throw new NotImplementedException();
        }

        public object getUser(string id)
        {
            return this.db.Users.Find(id);
        }

        public string login(string email, string password)
        {
            throw new NotImplementedException();
        }

        
        public ApplicationUser register(string email, string password)
        {
            var user = new ApplicationUser()
            {
                Email = email,
                PasswordHash = password,
            };
            this.db.Users.Add(user);
            return user;
        }

        public string updateUser(string id, string data)
        {
            throw new NotImplementedException();
        }

       
    }
}
