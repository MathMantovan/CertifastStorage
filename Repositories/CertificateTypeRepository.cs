using BugStore.Api.Repositories.Interface;
using CertifastStorage.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CertifastStorage.Repositories
{
    public class CertificateTypeRepository : IRepository<CertificateType>
    {
        private readonly CertificateDbContext DbContext;
        public CertificateTypeRepository(CertificateDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task AddAsync(CertificateType obj, CancellationToken cancellationToken)
        {
            DbContext.Set<CertificateType>().Add(obj);
            await DbContext.SaveChangesAsync();
        }

        public async Task<List<CertificateType>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await DbContext.Set<CertificateType>()
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }

        public async Task<CertificateType> GetByIdAsync(Guid Id, CancellationToken cancellationToken)
        {
            return await DbContext.Set<CertificateType>()
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == Id, cancellationToken);
        }

        public async Task RemoveAsync(CertificateType obj, CancellationToken cancellationToken)
        {
            DbContext.Set<CertificateType>().Remove(obj);
            await DbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task UpdateAsync(CertificateType obj, CancellationToken cancellationToken)
        {
            DbContext.Set<CertificateType>().Update(obj);
            await DbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
