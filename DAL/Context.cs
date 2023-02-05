using Microsoft.EntityFrameworkCore;

public class Context : DbContext
{
    public DbSet<Ocupations> Ocupations { get; set; }
    
    public DbSet<Person> Person { get; set; }

    public DbSet<Loans> Loans { get; set; }

    public DbSet<Payments> Payments { get; set; }

    public DbSet<PaymentsDetail> PaaymentsDetail { get; set; }
    public Context(DbContextOptions<Context> options): base(options)
    {

    }
}