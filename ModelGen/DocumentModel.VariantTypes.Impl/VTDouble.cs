using System.Xml;
using System;
using DocumentFormat.OpenXml;

namespace DocumentModel.VariantTypes;

/// <summary>
/// 8-Byte Real Number.
/// </summary>
public class VTDoubleImpl: VariantImpl, VTDouble
{
  public new DocumentFormat.OpenXml.VariantTypes.VTDouble? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.VariantTypes.VTDouble?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }

  public VTDoubleImpl()
  {
    OpenXmlElement = new DocumentFormat.OpenXml.VariantTypes.VTDouble();
  }

  public VTDoubleImpl(DocumentFormat.OpenXml.VariantTypes.VTDouble element)
  {
    OpenXmlElement = element;
  }

  public override object? Value
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

  public override TypeCode GetTypeCode()
  {
    return TypeCode.Double;
  }

  public override bool ToBoolean(IFormatProvider? provider)
  {
    return (Value is Double val) ? val != 0 : throw new InvalidOperationException("Variant is empty but Double expected");
  }

  public override byte ToByte(IFormatProvider? provider)
  {
    return (Value is Double val) ? Convert.ToByte(val) : throw new InvalidOperationException("Variant is empty but Double expected");
  }

  public override char ToChar(IFormatProvider? provider)
  {
    return (Value is Double val) ? Convert.ToChar(val) : throw new InvalidOperationException("Variant is empty but Double expected");
  }

  public override DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Double variant to DateTime");
  }

  public override decimal ToDecimal(IFormatProvider? provider)
  {
    return (Value is Double val) ? Convert.ToDecimal(val) : throw new InvalidOperationException("Variant is empty but Double expected");
  }

  public override double ToDouble(IFormatProvider? provider)
  {
    return (Value is Double val) ? val : throw new InvalidOperationException("Variant is empty but Double expected");
  }

  public override short ToInt16(IFormatProvider? provider)
  {
    return (Value is Double val) ? Convert.ToInt16(val) : throw new InvalidOperationException("Variant is empty but Double expected");
  }

  public override int ToInt32(IFormatProvider? provider)
  {
    return (Value is Double val) ? Convert.ToInt32(val) : throw new InvalidOperationException("Variant is empty but Double expected");
  }

  public override long ToInt64(IFormatProvider? provider)
  {
    return (Value is Double val) ? Convert.ToInt64(val) : throw new InvalidOperationException("Variant is empty but Double expected");
  }

  public override sbyte ToSByte(IFormatProvider? provider)
  {
    return (Value is Double val) ? Convert.ToSByte(val) : throw new InvalidOperationException("Variant is empty but Double expected");
  }

  public override float ToSingle(IFormatProvider? provider)
  {
    return (Value is Double val) ? Convert.ToSingle(val) : throw new InvalidOperationException("Variant is empty but Double expected");
  }

  public override string ToString(IFormatProvider? provider)
  {
    return (Value is Double val) ? XmlConvert.ToString(val) : throw new InvalidOperationException("Variant is empty but Double expected");
  }

  public override ushort ToUInt16(IFormatProvider? provider)
  {
    return (Value is Double val) ? Convert.ToUInt16(val) : throw new InvalidOperationException("Variant is empty but Double expected");
  }

  public override uint ToUInt32(IFormatProvider? provider)
  {
    return (Value is Double val) ? Convert.ToUInt32(val) : throw new InvalidOperationException("Variant is empty but Double expected");
  }

  public override ulong ToUInt64(IFormatProvider? provider)
  {
    return (Value is Double val) ? Convert.ToUInt64(val) : throw new InvalidOperationException("Variant is empty but Double expected");
  }

}
