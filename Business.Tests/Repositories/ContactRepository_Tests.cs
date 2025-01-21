using Business.Models;
using Business.Repositories;

namespace Business.Tests.Repositories;

public class ContactRepository_Tests
{
    // Denna kod är genererad av Chat GPT 4.0 - Jag försökte först skapa en instans av ContactModel och bara tilldela ett värde till FirstName men min ContactModel lyste rött.
    // Denna kod är genererad av Chat GPT 4.0 - Chat GPT sa att alla egenskaper i min ContactModel är markerade med required så de måste tilldelas ett värde.
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

    // Denna kod är genererad av Chat GPT 4.0 - Eftersom ContactModel har required egenskaper så var varje instans tvunga att tilldelas ett värde, alltså FirstName, LastName etc.

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
            PhoneNumber = "0704577777",
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
            PostalCode = "33322",
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
