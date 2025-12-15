namespace CertifastStorage.Model
{
    public class Client
    {
        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public string Cpf { get; private set; }

        public Contact Contact { get; private set; }

        public ICollection<Company> Companies { get; private set; } = new List<Company>();
        public ICollection<Certificate> Certificates { get; private set; } = new List<Certificate>();
    }
}

