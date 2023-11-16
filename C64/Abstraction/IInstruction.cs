namespace C64.Abstraction;

public interface IInstruction
{
    static IInstruction Instance { get; }

    string Name { get; }

    byte Opcode { get; }

    byte Length { get; }

    byte Cycles { get; }

    AddressingMode AddressingMode { get; }

    bool Execute(
        Bus bus,
        Registers registers,
        byte[]? operands);
}
