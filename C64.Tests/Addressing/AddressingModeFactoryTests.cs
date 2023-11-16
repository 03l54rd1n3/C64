using C64.Abstraction;
using C64.Addressing;

namespace C64.Tests.Addressing;

public class AddressingModeFactoryTests
{
    [Fact]
    public void Get_AnyAddressingMode_ReturnsCorrectAddressingMode()
    {
        // Arrange
        var addressingModes = Enum.GetValues<AddressingMode>();
        var factory = new AddressingModeFactory();

        foreach (var addressingMode in addressingModes)
        {
            // Act
            var result = factory.Get(addressingMode);
            var className = result.GetType().Name;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(addressingMode, result.Identifier);
            Assert.Equal(addressingMode.ToString(), className);
        }
    }
}
