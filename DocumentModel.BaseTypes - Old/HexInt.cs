namespace DocumentModel;

/// <summary>
/// This class represents a type of integer that is stored in an Office document as StringValue in a hexadecimal format.
/// It implements desirable conversion to/from other types. When converting to string, it is returned in 8-digit hexadecimal form.
/// </summary>
public struct HexInt : IConvertible, IEquatable<HexInt>
{
  public HexInt()
  {
    Value = 0;
  }
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

  public string Val
  {
    get => ToString();
    set => Value = int.Parse(value, NumberStyles.HexNumber);
  }

  private int Value { get; set; }

  public HexInt(string val)
  {
    Value = int.Parse(val, NumberStyles.HexNumber);
  }

  public HexInt(int value)
  {
    Value = value;
  }

  public HexInt(uint value)
  {
    Value = (int)value;
  }

  public HexInt(ulong value)
  {
    Value = (int)value;
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
    if (targetType == typeof(HexInt))
      return new HexInt(Value);
    return ((IConvertible)Value).ToType(targetType, provider);
  }

  public static implicit operator HexInt(string val)
  {
    return new HexInt(val);
  }


  public static implicit operator ushort(HexInt val)
  {
    return (ushort)val.Value;
  }

  public static implicit operator uint(HexInt val)
  {
    return (uint)val.Value;
  }

  public static implicit operator Int32(HexInt val)
  {
    return val.Value;
  }

  public static implicit operator ulong(HexInt val)
  {
    return (ulong)val.Value;
  }

  public static implicit operator HexInt(ushort val)
  {
    return new HexInt((ulong)val);
  }

  public static implicit operator HexInt(uint val)
  {
    return new HexInt((ulong)val);
  }

  public static implicit operator HexInt(Int32 val)
  {
    return new HexInt((ulong)val);
  }

  public static implicit operator HexInt(ulong val)
  {
    return new HexInt(val);
  }

  public static implicit operator HexBinary(HexInt value) => new HexBinary(value.ToString());
  public static implicit operator HexInt(HexBinary value) => new HexInt(value.ToString());

  /// <summary>
  /// Returns 8-digit hex string of the value.
  /// </summary>
  /// <returns></returns>
  public override string ToString()
  {
    return Value.ToString("X8");
  }

  public bool Equals(HexInt other)
  {
    return Value == other.Value;
  }

  public override int GetHashCode()
  {
    return Value;
  }


}