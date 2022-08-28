

using Microsoft.EntityFrameworkCore;

namespace OnlyCodeFirstApproach.Models
{
    public class AppDbContext:DbContext
    {
        public DbSet<Item> Items { get; set; }//is ke zariye table bne ga db me
       
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions options):base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
