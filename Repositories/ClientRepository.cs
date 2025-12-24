using BugStore.Api.Repositories.Interface;
using CertifastStorage.Model;
using Microsoft.EntityFrameworkCore;

namespace CertifastStorage.Repositories
{
    public class ClientRepository : IRepository<Client>
    {
        private readonly CertificateDbContext DbContext;
        public ClientRepository(CertificateDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task AddAsync(Client obj, CancellationToken cancellationToken)
        {
            DbContext.Clients.Add(obj);
            await DbContext.SaveChangesAsync();
        }

        public async Task<List<Client>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await DbContext.Clients
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }

        public async Task<Client> GetByIdAsync(Guid Id, CancellationToken cancellationToken)
        {
            return await DbContext.Clients
                .FirstOrDefaultAsync(x => x.Id == Id, cancellationToken);
        }

        public async Task<Client> GetByCpfAsync(string cpf, CancellationToken cancellationToken)
        {
            return await DbContext.Clients
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Cpf == cpf, cancellationToken);
        }

        public async Task RemoveAsync(Client obj, CancellationToken cancellationToken)
        {
            DbContext.Clients.Remove(obj);
            await DbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task UpdateAsync(Client obj, CancellationToken cancellationToken)
        {
            DbContext.Clients.Update(obj);
            await DbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
