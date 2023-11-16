using C64.Abstraction;

namespace C64.Addressing;

public class Immediate : IAddressingMode
{
    public static Immediate Instance { get; } = new();
    public AddressingMode Identifier => AddressingMode.Immediate;

    public byte[]? GetOperands(
        Bus bus,
        Registers registers,
        out bool requiresAdditionalCycle)
    {
        requiresAdditionalCycle = false;
        var operand = bus.Read(registers.ProgramCounter);
        registers.ProgramCounter++;
        return new [] { operand };
    }
}
