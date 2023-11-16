using C64.Abstraction;
using Microsoft.Extensions.Logging;

namespace C64;

public class Mos6510
{
    private readonly InstructionFactory _instructionFactory;
    private readonly AddressingModeFactory _addressingModeFactory;
    public Bus Bus { get; }
    public int CycleCount { get; private set; } = 0;

    public Registers Registers { get; } = new();

    public Mos6510(
        InstructionFactory instructionFactory,
        AddressingModeFactory addressingModeFactory,
        Bus bus)
    {
        _instructionFactory = instructionFactory;
        _addressingModeFactory = addressingModeFactory;
        Bus = bus;
    }

    public void Reset()
    {
        Registers.A = 0;
        Registers.X = 0;
        Registers.Y = 0;
        Registers.ProgramCounter = 0xFFFC;
        Registers.StackPointer = 0xFF;
        Registers.Status = 0;
    }

    public void Cycle()
    {
        if (CycleCount > 0)
        {
            CycleCount--;
            return;
        }

        var opcode = Bus.Read(Registers.ProgramCounter);
        Registers.ProgramCounter++;

        var instruction = _instructionFactory.Get(opcode);
        var addressingMode = _addressingModeFactory.Get(instruction.AddressingMode);
        var operands = addressingMode.GetOperands(Bus, Registers, out var addressModeRequiresAdditionalCycle);
        var instructionRequiresAdditionalCycle = instruction.Execute(Bus, Registers, operands);

        CycleCount = instruction.Cycles + (addressModeRequiresAdditionalCycle && instructionRequiresAdditionalCycle ? 1 : 0);
    }
}
