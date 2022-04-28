using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SecondServer
{
    public class ServerContext : DbContext
    {
        //Elvileg ennyit kellene tennie az uj adatbazis letrehozasara, de nem csinal semmit
        public ServerContext() : base("karbantartoDB_V2")
        {
            //Database.SetInitializer<ServerContext>(new CreateDatabaseIfNotExists<ServerContext>());
            Database.SetInitializer<ServerContext>(new DropCreateDatabaseIfModelChanges<ServerContext>());
        }

        public DbSet<Version> Versions { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<MainCategory> MainCategories { get; set; }
        public DbSet<Occupation> Occupations { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
