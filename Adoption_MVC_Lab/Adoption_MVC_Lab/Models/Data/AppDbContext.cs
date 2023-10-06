using Microsoft.EntityFrameworkCore;

namespace Adoption_MVC_Lab.Models.Data;

public class AppDbContext :DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Animal> Animals { get; set; }
}
