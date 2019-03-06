namespace AsmResolver.Net.Signatures
{
    // ReSharper disable InconsistentNaming
    /// <summary>
    /// Provides all supported types used in native marshal descriptors.
    /// </summary>
    public enum NativeType : byte
    {
        Boolean = 0x02,
        I1 = 0x03,
        U1 = 0x04,
        I2 = 0x05,
        U2 = 0x06,
        I4 = 0x07,
        U4 = 0x08,
        I8 = 0x09,
        U8 = 0x0A,
        R4 = 0x0B,
        R8 = 0x0C,
        Currency = 0x0F,
        Bstr = 0x13,
        LpStr = 0x14,
        LpwStr = 0x15,
        LptStr = 0x16,
        FixedSysString = 0x17,
        IUnknown = 0x19,
        IDispatch = 0x1A,
        Struct = 0x1B,
        IntF = 0x1C,
        SafeArray = 0x1D,
        FixedArray = 0x1E,
        Int = 0x1F,
        UInt = 0x20,
        ByValStr = 0x22,
        AnsiBstr = 0x23,
        TbStr = 0x24,
        VariantBool = 0x25,
        Func = 0x26,
        AsAny = 0x28,
        Array = 0x2A,
        LpStruct = 0x2B,
        CustomMarshaler = 0x2C,
        Error = 0x2D,
        Max = 0x50,
    }
}