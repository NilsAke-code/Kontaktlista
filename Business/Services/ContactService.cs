using Business.Factories;
using Business.Interfaces;
using Business.Models;

namespace Business.Services
{
    public class ContactService(IContactRepository repository, ContactFactory factory, IFileService fileService) : IContactService
    {
        private readonly IContactRepository _repository = repository;
        private readonly ContactFactory _factory = factory;
        private readonly IFileService _fileService = fileService;

        // Jag fick hjälp av Chatgpt 4o att ändra returtyp till en bool från void, för att jag vill få en indikering om kontakten skapades korrekt eller om det blev fel.
        public bool CreateContact(string firstName, string lastName, string email, string phoneNumber, string streetAddress, string postalCode, string city)
        {
            try
            {
                var contact = new ContactModel
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    PhoneNumber = phoneNumber,
                    StreetAddress = streetAddress,
                    PostalCode = postalCode,
                    City = city
                };

                // Lägger till kontakten i repository.
                _repository.AddContact(contact);

                // Returnerar true om det lyckades.
                return true;
            }
            catch (Exception ex)
            {
                
                Console.WriteLine($"An error occurred: {ex.Message}");

                // Returnerar false om det misslyckades.
                return false;
            }
        }

        public List<ContactModel> GetAllContacts()
        {
            return _repository.GetAllContacts();
        }

        public void SaveContacts(string filePath)
        {
            var contacts = _repository.GetAllContacts();
            _fileService.SaveToFile(filePath, contacts);
        }
        
        public void LoadContacts(string filePath)
        {
            var contacts = _fileService.LoadFromFile(filePath);
            foreach (var contact in contacts)
            { // Chatgpt 4o gav som förslag att lägga in en metod för att undvika dubletter, först hämtar den alla kontakter som redan finns -
                // om kontakten har samma unika ID (Guid) så läggs inte kontakten till.
                if (!_repository.GetAllContacts().Any(c => c.Id == contact.Id))
                {
                    _repository.AddContact(contact);
                }
            }
        }
    }
}
