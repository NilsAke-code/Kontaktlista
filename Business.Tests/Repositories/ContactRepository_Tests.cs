
using Business.Repositories;
using Business.Models;

namespace Business.Tests.Repositories;

public class ContactRepository_Tests
{
    [Fact]
    public void AddContact_ShouldAddContactToList()
    {
        //Arrange
        var repository = new ContactRepository();
        var contact = new ContactModel
        {
            FirstName = "Stefan",
            LastName = "Aragao",
            Email = "Stefan@gmail.com",
            PhoneNumber = "1234567890",
            StreetAddress = "Hönsgatan 8",
            PostalCode = "54321",
            City = "Örebro"
        };

        //Act
        repository.AddContact(contact);

        //Assert
        Assert.Single(repository.GetAllContacts());
    }
    [Fact]
    public void GetAllContacts_ShouldReturnAllContacts()
    {
        //Arrange
        var repository = new ContactRepository();

        var contact1 = new ContactModel
        {
            FirstName = "Stefan",
            LastName = "Aragao",
            Email = "Stefan@gmail.com",
            PhoneNumber = "1234567777",
            StreetAddress = "Hönsgatan 8",
            PostalCode = "54312",
            City = "Örebro"
        };
        var contact2 = new ContactModel
        {
            FirstName = "Nils",
            LastName = "Lindqvist",
            Email = "Nils@gmail.com",
            PhoneNumber = "0721233333",
            StreetAddress = "Vanillagatan 24",
            PostalCode = "12345",
            City = "Stockholm"
        };

        //Act
        repository.AddContact(contact1);
        repository.AddContact(contact2);
        var contacts = repository.GetAllContacts();

        //Assert
        Assert.Equal(2, contacts.Count);
    }
}
