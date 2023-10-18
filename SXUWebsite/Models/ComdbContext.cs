//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;
//using SXUWebsite.Models;

//namespace SXUWebsite.Data
//{
//    public class ComdbContext : DbContext
//    {
//        protected override void OnConfiguring(DbContextOptionsBuilder op)
//        {

//            op.UseSqlServer("Data Source=DESKTOP-7HALKG1;Initial Catalog=SXUWebsite;Integrated Security=True");
//        }
//        public ComdbContext(DbContextOptions<ComdbContext> options)
//            : base(options)
//        {
//        }

//        public DbSet<Brokerage> Brokerages { get; set; }
//        public DbSet<ListedCom> ListedComs { get; set; }
//        public DbSet<ContactUs> ContactUs { get; set; }
       

//    }
//}