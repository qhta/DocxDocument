using System.ComponentModel;
using DocumentModel.BaseTypes;

namespace DocumentModel;

[TypeConverter(typeof(HexWordTypeConverter))]
public record HexWord: IConvertible
{
  private ushort Value;

  public static implicit operator HexWord(string val) => new HexWord (ushort.Parse(val, NumberStyles.HexNumber));

  //public static implicit operator HexWord?(string? val) =>
  //  (val is not null) ? new HexWord (ushort.Parse(val, NumberStyles.HexNumber)) : (HexWord?)null;

  public static implicit operator string(HexWord val) => val.Value.ToString("X4");
  //public static implicit operator string?(HexWord? val) => val?.Value.ToString("X4");

  public static implicit operator ushort(HexWord val) => val.Value;

  public static implicit operator HexWord(ushort val) => new HexWord (val);

  public HexWord(string val)
  {
    Value = ushort.Parse(val, NumberStyles.HexNumber);
  }

  public HexWord(ushort value)
  {
    Value = value;
  }

  public override string ToString()
  {
    return Value.ToString("X4");
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
    return Value;
  }

  public uint ToUInt32(IFormatProvider? provider)
  {
    return Value;
  }

  public ulong ToUInt64(IFormatProvider? provider)
  {
    return Value;
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
    if (targetType == typeof(string))
      return Value.ToString("X4");
    if (targetType == typeof(HexWord))
      return new HexWord(Value);
    return ((IConvertible)Value).ToType(targetType, provider);
  }


}