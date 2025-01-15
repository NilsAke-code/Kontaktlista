
using Business.Interfaces;
using Business.Models;

namespace Business.Repositories
{

    public class ContactRepository : IContactRepository
    {
        private readonly List<ContactModel> _contacts = [];

        public void AddContact(ContactModel contact)
        {
            _contacts.Add(contact);
        }

        public List<ContactModel> GetAllContacts()
        {
            return _contacts;
        }
    }
}
