using Microsoft.EntityFrameworkCore;

namespace RegistroVisitantes.Models;
    public class AppDbContext : DbContext 
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options) { }


        public DbSet<InfoVisitante> InfoVisitantes { get; set; }
    }
