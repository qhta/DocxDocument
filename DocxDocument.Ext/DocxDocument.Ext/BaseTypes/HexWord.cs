namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

public struct HexWord : IConvertible, IEquatable<HexWord>
{
  private readonly UInt16 Value;

  public HexWord(string val)
  {
    Value = UInt16.Parse(val, NumberStyles.HexNumber);
  }

  public HexWord(int value)
  {
    Value = (UInt16)value;
  }

  public HexWord(uint value)
  {
    Value = (UInt16)value;
  }

  public HexWord(ulong value)
  {
    Value = (UInt16)value;
  }

  public TypeCode GetTypeCode()
  {
    return Value.GetTypeCode();
  }

  public bool ToBoolean(IFormatProvider? provider)
  {
    return Value != 0;
  }

  public byte ToByte(IFormatProvider? provider)
  {
    return (byte)Value;
  }

  public char ToChar(IFormatProvider? provider)
  {
    return ((IConvertible)Value).ToChar(provider);
  }

  public DateTime ToDateTime(IFormatProvider? provider)
  {
    return ((IConvertible)Value).ToDateTime(provider);
  }

  public decimal ToDecimal(IFormatProvider? provider)
  {
    return Value;
  }

  public double ToDouble(IFormatProvider? provider)
  {
    return Value;
  }

  public short ToInt16(IFormatProvider? provider)
  {
    return (short)Value;
  }

  public int ToInt32(IFormatProvider? provider)
  {
    return Value;
  }

  public long ToInt64(IFormatProvider? provider)
  {
    return Value;
  }

  public sbyte ToSByte(IFormatProvider? provider)
  {
    return (sbyte)Value;
  }

  public float ToSingle(IFormatProvider? provider)
  {
    return Value;
  }

  public string ToString(IFormatProvider? provider)
  {
    return Value.ToString(provider);
  }

  public ushort ToUInt16(IFormatProvider? provider)
  {
    return (ushort)Value;
  }

  public uint ToUInt32(IFormatProvider? provider)
  {
    return (uint)Value;
  }

  public ulong ToUInt64(IFormatProvider? provider)
  {
    return (ulong)Value;
  }

  public object ToType(Type targetType, IFormatProvider? provider)
  {
    if (targetType == typeof(UInt16))
      return Value;
    if (targetType == typeof(Int32))
      return Value;
    if (targetType == typeof(UInt32))
      return Value;
    if (targetType == typeof(Int64))
      return Value;
    if (targetType == typeof(UInt64))
      return Value;
    if (targetType == typeof(Int16))
      return (short)Value;
    if (targetType == typeof(Byte))
      return (byte)Value;
    if (targetType == typeof(SByte))
      return (sbyte)Value;
    if (targetType == typeof(Single))
      return Value;
    if (targetType == typeof(Double))
      return Value;
    if (targetType == typeof(Decimal))
      return Value;
    if (targetType == typeof(String))
      return ToString();
    if (targetType == typeof(HexWord))
      return new HexWord(Value);
    return ((IConvertible)Value).ToType(targetType, provider);
  }

  public static implicit operator HexWord(string val)
  {
    return new HexWord(val);
  }


  public static implicit operator ushort(HexWord val)
  {
    return (ushort)val.Value;
  }

  public static implicit operator uint(HexWord val)
  {
    return (uint)val.Value;
  }

  public static implicit operator Int32(HexWord val)
  {
    return val.Value;
  }

  public static implicit operator ulong(HexWord val)
  {
    return (ulong)val.Value;
  }

  public static implicit operator HexWord(ushort val)
  {
    return new HexWord((ulong)val);
  }

  public static implicit operator HexWord(uint val)
  {
    return new HexWord((ulong)val);
  }

  public static implicit operator HexWord(Int32 val)
  {
    return new HexWord((ulong)val);
  }

  public static implicit operator HexWord(ulong val)
  {
    return new HexWord(val);
  }

  public static implicit operator HexBinary(HexWord value) => new HexBinary(value.ToString());
  public static implicit operator HexWord(HexBinary value) => new HexWord(value.ToString());

  /// <summary>
  /// Returns 4-digit hex string of the value.
  /// </summary>
  /// <returns></returns>
  public override string ToString()
  {
    return Value.ToString("X4");
  }

    public bool Equals(HexWord other)
  {
    return Value == other.Value;
  }

  public override int GetHashCode()
  {
    return Value;
  }
}