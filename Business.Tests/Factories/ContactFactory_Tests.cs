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
        Assert.NotNull(contact);
        Assert.Equal("Stefan", contact.FirstName);
        Assert.Equal("Aragao", contact.LastName);
        Assert.Equal("Stefan@gmail.com", contact.Email);
        Assert.Equal("0701234567", contact.PhoneNumber);
        Assert.Equal("Hönsgatan 8", contact.StreetAddress);
        Assert.Equal("54321", contact.PostalCode);
        Assert.Equal("Örebro", contact.City);
        Assert.NotEqual(Guid.Empty, contact.Id);
    }
}
