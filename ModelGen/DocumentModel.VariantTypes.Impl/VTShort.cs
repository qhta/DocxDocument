using System.Xml;
using System;

namespace DocumentModel.VariantTypes;

/// <summary>
/// 2-Byte Signed Integer.
/// </summary>
public class VTShortImpl: ModelElement<DocumentFormat.OpenXml.VariantTypes.VTShort>, VTShort
{
  public VTShortImpl()
  {
    OpenXmlElement = new DocumentFormat.OpenXml.VariantTypes.VTShort();
  }

  public VTShortImpl(DocumentFormat.OpenXml.VariantTypes.VTShort element)
  {
    OpenXmlElement = element;
  }

  public object? Value
  {
    get
    {
      if (OpenXmlElement != null)
        return (OpenXmlElement.InnerText != string.Empty) ? XmlConvert.ToInt16(OpenXmlElement.InnerText) : null;
      else
        return _value;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value is Int16 val)
          OpenXmlElement.Text = XmlConvert.ToString(val);
        else if (value is null)
          OpenXmlElement.Text = string.Empty;
        else
          OpenXmlElement.Text = XmlConvert.ToString(Convert.ToInt16(value));
      }
      if (value is null)
        _value = null;
      else
        _value = Convert.ToInt16(value);
    }
  }
  private Int16? _value;

  public TypeCode GetTypeCode()
  {
    return TypeCode.Int16;
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
    throw new InvalidOperationException($"Can't convert Int16 Variant to {conversionType} type");
  }

  public bool ToBoolean(IFormatProvider? provider)
  {
    return (Value is Int16 val) ? val != 0 : throw new InvalidOperationException("Variant is empty but Int16 expected");
  }

  public byte ToByte(IFormatProvider? provider)
  {
    return (Value is Int16 val) ? Convert.ToByte(val) : throw new InvalidOperationException("Variant is empty but Int16 expected");
  }

  public char ToChar(IFormatProvider? provider)
  {
    return (Value is Int16 val) ? Convert.ToChar(val) : throw new InvalidOperationException("Variant is empty but Int16 expected");
  }

  public DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Int16 variant to DateTime");
  }

  public decimal ToDecimal(IFormatProvider? provider)
  {
    return (Value is Int16 val) ? val : throw new InvalidOperationException("Variant is empty but Int16 expected");
  }

  public double ToDouble(IFormatProvider? provider)
  {
    return (Value is Int16 val) ? val : throw new InvalidOperationException("Variant is empty but Int16 expected");
  }

  public short ToInt16(IFormatProvider? provider)
  {
    return (Value is Int16 val) ? val : throw new InvalidOperationException("Variant is empty but Int16 expected");
  }

  public int ToInt32(IFormatProvider? provider)
  {
    return (Value is Int16 val) ? val : throw new InvalidOperationException("Variant is empty but Int16 expected");
  }

  public long ToInt64(IFormatProvider? provider)
  {
    return (Value is Int16 val) ? val : throw new InvalidOperationException("Variant is empty but Int16 expected");
  }

  public sbyte ToSByte(IFormatProvider? provider)
  {
    return (Value is Int16 val) ? Convert.ToSByte(val) : throw new InvalidOperationException("Variant is empty but Int16 expected");
  }

  public float ToSingle(IFormatProvider? provider)
  {
    return (Value is Int16 val) ? val : throw new InvalidOperationException("Variant is empty but Int16 expected");
  }

  public string ToString(IFormatProvider? provider)
  {
    return (Value is Int16 val) ? val.ToString() : throw new InvalidOperationException("Variant is empty but Int16 expected");
  }

  public ushort ToUInt16(IFormatProvider? provider)
  {
    return (Value is Int16 val) ? Convert.ToUInt16(val) : throw new InvalidOperationException("Variant is empty but Int16 expected");
  }

  public uint ToUInt32(IFormatProvider? provider)
  {
    return (Value is Int16 val) ? Convert.ToUInt32(val) : throw new InvalidOperationException("Variant is empty but Int16 expected");
  }

  public ulong ToUInt64(IFormatProvider? provider)
  {
    return (Value is Int16 val) ? Convert.ToUInt64(val) : throw new InvalidOperationException("Variant is empty but Int16 expected");
  }

}
