using C64.Abstraction;

namespace C64.Addressing;

public class IndexAbsolute : IAddressingMode
{
    public static IndexAbsolute Instance { get; } = new();
    public AddressingMode Identifier => AddressingMode.IndexAbsolute;

    public byte[]? GetOperands(
        Bus bus,
        Registers registers,
        out bool requiresAdditionalCycle)
    {
        throw new NotImplementedException();
    }
}
