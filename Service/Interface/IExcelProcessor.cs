using CertifastStorage.Model;

namespace Certifast.Console.Services.Interface
{
    public interface IExcelProcessor
    {
        List<Certificate> ProcessRenovationSheet(string path);
        List<Certificate> ProcessMonthCompilationSheet(string path);
    }
    
}