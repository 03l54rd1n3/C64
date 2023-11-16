namespace C64;

[Flags]
public enum Status
{
    Carry = 0,
    Zero = 1,
    InterruptDisable = 2,
    Decimal = 4,
    Break = 8,
    Unused = 16,
    Overflow = 64,
    Negative = 128,
}
