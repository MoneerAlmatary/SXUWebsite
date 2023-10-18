using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SXUWebsite.Models;
using System.Security.Claims;

namespace SXUWebsite.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Brokerage> Brokerages { get; set; }
        public DbSet<ListedCom> ListedComs { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<Investors> Investors { get; set; }
        public DbSet<Stocks> Stocks { get; set; }
        public object ListedCom { get; internal set; }
        public DbSet<Category> Category { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        internal dynamic GetUserId(ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }


        
    }
}