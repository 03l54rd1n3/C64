using C64.Abstraction;

namespace C64.Addressing;

public class Implied : IAddressingMode
{
    public static Implied Instance { get; } = new();
    public AddressingMode Identifier => AddressingMode.Implied;

    public byte[]? GetOperands(
        Bus bus,
        Registers registers,
        out bool requiresAdditionalCycle)
    {
        requiresAdditionalCycle = false;
        return null;
    }
}
