namespace SystemGymAdmin.Domain.Common;
public abstract class BaseEntity

{
    protected BaseEntity()
    {

    }

    protected BaseEntity(string createByUser, DateTime dateCreated, string updateByUser, DateTime dateUpdate)
    {
        CreateByUser = createByUser;
        DateCreated = dateCreated;
        UpdateByUser = updateByUser;
        DateUpdate = dateUpdate;
    }

    public string CreateByUser { get; set; }
    public DateTime DateCreated { get; set; }
    public string UpdateByUser { get; set; }
    public DateTime DateUpdate { get; set; }
}
