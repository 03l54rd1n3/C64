using C64.Abstraction;

namespace C64.Addressing;

public class Accumulator : IAddressingMode
{
    public static Accumulator Instance { get; } = new();
    public AddressingMode Identifier => AddressingMode.Accumulator;

    public byte[]? GetOperands(
        Bus bus,
        Registers registers,
        out bool requiresAdditionalCycle)
    {
        requiresAdditionalCycle = false;
        return null;
    }
}
