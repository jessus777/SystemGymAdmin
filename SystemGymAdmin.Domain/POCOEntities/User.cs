using Microsoft.AspNetCore.Identity;

namespace SystemGymAdmin.Domain.POCOEntities;
public class User
    : IdentityUser<Guid>
{
    public ICollection<UserRole> UserRoles { get; set; } // Relación muchos a muchos con roles
    public ICollection<Address> Addresses { get; set; }
    public DateTime BirthDate { get; set; }
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public string PaternalSurname { get; set; }
    public string MaternalSurname { get; set; }
    public long Consecutivo { get; set; }
}
