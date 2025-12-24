using CertifastStorage.Model.Enum;

public class CertificateType
{
    public Guid Id { get; private set; }

    public CertificateProductType ProductType { get; private set; }
    public CertificateLevel Level { get; private set; }
    public CertificateStorageType StorageType { get; private set; }

    public int ValidityInMonths { get; private set; }

    public CertificateAuthority Authority { get; private set; }

    protected CertificateType() { }

    public CertificateType(
        CertificateProductType productType,
        CertificateLevel level, 
        CertificateStorageType storageType,
        int validityInMonths,
        CertificateAuthority authority,
        string displayName
    )
    {
        ProductType = productType;
        Level = level;
        StorageType = storageType;
        ValidityInMonths = validityInMonths;
        Authority = authority;
    }

    //private void Validate()
    //{
    //    if (Level == CertificateLevel.A1 && StorageType != CertificateStorageType.Computer)
    //        throw new DomainException("Certificados A1 devem ser do tipo Computador.");

    //    if (ValidityInMonths <= 0)
    //        throw new DomainException("Validade inválida.");

    //    if (ProductType == CertificateProductType.ECnpjPme &&
    //        ProductType != CertificateProductType.ECnpjPme)
    //        throw new DomainException("PME só é permitido para e-CNPJ.");
    //}
}
