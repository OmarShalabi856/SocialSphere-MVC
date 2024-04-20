using Microsoft.EntityFrameworkCore;
using SocialSphere___MVC.Models;

namespace SocialSphere___MVC.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Club> Clubs { get; set; }

        public DbSet<Address> Addresses { get; set; }

    }
}
