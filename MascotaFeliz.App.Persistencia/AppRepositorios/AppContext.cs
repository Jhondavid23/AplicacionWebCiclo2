using Microsoft.EntityFrameworkCore;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set;} 
        public DbSet<Empleado> Empleado { get; set;} 
        public DbSet<Bicicleta> Bicicleta { get; set;}
        public DbSet<Visita> Visita { get; set;}  

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =TallerBicicleta");
            }
        }
    }
}