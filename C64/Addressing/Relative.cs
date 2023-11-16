using C64.Abstraction;

namespace C64.Addressing;

public class Relative : IAddressingMode
{
    public static Relative Instance { get; } = new();
    public AddressingMode Identifier => AddressingMode.Relative;

    public byte[]? GetOperands(
        Bus bus,
        Registers registers,
        out bool requiresAdditionalCycle)
    {
        throw new NotImplementedException();
    }
}