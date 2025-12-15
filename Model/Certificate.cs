using System;
using System.Collections.Generic;
using System.Text;

namespace CertifastStorage.Model
{
    public class Certificate
    {
        public Guid Id { get; set; }
        public int OrderId { get; set; }
        public DateTime ExpiringDate { get; set; }
        public Guid ClientId { get; set; }
        public Client Client { get; set; }
        public Company? Company { get; set; }
        public Guid? CompanyId { get; set; }
        public CertificateType CertificateType { get; set; }
        public Guid CertificateTypeId { get; set; }
        public AgentResponsable AgentResponsable { get; set; }
        public Guid AgentResponsableId { get; set; }
    }

}
