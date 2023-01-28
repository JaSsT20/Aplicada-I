using Microsoft.EntityFrameworkCore;

public class Context : DbContext
{
    public DbSet<Ocupations> Ocupations { get; set; }

    public Context(DbContextOptions<Context> options): base(options)
    {

    }
}