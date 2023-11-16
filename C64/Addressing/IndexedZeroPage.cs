using C64.Abstraction;

namespace C64.Addressing;

public class IndexedZeroPage : IAddressingMode
{
    public static IndexedZeroPage Instance { get; } = new();
    public AddressingMode Identifier => AddressingMode.IndexedZeroPage;

    public byte[]? GetOperands(
        Bus bus,
        Registers registers,
        out bool requiresAdditionalCycle)
    {
        throw new NotImplementedException();
    }
}