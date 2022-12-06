using System;

namespace DocumentModel.VariantTypes;

/// <summary>
/// Empty.
/// </summary>
public class VTEmptyImpl: ModelElement<DocumentFormat.OpenXml.VariantTypes.VTEmpty>, VTEmpty
{
  public VTEmptyImpl()
  {
    OpenXmlElement = new DocumentFormat.OpenXml.VariantTypes.VTEmpty();
  }

  public VTEmptyImpl(DocumentFormat.OpenXml.VariantTypes.VTEmpty element)
  {
    OpenXmlElement = element;
  }

  public object? Value
  {
    get => null;
    set { }
  }

  public TypeCode GetTypeCode()
  {
    return TypeCode.Empty;
  }

  public object ToType(Type conversionType, IFormatProvider? provider)
  {
    if (conversionType == typeof(Boolean)) return ToBoolean(provider);
    else if (conversionType == typeof(Byte)) return ToByte(provider);
    else if (conversionType == typeof(Char)) return ToChar(provider);
    else if (conversionType == typeof(DateTime)) return ToDateTime(provider);
    else if (conversionType == typeof(Decimal)) return ToDecimal(provider);
    else if (conversionType == typeof(Double)) return ToDouble(provider);
    else if (conversionType == typeof(Int16)) return ToInt16(provider);
    else if (conversionType == typeof(Int32)) return ToInt32(provider);
    else if (conversionType == typeof(Int64)) return ToInt64(provider);
    else if (conversionType == typeof(SByte)) return ToSByte(provider);
    else if (conversionType == typeof(Single)) return ToSingle(provider);
    else if (conversionType == typeof(String)) return ToString(provider);
    else if (conversionType == typeof(UInt16)) return ToUInt16(provider);
    else if (conversionType == typeof(UInt32)) return ToUInt32(provider);
    else if (conversionType == typeof(UInt64)) return ToUInt64(provider);
    throw new InvalidOperationException($"Can't convert Empty Variant to {conversionType} type");
  }

  public bool ToBoolean(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Empty variant to Boolean");
  }

  public byte ToByte(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Empty variant to Byte");
  }

  public char ToChar(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Empty variant to Char");
  }

  public DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Empty variant to DateTime");
  }

  public decimal ToDecimal(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Empty variant to Decimal");
  }

  public double ToDouble(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Empty variant to Double");
  }

  public short ToInt16(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Empty variant to Int16");
  }

  public int ToInt32(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Empty variant to Int32");
  }

  public long ToInt64(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Empty variant to Int64");
  }

  public sbyte ToSByte(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Empty variant to SByte");
  }

  public float ToSingle(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Empty variant to Single");
  }

  public string ToString(IFormatProvider? provider)
  {
    return "<null>";
  }

  public ushort ToUInt16(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Empty variant to UInt16");
  }

  public uint ToUInt32(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Empty variant to UInt32");
  }

  public ulong ToUInt64(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Empty variant to UInt64");
  }
}
