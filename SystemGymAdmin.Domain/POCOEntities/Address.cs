namespace SystemGymAdmin.Domain.POCOEntities;
public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }

    public Guid? UserId { get; set; }
    public User User { get; set; }
}
