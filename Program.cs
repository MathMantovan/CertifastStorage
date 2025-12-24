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
            var context = new CertificateDbContext();
            var repository = new ContactRepository(context);

            var newcontact = new Contact{
                Id = Guid.NewGuid(),
                Cell1 = "1195847653",
                Cell2 = "1549897653",
                Email1 = "ma@ma",
                Email2 = "da@da"
            };

            var service = new DbService();
            await service.AddContact(repository, newcontact);
            Console.WriteLine("Contato adicionado deseja excluir o outro agora? ");
            Console.ReadLine();

            var Contacts = await service.GetAllContacts(repository);
            var con1 = Contacts.FirstOrDefault(x => x.Cell1 == "11954548787");

            await service.DeleteContact(repository, con1);

            Console.WriteLine("Contato excluido deseja ler o resto dos contatos?");
            Console.ReadLine();

            foreach (var con in Contacts)
            {
                Console.WriteLine($"cell1:{con.Cell1} e email1:{con.Email1}");
            }
            Console.ReadLine();

        }
    }
;
}