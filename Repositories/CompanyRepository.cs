using BugStore.Api.Repositories.Interface;
using CertifastStorage.Model;
using Microsoft.EntityFrameworkCore;

namespace CertifastStorage.Repositories
{
    public class CompanyRepository : IRepository<Company>
    {
        private readonly CertificateDbContext DbContext;
        public CompanyRepository(CertificateDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task AddAsync(Company obj, CancellationToken cancellationToken)
        {
            DbContext.Companies.Add(obj);
            await DbContext.SaveChangesAsync();
        }

        public async Task<List<Company>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await DbContext.Companies
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }

        public async Task<Company> GetByIdAsync(Guid Id, CancellationToken cancellationToken)
        {
            return await DbContext.Companies
                .FirstOrDefaultAsync(x => x.Id == Id);
        }
        public async Task<Company> GetByCnpjAsync(string cnpj, CancellationToken cancellationToken)
        {
            return await DbContext.Companies
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Cnpj == cnpj, cancellationToken);
        }
        public async Task RemoveAsync(Company obj, CancellationToken cancellationToken)
        {
            DbContext.Companies.Remove(obj);
            await DbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task UpdateAsync(Company obj, CancellationToken cancellationToken)
        {
            DbContext.Companies.Update(obj);
            await DbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
