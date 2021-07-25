using Final_Project.Models;
using Final_Project.Models.Bussiness;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Garage> Garages { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<WorkingHours> WorkingHours { get; set; }
        public DbSet<WorkingDays> WorkingDays { get; set; }
    }
}
