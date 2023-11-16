using C64.Abstraction;

namespace C64.Addressing;

public class AbsoluteIndirect : IAddressingMode
{
    public static AbsoluteIndirect Instance { get; } = new();
    public AddressingMode Identifier => AddressingMode.AbsoluteIndirect;

    public byte[]? GetOperands(
        Bus bus,
        Registers registers,
        out bool requiresAdditionalCycle)
    {
        throw new NotImplementedException();
    }
}