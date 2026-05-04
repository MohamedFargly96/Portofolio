using Microsoft.EntityFrameworkCore;
using Portofolio.Models;

namespace Portofolio.Databse
{
    public class AppContext_Cls : DbContext
    {
       
        public AppContext_Cls(DbContextOptions<AppContext_Cls>options):base(options)
        {
                
        }

        //add home table 
        public DbSet<Home_Cls> HomeDbset { get; set; }
        //add about table 
        public DbSet<About_Cls> AboutDbset { get; set; }
        //add projects table
        public DbSet<Projects_Cls> ProjectsDbset { get; set; }
    }
}
