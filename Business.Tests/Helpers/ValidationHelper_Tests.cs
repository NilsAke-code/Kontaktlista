using Business.Helpers;

namespace Business.Tests.Helpers;

public class ValidationHelper_Tests
{
    [Fact]
    public void IsValidEmail_ShouldReturnTrue_ForValidEmail()
    {
        // Arrange 
        string email = "nils@gmail.com";

        // Act
        bool result = ValidationHelper.IsValidEmail(email);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsValidEmail_ShouldReturnFalse_ForInValidEmail()
    {
        // Arrange
        string email = "Invalid email";

        //Act
        bool result = ValidationHelper.IsValidEmail(email);

        //Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValidPostalCode_ShouldReturnTrue_ForValidPostalCode()
    {
        //Arrange
        string postalCode = "12345";

        //Act
        bool result = ValidationHelper.IsValidPostalCode(postalCode);

        //Assert
        Assert.True(result);
    }

    [Fact]
    public void IsValidPostalCode_ShouldReturnFalse_ForInvalidPostalCode()
    {
        //Arrange
        string postalCode = "12345678";  //Inte svenskt postnummer

        //Act
        bool result = ValidationHelper.IsValidPostalCode(postalCode);

        //Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValidPhoneNumber_ShouldReturnTrue_ForValidPhoneNumber()
    {
        //Arrange
        string phoneNumber = "+46721233366";

        //Act
        bool result = ValidationHelper.IsValidPhoneNumber(phoneNumber);

        //Assert
        Assert.True(result);
    }

    [Fact]
    public void IsValidPhoneNumber_ShouldReturnFalse_ForInvalidPhoneNumber()
    {
        //Arrange
        string phoneNumber = "1111111";

        //Act
        bool result = ValidationHelper.IsValidPhoneNumber(phoneNumber);

        //Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValidStreetAddress_ShouldReturnTrue_ForValidStreetAddress()
    {
        //Arrange
        string streetAddress = "Vanlliagatan 5";

        //Act
        bool result = ValidationHelper.IsValidStreetAddress(streetAddress);

        //Assert
        Assert.True(result);
    }

    [Fact]
    public void IsValidStreetAddress_ShouldReturnFalse_ForInValidStreetAddress()
    {
        //Arrange
        string streetAddress = "Calle De las Torres";

        //Act
        bool result = ValidationHelper.IsValidStreetAddress(streetAddress);

        //Assert
        Assert.False(result);
    }

    [Fact]
    public void IsValidCity_ShouldReturnTrue_ForValidCity()
    {
        //Arrange
        string city = "Örebro";

        //Act
        bool result = ValidationHelper.IsValidCity(city);

        //Assert
        Assert.True(result);
    }

    [Fact]
    public void IsValidCity_ShouldReturnFalse_ForInValidCity()
    {
        //Arrange
        string city = "New York";

        //Act
        bool result = ValidationHelper.IsValidCity(city);

        //Assert
        Assert.False(result);
    }
}
