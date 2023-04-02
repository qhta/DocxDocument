using System.ComponentModel;
using DocumentModel;

namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

[TypeConverter(typeof(HexCharTypeXmlConverter))]
public struct HexChar : IConvertible, IEquatable<HexChar>
{
  private readonly ushort Value;

  public HexChar(string val)
  {
    Value = ushort.Parse(val, NumberStyles.HexNumber);
  }

  public HexChar(Byte value)
  {
    Value = value;
  }

  public HexChar(char value)
  {
    Value = value;
  }

  public HexChar(ushort value)
  {
    Value = value;
  }

  public HexChar(int value)
  {
    Value = (ushort)value;
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
    if (targetType == typeof(HexChar))
      return new HexChar(Value);
    return ((IConvertible)Value).ToType(targetType, provider);
  }

  public static implicit operator HexChar(string val)
  {
    return new HexChar(val);
  }

  public static implicit operator string?(HexChar? val)
  {
    return val?.ToString();
  }

  public static implicit operator ushort(HexChar val)
  {
    return (ushort)val.Value;
  }

  public static implicit operator uint(HexChar val)
  {
    return (uint)val.Value;
  }

  public static implicit operator uint?(HexChar? val)
  {
    return (val is not null) ? (uint)val.Value : null;
  }

  public static implicit operator ulong(HexChar val)
  {
    return (ulong)val.Value;
  }

  public static implicit operator HexChar(ushort val)
  {
    return new HexChar((ushort)val);
  }

  public static implicit operator HexChar(uint val)
  {
    if (val>ushort.MaxValue)
      throw new InvalidCastException($"Type {val} out of range to cast to HexChar");
    return new HexChar((ushort)val);
  }

  public static implicit operator HexChar(ulong val)
  {
    if (val>ushort.MaxValue)
      throw new InvalidCastException($"Type {val} out of range to cast to HexChar");
    return new HexChar((ushort)val);
  }

  public override string ToString()
  {
    if (Value > 255)
      return Value.ToString("X4");
    return Value.ToString("X2");
  }

  public bool Equals(HexChar other)
  {
    return Value == other.Value;
  }

  public override int GetHashCode()
  {
    return Value;
  }
}