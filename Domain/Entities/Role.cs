
namespace Domain.Entities;

public class Role : BaseEntity
{
    public string Name { get; set; } = null!;

    public List<UserRole>? UserRoles { get; set; }
    public List<RoleClaim>? RoleClaims { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
}