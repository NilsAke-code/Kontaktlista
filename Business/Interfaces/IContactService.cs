using Business.Models;

namespace Business.Interfaces
{
    public interface IContactService
    {
        bool CreateContact(string firstName, string lastName, string email, string phoneNumber, string streetAddress, string postalCode, string city);
        List<ContactModel> GetAllContacts();

        void SaveContacts(string filePath);
        void LoadContacts(string filePath);
    }
}
