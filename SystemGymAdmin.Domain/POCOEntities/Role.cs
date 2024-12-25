using Microsoft.AspNetCore.Identity;

namespace SystemGymAdmin.Domain.POCOEntities;
public class Role
    : IdentityRole<Guid>
{
    public ICollection<UserRole> UserRoles { get; set; }
    public ICollection<RolePermission> RolePermissions { get; set; }
}
