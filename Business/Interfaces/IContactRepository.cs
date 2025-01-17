using Business.Models;

namespace Business.Interfaces;

public interface IContactRepository
{
    void AddContact(ContactModel contact);
    List<ContactModel> GetAllContacts();
}
