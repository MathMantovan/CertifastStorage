using BugStore.Api.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using CertifastStorage.Model;
using Microsoft.EntityFrameworkCore;

namespace CertifastStorage.Repositories
{
    public class CertificateRepository : IRepository<Certificate>
    {
        private readonly CertificateDbContext DbContext;
        public CertificateRepository(CertificateDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task AddAsync(Certificate obj, CancellationToken cancellationToken)
        {
            DbContext.Certificates.AddAsync(obj, cancellationToken);
            await DbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<Certificate>> GetAllAsync(CancellationToken cancellationToken)
             => await DbContext.Certificates.AsNoTracking().ToListAsync(cancellationToken);

        public Task<Certificate> GetByIdAsync(int Id, CancellationToken cancellationToken) 
            => DbContext.Certificates
                .FirstOrDefaultAsync(x => x.Id == Id, cancellationToken);

        public async Task RemoveAsync(Certificate obj, CancellationToken cancellationToken)
        {
            DbContext.Certificates.Remove(obj);
            await DbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task UpdateAsync(Certificate obj, CancellationToken cancellationToken)
        {
            DbContext.Certificates.Update(obj);
            await DbContext.SaveChangesAsync(cancellationToken);
        }
    }
}

