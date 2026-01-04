namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

public struct HexRgb : IConvertible, IEquatable<HexRgb>
{
  private readonly uint Value;

  public HexRgb(string val)
  {
    Value = ushort.Parse(val, NumberStyles.HexNumber);
  }

  public HexRgb(uint value)
  {
    Value = value;
  }

  public HexRgb(int value)
  {
    Value = (uint)value;
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
    return ((IConvertible)Value).ToByte(provider);
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
    return ((IConvertible)Value).ToInt32(provider);  
  }

  public long ToInt64(IFormatProvider? provider)
  {
    return ((IConvertible)Value).ToInt64(provider);  
  }

  public sbyte ToSByte(IFormatProvider? provider)
  {
    return ((IConvertible)Value).ToSByte(provider);  
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
    return ((IConvertible)Value).ToUInt16(provider);  
  }

  public uint ToUInt32(IFormatProvider? provider)
  {
    return ((IConvertible)Value).ToUInt32(provider);  
  }

  public ulong ToUInt64(IFormatProvider? provider)
  {
    return ((IConvertible)Value).ToUInt64(provider);  
  }

  public object ToType(Type targetType, IFormatProvider? provider)
  {
    if (targetType == typeof(UInt16))
      return Value;
    if (targetType == typeof(Int32))
      return Value;
    if (targetType == typeof(UInt32))
      return Value;
    if (targetType == typeof(UInt64))
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
    if (targetType == typeof(HexRgb))
      return new HexRgb(Value);
    return ((IConvertible)Value).ToType(targetType, provider);
  }

  public static implicit operator HexRgb(string val)
  {
    return new HexRgb(val);
  }

  public static implicit operator string?(HexRgb? val)
  {
    return val?.ToString();
  }

  public static implicit operator ushort(HexRgb val)
  {
    return (ushort)val.Value;
  }

  public static implicit operator uint(HexRgb val)
  {
    return (uint)val.Value;
  }

  public static implicit operator uint?(HexRgb? val)
  {
    return (val is not null) ? (uint)val.Value : null;
  }

  public static implicit operator ulong(HexRgb val)
  {
    return (ulong)val.Value;
  }

  public static implicit operator HexRgb(ushort val)
  {
    return new HexRgb((ushort)val);
  }

  public static implicit operator HexRgb(uint val)
  {
    if (val>ushort.MaxValue)
      throw new InvalidCastException($"Type {val} out of range to cast to HexChar");
    return new HexRgb((ushort)val);
  }

  public static implicit operator HexRgb(ulong val)
  {
    if (val>ushort.MaxValue)
      throw new InvalidCastException($"Type {val} out of range to cast to HexChar");
    return new HexRgb((ushort)val);
  }

  public override string ToString()
  {
    if (Value > 255)
      return Value.ToString("X4");
    return Value.ToString("X6");
  }

  public bool Equals(HexRgb other)
  {
    return Value == other.Value;
  }

  public override int GetHashCode()
  {
    return Value.GetHashCode();
  }
}