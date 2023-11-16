using C64.Abstraction;

namespace C64.Addressing;

public class IndexedIndirect : IAddressingMode
{
    public static IndexedIndirect Instance { get; } = new();
    public AddressingMode Identifier => AddressingMode.IndexedIndirect;

    public byte[]? GetOperands(
        Bus bus,
        Registers registers,
        out bool requiresAdditionalCycle)
    {
        throw new NotImplementedException();
    }
}