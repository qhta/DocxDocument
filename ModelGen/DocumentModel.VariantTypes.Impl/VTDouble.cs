using System.Xml;
using System;

namespace DocumentModel.VariantTypes;

/// <summary>
/// 8-Byte Real Number.
/// </summary>
public class VTDoubleImpl: ModelElement<DocumentFormat.OpenXml.VariantTypes.VTDouble>, VTDouble
{
  public VTDoubleImpl()
  {
    OpenXmlElement = new DocumentFormat.OpenXml.VariantTypes.VTDouble();
  }

  public VTDoubleImpl(DocumentFormat.OpenXml.VariantTypes.VTDouble element)
  {
    OpenXmlElement = element;
  }

  public object? Value
  {
    get
    {
      if (OpenXmlElement != null)
        return (OpenXmlElement.InnerText != string.Empty) ? XmlConvert.ToDecimal(OpenXmlElement.InnerText) : null;
      else
        return _value;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value is Double val)
          OpenXmlElement.Text = XmlConvert.ToString(val);
        else if (value is null)
          OpenXmlElement.Text = string.Empty;
        else
          OpenXmlElement.Text = XmlConvert.ToString(Convert.ToDouble(value));
      }
      if (value is null)
        _value = null;
      else
        _value = Convert.ToDouble(value);
    }
  }
  private Double? _value;

  public TypeCode GetTypeCode()
  {
    return TypeCode.Double;
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
    throw new InvalidOperationException($"Can't convert Double Variant to {conversionType} type");
  }

  public bool ToBoolean(IFormatProvider? provider)
  {
    return (Value is Double val) ? val != 0 : throw new InvalidOperationException("Variant is empty but Double expected");
  }

  public byte ToByte(IFormatProvider? provider)
  {
    return (Value is Double val) ? Convert.ToByte(val) : throw new InvalidOperationException("Variant is empty but Double expected");
  }

  public char ToChar(IFormatProvider? provider)
  {
    return (Value is Double val) ? Convert.ToChar(val) : throw new InvalidOperationException("Variant is empty but Double expected");
  }

  public DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Double variant to DateTime");
  }

  public decimal ToDecimal(IFormatProvider? provider)
  {
    return (Value is Double val) ? Convert.ToDecimal(val) : throw new InvalidOperationException("Variant is empty but Double expected");
  }

  public double ToDouble(IFormatProvider? provider)
  {
    return (Value is Double val) ? val : throw new InvalidOperationException("Variant is empty but Double expected");
  }

  public short ToInt16(IFormatProvider? provider)
  {
    return (Value is Double val) ? Convert.ToInt16(val) : throw new InvalidOperationException("Variant is empty but Double expected");
  }

  public int ToInt32(IFormatProvider? provider)
  {
    return (Value is Double val) ? Convert.ToInt32(val) : throw new InvalidOperationException("Variant is empty but Double expected");
  }

  public long ToInt64(IFormatProvider? provider)
  {
    return (Value is Double val) ? Convert.ToInt64(val) : throw new InvalidOperationException("Variant is empty but Double expected");
  }

  public sbyte ToSByte(IFormatProvider? provider)
  {
    return (Value is Double val) ? Convert.ToSByte(val) : throw new InvalidOperationException("Variant is empty but Double expected");
  }

  public float ToSingle(IFormatProvider? provider)
  {
    return (Value is Double val) ? Convert.ToSingle(val) : throw new InvalidOperationException("Variant is empty but Double expected");
  }

  public string ToString(IFormatProvider? provider)
  {
    return (Value is Double val) ? XmlConvert.ToString(val) : throw new InvalidOperationException("Variant is empty but Double expected");
  }

  public ushort ToUInt16(IFormatProvider? provider)
  {
    return (Value is Double val) ? Convert.ToUInt16(val) : throw new InvalidOperationException("Variant is empty but Double expected");
  }

  public uint ToUInt32(IFormatProvider? provider)
  {
    return (Value is Double val) ? Convert.ToUInt32(val) : throw new InvalidOperationException("Variant is empty but Double expected");
  }

  public ulong ToUInt64(IFormatProvider? provider)
  {
    return (Value is Double val) ? Convert.ToUInt64(val) : throw new InvalidOperationException("Variant is empty but Double expected");
  }

}
