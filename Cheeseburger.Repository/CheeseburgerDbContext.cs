using System.Data.Entity;
using Cheeseburger.Domain;


namespace Cheeseburger.Repository
{
    public class CheeseburgerDbContext : DbContext
    {

        public CheeseburgerDbContext() : base()
        {
            Database.SetInitializer<CheeseburgerDbContext>(new CreateDatabaseIfNotExists<CheeseburgerDbContext>());
        }

        public DbSet<TargetClass> TargetClasses { get; set; }
        public DbSet<TargetField> TargetFields { get; set; }
    }
}
