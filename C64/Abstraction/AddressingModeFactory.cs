using C64.Addressing;

namespace C64.Abstraction;

public class AddressingModeFactory
{
    public IAddressingMode Get(
        AddressingMode addressingMode)
    {
        return addressingMode switch
        {
            AddressingMode.Absolute => Absolute.Instance,
            AddressingMode.AbsoluteIndirect => AbsoluteIndirect.Instance,
            AddressingMode.Accumulator => Accumulator.Instance,
            AddressingMode.Immediate => Immediate.Instance,
            AddressingMode.Implied => Implied.Instance,
            AddressingMode.IndexAbsolute => IndexAbsolute.Instance,
            AddressingMode.IndexedIndirect => IndexedIndirect.Instance,
            AddressingMode.IndexedZeroPage => IndexedZeroPage.Instance,
            AddressingMode.IndirectIndexed => IndirectIndexed.Instance,
            AddressingMode.Relative => Relative.Instance,
            AddressingMode.ZeroPage => ZeroPage.Instance,
            _ => throw new ArgumentOutOfRangeException(nameof(addressingMode), addressingMode, null),
        };
    }
}
