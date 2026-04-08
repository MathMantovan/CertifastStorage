using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CertifastStorage.Model;
using CertifastStorage.Repositories;
using CertifastStorage.Service;
//TODO:
//-Definir Aggregate Roots
//- Implementar Repositories orientados a caso de uso
//- Criar serviço de importação da planilha

namespace CertifastStorage
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            using var context = new CertificateDbContext();

            // APAGA O BANCO E TODOS OS DADOS (seguro somente em dev)
            context.Database.EnsureDeleted();

            // Aplica migrations / recria o banco conforme modelos
            context.Database.Migrate();

            Console.WriteLine("Banco recriado a partir das migrations.");
        }
    }
;
}