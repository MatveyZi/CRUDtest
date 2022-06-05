using System.Data.Entity;

namespace MainProject
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("DefaultConnection")
        {

        }
        public DbSet<Person> Persons { get; set; }
    }
}
