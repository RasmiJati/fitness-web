using fitness.Models;
using Microsoft.EntityFrameworkCore;

namespace fitness.Data
{
    public class ApplicationDbContext : DbContext
    {
        //in constructor we will receive some options and pass to the base class i.e. DbContext
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)  //configuring dbContext
        {

        }
        public DbSet<User> Users { get; set; }  //create Users table in database using DbSet
    }
}
