using SystemGymAdmin.Domain.Common.Enums;

namespace SystemGymAdmin.Domain.POCOEntities;
public class Permission
{
    public Guid Id { get; set; } 
    public string Name { get; set; }
    public PermissionType PermissionType { get; set; }

    public ICollection<RolePermission> RolePermissions { get; set; }
}
