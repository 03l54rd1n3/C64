namespace C64.Abstraction;

public interface IAddressingMode
{
    static IAddressingMode Instance { get; }

    AddressingMode Identifier { get; }

    byte[]? GetOperands(
        Bus bus,
        Registers registers,
        out bool requiresAdditionalCycle);
}
