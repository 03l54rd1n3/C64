using System.Reflection;
using C64.Instructions;
using Microsoft.Extensions.Logging;

namespace C64.Abstraction;

public class InstructionFactory
{
    private readonly ILogger<InstructionFactory> _logger;
    private readonly Dictionary<byte, IInstruction> _instructions = new();

    public InstructionFactory(
        ILogger<InstructionFactory> logger)
    {
        _logger = logger;

        var types = Assembly.GetExecutingAssembly().GetTypes()
            .Where(t => t.IsClass && !t.IsAbstract && typeof(IInstruction).IsAssignableFrom(t));

        foreach (var type in types)
        {
            var instruction = (IInstruction)Activator.CreateInstance(type)!;
            _instructions.Add(instruction.Opcode, instruction);
        }
    }

    public IInstruction Get(
        byte opcode)
    {
        var isValid = _instructions.TryGetValue(opcode, out var instruction);
        if (isValid)
        {
            return instruction!;
        }

        _logger.LogWarning($"Opcode not supported: {opcode:X2}");
        return new NotImplemented();
    }
}
