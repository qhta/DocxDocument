using System.ComponentModel;
using DocumentModel.BaseTypes;

namespace DocumentModel;

[TypeConverter(typeof(NumIdTypeConverter))]
public record NumId : IConvertible
{
  private readonly int Value;

  public NumId(string val)
  {
    Value = int.Parse(val, NumberStyles.HexNumber);
  }

  public NumId(int value)
  {
    Value = value;
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
    if (targetType == typeof(NumId))
      return new NumId(Value);
    return ((IConvertible)Value).ToType(targetType, provider);
  }

  public static implicit operator NumId(string val)
  {
    return new NumId(val);
  }

  public static implicit operator string?(NumId? val)
  {
    return val?.ToString();
  }

  public static implicit operator ushort(NumId val)
  {
    return (ushort)val.Value;
  }

  public static implicit operator uint(NumId val)
  {
    return (uint)val.Value;
  }

  public static implicit operator ulong(NumId val)
  {
    return (ulong)val.Value;
  }

  public static implicit operator NumId(ushort val)
  {
    return new NumId((ulong)val);
  }

  public static implicit operator NumId(uint val)
  {
    return new NumId((ulong)val);
  }

  public static implicit operator NumId(ulong val)
  {
    return new NumId(val);
  }

  public override string ToString()
  {
    //if (Value > uint.MaxValue)
    //  return Value.ToString("X16");
    return Value.ToString("X8");
  }
}