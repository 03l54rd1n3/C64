﻿using C64.Abstraction;

namespace C64.Addressing;

public class IndirectIndexed : IAddressingMode
{
    public static IndirectIndexed Instance { get; } = new();
    public AddressingMode Identifier => AddressingMode.IndirectIndexed;

    public byte[]? GetOperands(
        Bus bus,
        Registers registers,
        out bool requiresAdditionalCycle)
    {
        throw new NotImplementedException();
    }
}