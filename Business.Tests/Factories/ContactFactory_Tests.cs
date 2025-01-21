using Business.Factories;
using Business.Helpers;

namespace Business.Tests.Factories;

public class ContactFactory_Tests
{
    [Fact]
    public void CreateContact_ShouldReturnValidContactModel()
    {
        // Arrange
        var idGenerator = new IdGenerator();
        var factory = new ContactFactory(idGenerator);

        //Act 
        var contact = factory.CreateContact("Stefan", "Aragao", "Stefan@gmail.com", "0701234567", "Hönsgatan 8", "54321", "Örebro");


        //Assert

        // Denna kod är generad av Chat GPT 4.0 - Denna kod gör att testet verifierar att metoden CreateContact inte returnerar null.
        // Om 'contact' är null så har något gått fel i metoden och testet misslyckas.
        Assert.NotNull(contact);

        Assert.Equal("Stefan", contact.FirstName);
        Assert.Equal("Aragao", contact.LastName);
        Assert.Equal("Stefan@gmail.com", contact.Email);
        Assert.Equal("0701234567", contact.PhoneNumber);
        Assert.Equal("Hönsgatan 8", contact.StreetAddress);
        Assert.Equal("54321", contact.PostalCode);
        Assert.Equal("Örebro", contact.City);

        // Denna kod är genererad av Chat GPT 4.0 - Denna kod gör att testet verifierar att kontakten som skapas får ett giltigt GUID Id som inte är tomt (Guid.Empty).
        // Om det blir ett tomt GUID så innebär det att 'IdGenerator' inte har lyckats generera ett unikt ID korrekt och då blir det fel.
        Assert.NotEqual(Guid.Empty, contact.Id);
    }
}
