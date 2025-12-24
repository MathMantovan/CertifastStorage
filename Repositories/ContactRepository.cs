using BugStore.Api.Repositories.Interface;
using CertifastStorage.Model;
using Microsoft.EntityFrameworkCore;

namespace CertifastStorage.Repositories
{
    public class ContactRepository : IRepository<Contact>
    {
        private readonly CertificateDbContext DbContext;
        public ContactRepository(CertificateDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public async Task AddAsync(Contact obj, CancellationToken cancellationToken)
        {
            DbContext.Contacts.Add(obj);
            await DbContext.SaveChangesAsync();            
        }

        public async Task<List<Contact>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await DbContext.Contacts
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }

        public async Task<Contact> GetByIdAsync(Guid Id, CancellationToken cancellationToken)
        {
            return await DbContext.Contacts
                .FirstOrDefaultAsync(x => x.Id == Id);
        }

        public async Task RemoveAsync(Contact obj, CancellationToken cancellationToken)
        {
            DbContext.Contacts.Remove(obj);
            await DbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task UpdateAsync(Contact obj, CancellationToken cancellationToken)
        {
            DbContext.Contacts.Update(obj);
            await DbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
