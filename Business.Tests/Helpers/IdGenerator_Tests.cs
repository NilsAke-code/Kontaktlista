using Business.Helpers;

namespace Business.Tests.Helpers;

public class IdGenerator_Tests
{
    [Fact]
    public void GenerateId_ShouldReturnUniqueGuid()
    {
        // Arrange
        var idGenerator = new IdGenerator();

        //Act
        var id1 = idGenerator.GenerateId();
        var id2 = idGenerator.GenerateId();

        //Assert
        Assert.NotEqual(id1, id2);
        Assert.NotEqual(Guid.Empty, id1);
        Assert.NotEqual(Guid.Empty, id2);
    }
}
