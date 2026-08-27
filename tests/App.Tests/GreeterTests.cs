using Xunit;
using App;

public class GreeterTests
{
    [Fact]
    public void Greet_ReturnsExpectedMessage()
    {
        Assert.Equal("Hello from .NET demo!", Greeter.Greet());
    }
}
