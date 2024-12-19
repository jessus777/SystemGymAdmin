using Microsoft.AspNetCore.Identity;

namespace SystemGymAdmin.Domain.POCOEntities;
public class User
    : IdentityUser<string>
{
    public ICollection<Role> Roles { get; set; }
    public ICollection<Address> Addresses { get; set; }
    public DateTime BirthDate { get; set; }
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public string PaternalSurname { get; set; }
    public string MaternalSurname { get; set; }
}
