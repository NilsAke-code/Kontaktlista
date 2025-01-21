using Business.Models;
using Business.Services;

namespace Business.Tests.Services;

public class FileService_Tests
{
    [Fact]
    public void SaveToFile_ShouldCreateFile_WithValidJson()
    {
        //Arrange
        var fileService = new FileService();

        string filePath = "contacts.json_test";

        var contacts = new List<ContactModel>
        {
            new ContactModel
            {
                FirstName = "Test",
                LastName = "Test",
                Email = "Test",
                PhoneNumber = "Test",
                City = "Test",
                StreetAddress = "Test",
                PostalCode = "Test"
            }
        };

        //Act 
        fileService.SaveToFile(filePath, contacts);

        //Assert
        Assert.True(File.Exists(filePath));
        
        string content = File.ReadAllText(filePath);
        Assert.Contains("Test", content);

        // Denna kod är genererad av Chat GPT 4.0 - Denna kod gör att testfilen tas bort efter testet har utförts för att undvika att skräpa ner.

        // Cleanup
        File.Delete(filePath);
    }

    [Fact]
    public void LoadFromFile_ShouldReturnEmptyList_IfFileDoesNotExist()
    {
        // Arrange
        var fileService = new FileService();

        string filePath = "empty.json_file";

        //Act
        var contacts = fileService.LoadFromFile(filePath);

        //Assert
        Assert.Empty(contacts);
    }

    [Fact]
    public void LoadFromFile_ShouldReturnListOfContacts_IfFileExists()
    {
        //Arrange
        var fileService = new FileService();

        string filePath = "contacts.json_test";

        var contactsToSave = new List<ContactModel>
        {
            new ContactModel
            {
                FirstName = "Test",
                LastName = "Test",
                Email = "Test",
                PhoneNumber = "Test",
                City = "Test",
                StreetAddress = "Test",
                PostalCode = "Test"
            }
        };
        fileService.SaveToFile(filePath, contactsToSave);

        //Act
        var contacts = fileService.LoadFromFile(filePath);

        //Assert
        Assert.Single(contacts);
        Assert.Equal("Test", contacts[0].FirstName);

        //Cleanup
        File.Delete(filePath);
    }
}
