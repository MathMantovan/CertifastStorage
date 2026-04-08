namespace CertifastStorage.Model
{
    public class AgentResponsable
    {
        public int Id { get; set; }
        public string AgentPoint { get; set; }
        public ICollection<Certificate> Certificates { get; set; }

    }
}
  