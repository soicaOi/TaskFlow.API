namespace Application.Data.DataBaseContext;

public interface IApplicationDbContext
{
    public DbSet<CustomIdentityUser> Users { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
