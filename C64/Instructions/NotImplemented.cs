using C64.Abstraction;
using C64.Addressing;

namespace C64.Instructions;

public class NotImplemented : IInstruction
{
    public static IInstruction Instance { get; } = new NotImplemented();

    public string Name => "NotImplemented";
    public byte Opcode => 0xFF;
    public byte Length => 1;
    public byte Cycles => 0;
    public AddressingMode AddressingMode => AddressingMode.Implied;

    public bool Execute(
        Bus bus,
        Registers registers,
        byte[]? operands)
    {
        return false;
    }
}
