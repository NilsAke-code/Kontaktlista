using Business.Interfaces;
using Business.Models;

namespace Business.Factories;

public class ContactFactory
{
    private readonly IIdGenerator _idGenerator;

    public ContactFactory(IIdGenerator idGenerator) 
    {  
        _idGenerator = idGenerator; 
    }

    public ContactModel CreateContact(string firstName, string lastName, string email, string phoneNumber, string streetAddress, string postalCode, string City)
    {
        return new ContactModel
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            PhoneNumber = phoneNumber,
            StreetAddress = streetAddress,
            PostalCode = postalCode,
            City = City,
            Id = _idGenerator.GenerateId()

        };
    }
}
