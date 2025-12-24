using CertifastStorage.Model;
using CertifastStorage.Repositories;

namespace CertifastStorage.Service
{
    public class DbService
    {
        public DbService() { }
        public async Task AddContact(ContactRepository repo, Contact contat) 
            => await repo.AddAsync(contat, CancellationToken.None);
        public async Task<List<Contact>> GetAllContacts(ContactRepository repo) 
            => await repo.GetAllAsync(CancellationToken.None);
        public async Task GetContact(ContactRepository repo, Guid id) 
            => await repo.GetByIdAsync(id, CancellationToken.None);
        public async Task DeleteContact(ContactRepository repo, Contact contact)
            => await repo.RemoveAsync(contact, CancellationToken.None);



    }
}
