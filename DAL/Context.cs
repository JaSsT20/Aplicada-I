using Microsoft.EntityFrameworkCore;

public class Context : DbContext
{
    public DbSet<Ocupations> Ocupations { get; set; }
    
    public DbSet<Person> Person { get; set; }

    public DbSet<Loans> Loans { get; set; }
    public Context(DbContextOptions<Context> options): base(options)
    {

    }
}