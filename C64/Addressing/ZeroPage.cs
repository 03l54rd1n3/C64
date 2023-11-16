using C64.Abstraction;

namespace C64.Addressing;

public class ZeroPage : IAddressingMode
{
    public static ZeroPage Instance { get; } = new();
    public AddressingMode Identifier => AddressingMode.ZeroPage;

    public byte[]? GetOperands(
        Bus bus,
        Registers registers,
        out bool requiresAdditionalCycle)
    {
        throw new NotImplementedException();
    }
}