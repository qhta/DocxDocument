using System.ComponentModel;
using DocumentModel.BaseTypes;

namespace DocumentModel;

[TypeConverter(typeof(HexWordTypeConverter))]
public struct HexWord: IConvertible
{
  private ushort value;


  public static implicit operator HexWord(string val) => new HexWord { value = ushort.Parse(val, NumberStyles.HexNumber) };

  public static implicit operator HexWord?(string? val) =>
    (val is not null) ? new HexWord { value = ushort.Parse(val, NumberStyles.HexNumber) } : (HexWord?)null;

  public static implicit operator string(HexWord val) => val.value.ToString("X4");
  public static implicit operator string?(HexWord? val) => val?.value.ToString("X4");

  public static implicit operator ushort(HexWord val) => val.value;

  public static implicit operator HexWord(ushort val) => new HexWord { value = val };

  public HexWord(string val)
  {
    value = ushort.Parse(val, NumberStyles.HexNumber);
  }

  public HexWord(ushort val)
  {
    value = val;
  }

  public override string ToString()
  {
    return value.ToString("X4");
  }

  public TypeCode GetTypeCode()
  {
    return value.GetTypeCode();
  }

  public bool ToBoolean(IFormatProvider? provider)
  {
    return value != 0;
  }

  public byte ToByte(IFormatProvider? provider)
  {
    return (byte)value;
  }

  public char ToChar(IFormatProvider? provider)
  {
    return ((IConvertible)value).ToChar(provider);
  }

  public DateTime ToDateTime(IFormatProvider? provider)
  {
    return ((IConvertible)value).ToDateTime(provider);
  }

  public decimal ToDecimal(IFormatProvider? provider)
  {
    return value;
  }

  public double ToDouble(IFormatProvider? provider)
  {
    return value;
  }

  public short ToInt16(IFormatProvider? provider)
  {
    return (short)value;
  }

  public int ToInt32(IFormatProvider? provider)
  {
    return value;
  }

  public long ToInt64(IFormatProvider? provider)
  {
    return value;
  }

  public sbyte ToSByte(IFormatProvider? provider)
  {
    return (sbyte)value;
  }

  public float ToSingle(IFormatProvider? provider)
  {
    return value;
  }

  public string ToString(IFormatProvider? provider)
  {
    return value.ToString(provider);
  }

  public ushort ToUInt16(IFormatProvider? provider)
  {
    return value;
  }

  public uint ToUInt32(IFormatProvider? provider)
  {
    return value;
  }

  public ulong ToUInt64(IFormatProvider? provider)
  {
    return value;
  }

  public object ToType(Type targetType, IFormatProvider? provider)
  {
    if (targetType == typeof(UInt16))
      return value;
    if (targetType == typeof(Int32))
      return value;
    if (targetType == typeof(UInt32))
      return value;
    if (targetType == typeof(Int64))
      return value;
    if (targetType == typeof(UInt64))
      return value;
    if (targetType == typeof(Int16))
      return (short)value;
    if (targetType == typeof(Byte))
      return (byte)value;
    if (targetType == typeof(SByte))
      return (sbyte)value;
    if (targetType == typeof(Single))
      return value;
    if (targetType == typeof(Double))
      return value;
    if (targetType == typeof(Decimal))
      return value;
    if (targetType == typeof(string))
      return value.ToString("X4");
    if (targetType == typeof(HexWord))
      return new HexWord(value);
    return ((IConvertible)value).ToType(targetType, provider);
  }


}