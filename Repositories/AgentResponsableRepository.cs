using BugStore.Api.Repositories.Interface;
using CertifastStorage.Model;
using Microsoft.EntityFrameworkCore;

namespace CertifastStorage.Repositories
{
    public class AgentResponsableRepository : IRepository<AgentResponsable>
    {
        private readonly CertificateDbContext DbContext;
        public AgentResponsableRepository(CertificateDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task AddAsync(AgentResponsable obj, CancellationToken cancellationToken)
        {
            DbContext.AgentResponsable.Add(obj);
            await DbContext.SaveChangesAsync();
        }

        public async Task<List<AgentResponsable>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await DbContext.AgentResponsable
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }

        public async Task<AgentResponsable> GetByIdAsync(int Id, CancellationToken cancellationToken)
        {
            return await DbContext.AgentResponsable
                .FirstOrDefaultAsync(x => x.Id == Id, cancellationToken);
        }

      

        public async Task RemoveAsync(AgentResponsable obj, CancellationToken cancellationToken)
        {
            DbContext.AgentResponsable.Remove(obj);
            await DbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task UpdateAsync(AgentResponsable obj, CancellationToken cancellationToken)
        {
            DbContext.AgentResponsable.Update(obj);
            await DbContext.SaveChangesAsync(cancellationToken);
        }
    }
}