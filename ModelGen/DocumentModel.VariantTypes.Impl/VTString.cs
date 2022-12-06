using System.Xml;
using System;

namespace DocumentModel.VariantTypes;

/// <summary>
/// String.
/// </summary>
public class VTStringImpl: ModelElement<DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement>, VTString
{
  public VTStringImpl()
  {
    OpenXmlElement = new DocumentFormat.OpenXml.VariantTypes.VTBString();
  }

  public VTStringImpl(DocumentFormat.OpenXml.VariantTypes.VTLPSTR element)
  {
    OpenXmlElement = element;
  }

  public VTStringImpl(DocumentFormat.OpenXml.VariantTypes.VTLPWSTR element)
  {
    OpenXmlElement = element;
  }

  public VTStringImpl(DocumentFormat.OpenXml.VariantTypes.VTBString element)
  {
    OpenXmlElement = element;
  }

  public object? Value
  {
    get
    {
      if (OpenXmlElement != null)
        return OpenXmlElement.InnerText;
      else
        return _value;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value is string val)
          OpenXmlElement.Text = val;
        else if (value is null)
          OpenXmlElement.Text = string.Empty;
        else if (Value is IConvertible conv)
          OpenXmlElement.Text = conv.ToString(System.Globalization.CultureInfo.InvariantCulture);
      }
      if (value is null)
        _value = null;
      else
        _value = Convert.ToString(value);
    }
  }
  private string? _value;

  public TypeCode GetTypeCode()
  {
    return TypeCode.String;
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
    throw new InvalidOperationException($"Can't convert Byte Variant to {conversionType} type");
  }

  public bool ToBoolean(IFormatProvider? provider)
  {
    return (Value is String val) ? XmlConvert.ToBoolean(val) : throw new InvalidOperationException("Variant is empty but String expected");
  }

  public byte ToByte(IFormatProvider? provider)
  {
    return (Value is String val) ? XmlConvert.ToByte(val) : throw new InvalidOperationException("Variant is empty but String expected");
  }

  public char ToChar(IFormatProvider? provider)
  {
    return (Value is String val) ? XmlConvert.ToChar(val) : throw new InvalidOperationException("Variant is empty but String expected");
  }

  public DateTime ToDateTime(IFormatProvider? provider)
  {
    return (Value is String val) ? XmlConvert.ToDateTime(val, XmlDateTimeSerializationMode.Unspecified) : throw new InvalidOperationException("Variant is empty but String expected");
  }

  public decimal ToDecimal(IFormatProvider? provider)
  {
    return (Value is String val) ? XmlConvert.ToDecimal(val) : throw new InvalidOperationException("Variant is empty but String expected");
  }

  public double ToDouble(IFormatProvider? provider)
  {
    return (Value is String val) ? XmlConvert.ToDouble(val) : throw new InvalidOperationException("Variant is empty but String expected");
  }

  public short ToInt16(IFormatProvider? provider)
  {
    return (Value is String val) ? XmlConvert.ToInt16(val) : throw new InvalidOperationException("Variant is empty but String expected");
  }

  public int ToInt32(IFormatProvider? provider)
  {
    return (Value is String val) ? XmlConvert.ToInt32(val) : throw new InvalidOperationException("Variant is empty but String expected");
  }

  public long ToInt64(IFormatProvider? provider)
  {
    return (Value is String val) ? XmlConvert.ToInt64(val) : throw new InvalidOperationException("Variant is empty but String expected");
  }

  public sbyte ToSByte(IFormatProvider? provider)
  {
    return (Value is String val) ? XmlConvert.ToSByte(val) : throw new InvalidOperationException("Variant is empty but String expected");
  }

  public float ToSingle(IFormatProvider? provider)
  {
    return (Value is String val) ? XmlConvert.ToSingle(val) : throw new InvalidOperationException("Variant is empty but String expected");
  }

  public string ToString(IFormatProvider? provider)
  {
    return (Value is String val) ? val : throw new InvalidOperationException("Variant is empty but String expected");
  }

  public ushort ToUInt16(IFormatProvider? provider)
  {
    return (Value is String val) ? XmlConvert.ToUInt16(val) : throw new InvalidOperationException("Variant is empty but String expected");
  }

  public uint ToUInt32(IFormatProvider? provider)
  {
    return (Value is String val) ? XmlConvert.ToUInt32(val) : throw new InvalidOperationException("Variant is empty but String expected");
  }

  public ulong ToUInt64(IFormatProvider? provider)
  {
    return (Value is String val) ? XmlConvert.ToUInt64(val) : throw new InvalidOperationException("Variant is empty but String expected");
  }

}
