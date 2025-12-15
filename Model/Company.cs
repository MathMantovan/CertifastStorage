using System;
using System.Collections.Generic;
using System.Text;

namespace CertifastStorage.Model
{
    public class Company
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public string Cnpj { get; set; }
        public Client Client { get; set; }
        public Guid ClientId { get; set; }
        public ICollection<Certificate> Certificates { get; set; }
    }

}
