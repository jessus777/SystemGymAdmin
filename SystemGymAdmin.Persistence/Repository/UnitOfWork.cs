using Microsoft.EntityFrameworkCore.Storage;
using SystemGymAdmin.Application.Contracts.Persistence;
using SystemGymAdmin.Persistence.Contexts;

namespace SystemGymAdmin.Persistence.Repository;
public class UnitOfWork
    : IUnitOfWork
{
    private IDbContextTransaction _transaction;
    private readonly ApplicationDbEFContext _context;

    public async Task BeginTransactionAsync()
    {
        _transaction = await _context.Database
            .BeginTransactionAsync();
    }

    public async Task CommitTransactionAsync()
    {
        if (_transaction is not null)
        {
            await _transaction.CommitAsync();
            await _transaction.DisposeAsync();
        }
    }

    public void Dispose()
    {
        _context.Dispose();
        _transaction?.Dispose();

    }

    public async Task RollbackTransactionAsync()
    {
        if (_transaction is not null)
        {
            await _transaction.RollbackAsync();
            await _transaction.DisposeAsync();
        }
    }

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
    {
        return await _context.SaveChangesAsync(cancellationToken);
    }
}
