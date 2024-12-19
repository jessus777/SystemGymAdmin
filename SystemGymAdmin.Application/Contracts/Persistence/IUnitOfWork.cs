namespace SystemGymAdmin.Application.Contracts.Persistence;
public interface IUnitOfWork
    : IDisposable
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    Task BeginTransactionAsync();
    Task CommitTransactionAsync();
    Task RollbackTransactionAsync();
}
