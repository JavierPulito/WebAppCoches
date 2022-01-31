using Microsoft.EntityFrameworkCore;
using WebAppCoches.Model;

namespace WebAppCoches.Repository
{
    public class MiDBContext : DbContext
    {

        public MiDBContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\ProjectModels;Database=Pruebas;Trusted_Connection=True;");
        }
        public DbSet<CocheModel> Coches { get; set; }
        public DbSet<RuedaModel> Ruedas { get; set; }

    }
}
