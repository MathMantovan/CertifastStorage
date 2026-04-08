using CertifastStorage.Exceptions;
using CertifastStorage.Model;
using CertifastStorage.Model.Enum;

namespace CertifastStorage.Factory
{
    public class CertificateTypeFactory
    {
        //public CertificateType CreateCertificateType(
        //            string stringFromSheet)
        //{
        //    var productType = ProductTypeFormat(stringFromSheet);

        //    var certificationType = new CertificateType(
        //        productType,
        //        level,
        //        storageType,
        //        validityInMonths,
        //        authority
        //    );

        //    ValidateCertificateType(certificationType);

        //    return certificationType;
        //}

        //private static string ParseLevel(string stringFromSheet)
        //{
        //    return stringFromSheet.Trim().ToUpper();
        //}
        //private string ParseProductType(string stringFromSheet)
        //{
        //    stringFromSheet;
        //    return stringFromSheet.Trim().ToUpper();
        //}

        private static string NormalizeString(string hardString)
        {
            if (string.IsNullOrWhiteSpace(hardString))
                return string.Empty;

            var stringNormalized = hardString.Trim();

            stringNormalized = stringNormalized.Replace("–", "-").Replace("—", "-");
            stringNormalized = stringNormalized.Replace("\t", " ");
            while (stringNormalized.Contains("  "))
                stringNormalized = stringNormalized.Replace("  ", " ");

            return stringNormalized.ToLowerInvariant();
        }

        

    }
}


