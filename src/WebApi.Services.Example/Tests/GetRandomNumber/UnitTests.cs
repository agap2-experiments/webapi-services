using WebApi.Services.Example.EndPoints.GetRandomNumber;

namespace WebApi.Services.Example.Tests.GetRandomNumber;

public class UnitTests
{
    [Fact]
    public void ShouldHaveResult()
    {
        // Arrange

        // Act
        var service = new GetRandomNumberService();

        // Assert
        Assert.NotNull(service.GetRandomNumber());
    }
}
