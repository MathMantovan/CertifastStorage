using System.Security;

namespace CertifastStorage.Model
{
    public class Certificate
    {
        public  int Id { get; set; }
        public int OrderId { get; set; }
        public DateTime ExpiringDate { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public Company? Company { get; set; }
        public int? CompanyId { get; set; }
        public CertificateType CertificateType { get; set; }
        public int CertificateTypeId { get; set; }
        public AgentResponsable AgentResponsable { get; set; }
        public int AgentResponsableId { get; set; }

        public Certificate(int orderId, DateTime expiringDate, int clientId, Client client, Company? company, int? companyId, CertificateType certificateType, int certificateTypeId, AgentResponsable agentResponsable, int agentResponsableId)
        {
           
            OrderId = orderId;
            ExpiringDate = expiringDate;
            ClientId = clientId;
            Client = client;
            Company = company;
            CompanyId = companyId;
            CertificateType = certificateType;
            CertificateTypeId = certificateTypeId;
            AgentResponsable = agentResponsable;
            AgentResponsableId = agentResponsableId;
        }

        public Certificate()
        {
            
        }

        private bool VerificationOrderIdOnDb(int orderId)
        {
            return true;
        }
    }

}
