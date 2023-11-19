namespace DocumentModel;

/// <summary>
/// This class represents a type of integer that is stored in an Office document as StringValue in a hexadecimal format.
/// It implements desirable conversion to/from other types. When converting to string, it is returned in 8-digit hexadecimal form.
/// </summary>
public struct HexLong : IConvertible, IEquatable<HexLong>
{
  public HexLong()
  {
    Value = 0;
  }
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

  public string Val
  {
    get => ToString();
    set => Value = int.Parse(value, NumberStyles.HexNumber);
  }

  private long Value { get; set; }

  public HexLong(string val)
  {
    Value = long.Parse(val, NumberStyles.HexNumber);
  }

  public HexLong(int value)
  {
    Value = value;
  }

  public HexLong(uint value)
  {
    Value = (int)value;
  }

  public HexLong(long value)
  {
    Value = (long)value;
  }

  public HexLong(ulong value)
  {
    Value = (long)value;
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
    return (int)Value;
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
    if (targetType == typeof(HexLong))
      return new HexLong(Value);
    return Convert.ChangeType(Value, targetType, provider);
  }

  public static implicit operator HexLong(string val)
  {
    return new HexLong(val);
  }

  public static implicit operator UInt16(HexLong val)
  {
    return (UInt16)val.Value;
  }

  public static implicit operator UInt32(HexLong val)
  {
    return (UInt32)val.Value;
  }

  public static implicit operator Int32(HexLong val)
  {
    return (Int32)val.Value;
  }

  public static implicit operator UInt64(HexLong val)
  {
    return (UInt64)val.Value;
  }

  public static implicit operator HexLong(ushort val)
  {
    return new HexLong((ulong)val);
  }

  public static implicit operator HexLong(uint val)
  {
    return new HexLong((ulong)val);
  }

  public static implicit operator HexLong(Int32 val)
  {
    return new HexLong((ulong)val);
  }

  public static implicit operator HexLong(ulong val)
  {
    return new HexLong(val);
  }

  public static implicit operator HexBinary(HexLong value) => new HexBinary(value.ToString());
  public static implicit operator HexLong(HexBinary value) => new HexLong(value.ToString());

  /// <summary>
  /// Returns 8-digit hex string of the value.
  /// </summary>
  /// <returns></returns>
  public override string ToString()
  {
    return Value.ToString("X8");
  }

  public bool Equals(HexLong other)
  {
    return Value == other.Value;
  }

  public override int GetHashCode()
  {
    return Value.GetHashCode();
  }


}