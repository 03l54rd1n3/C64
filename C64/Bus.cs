namespace C64;

public class Bus
{
    private readonly byte[] _ram = new byte[64 * 1024];

    public byte Read(
        ushort address)
    {
        return _ram[address];
    }

    public void Write(
        ushort address,
        byte data)
    {
        _ram[address] = data;
    }
}
