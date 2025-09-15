namespace Infrastructure.Data.Configurations;

public class FullNameConfiguration : IEntityTypeConfiguration<CustomIdentityUser>
{
    public void Configure(EntityTypeBuilder<CustomIdentityUser> builder)
    {
        builder.OwnsOne(user => user.FullName, fullName =>
        {
            fullName.Property(p => p.FirstName).HasColumnName("FirstName");
            fullName.Property(p => p.LastName).HasColumnName("LastName");
            fullName.Property(p => p.MiddleName).HasColumnName("MiddleName");
        });
    }
}
