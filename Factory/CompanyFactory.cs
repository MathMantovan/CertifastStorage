using CertifastStorage.Model;

namespace CertifastStorage.Factory
{
    public class CompanyFactory
    {
        public Company Create(string companyName, string cnpj)
        {
            return new Company()
            {
                CompanyName = companyName,
                Cnpj = ValidateCnpj(cnpj),

            };
        }

        private static string ValidateCnpj(string cnpj)
        {
            // Implement CNPJ validation logic here
            // Throw an exception if the CNPJ is invalid
            return cnpj;
        }
    }
}
