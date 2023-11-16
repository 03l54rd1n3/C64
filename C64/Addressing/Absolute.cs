using C64.Abstraction;

namespace C64.Addressing;

public class Absolute : IAddressingMode
{
    public static Absolute Instance { get; } = new();
    public AddressingMode Identifier => AddressingMode.Absolute;

    public byte[]? GetOperands(
        Bus bus,
        Registers registers,
        out bool requiresAdditionalCycle)
    {
        throw new NotImplementedException();
    }
}
