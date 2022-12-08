using System.Xml;
using System;
using DocumentFormat.OpenXml;

namespace DocumentModel.VariantTypes;

/// <summary>
/// String.
/// </summary>
public class VTStringImpl: VariantImpl, VTString
{
  public new DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }

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

  public override object? Value
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

  public override TypeCode GetTypeCode()
  {
    return TypeCode.String;
  }

  public override bool ToBoolean(IFormatProvider? provider)
  {
    return (Value is String val) ? XmlConvert.ToBoolean(val) : throw new InvalidOperationException("Variant is empty but String expected");
  }

  public override byte ToByte(IFormatProvider? provider)
  {
    return (Value is String val) ? XmlConvert.ToByte(val) : throw new InvalidOperationException("Variant is empty but String expected");
  }

  public override char ToChar(IFormatProvider? provider)
  {
    return (Value is String val) ? XmlConvert.ToChar(val) : throw new InvalidOperationException("Variant is empty but String expected");
  }

  public override DateTime ToDateTime(IFormatProvider? provider)
  {
    return (Value is String val) ? XmlConvert.ToDateTime(val, XmlDateTimeSerializationMode.Unspecified) : throw new InvalidOperationException("Variant is empty but String expected");
  }

  public override decimal ToDecimal(IFormatProvider? provider)
  {
    return (Value is String val) ? XmlConvert.ToDecimal(val) : throw new InvalidOperationException("Variant is empty but String expected");
  }

  public override double ToDouble(IFormatProvider? provider)
  {
    return (Value is String val) ? XmlConvert.ToDouble(val) : throw new InvalidOperationException("Variant is empty but String expected");
  }

  public override short ToInt16(IFormatProvider? provider)
  {
    return (Value is String val) ? XmlConvert.ToInt16(val) : throw new InvalidOperationException("Variant is empty but String expected");
  }

  public override int ToInt32(IFormatProvider? provider)
  {
    return (Value is String val) ? XmlConvert.ToInt32(val) : throw new InvalidOperationException("Variant is empty but String expected");
  }

  public override long ToInt64(IFormatProvider? provider)
  {
    return (Value is String val) ? XmlConvert.ToInt64(val) : throw new InvalidOperationException("Variant is empty but String expected");
  }

  public override sbyte ToSByte(IFormatProvider? provider)
  {
    return (Value is String val) ? XmlConvert.ToSByte(val) : throw new InvalidOperationException("Variant is empty but String expected");
  }

  public override float ToSingle(IFormatProvider? provider)
  {
    return (Value is String val) ? XmlConvert.ToSingle(val) : throw new InvalidOperationException("Variant is empty but String expected");
  }

  public override string ToString(IFormatProvider? provider)
  {
    return (Value is String val) ? val : throw new InvalidOperationException("Variant is empty but String expected");
  }

  public override ushort ToUInt16(IFormatProvider? provider)
  {
    return (Value is String val) ? XmlConvert.ToUInt16(val) : throw new InvalidOperationException("Variant is empty but String expected");
  }

  public override uint ToUInt32(IFormatProvider? provider)
  {
    return (Value is String val) ? XmlConvert.ToUInt32(val) : throw new InvalidOperationException("Variant is empty but String expected");
  }

  public override ulong ToUInt64(IFormatProvider? provider)
  {
    return (Value is String val) ? XmlConvert.ToUInt64(val) : throw new InvalidOperationException("Variant is empty but String expected");
  }

}
