namespace C64;

public class Registers
{
    public byte A { get; internal set; }
    public byte X { get; internal set; }
    public byte Y { get; internal set; }
    public ushort ProgramCounter { get; internal set; }
    public byte StackPointer { get; internal set; }
    public Status Status { get; internal set; }
}
