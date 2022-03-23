using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sooziales_Netzwerk.Models;

namespace Sooziales_Netzwerk.Data{

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
            => services.AddDbContext<ApplicationDbContext>();
    }

    public class Sooziales_NetzwerkDbContext : DbContext
    {
        public Sooziales_NetzwerkDbContext(DbContextOptions<Sooziales_NetzwerkDbContext> options)
            : base(options)
        {
        }

        public DbSet<Link> Link {get; set;}
}
}
