using System.Xml;
using System;
using DocumentFormat.OpenXml;

namespace DocumentModel.VariantTypes;

/// <summary>
/// 4-Byte Real Number.
/// </summary>
public class VTFloatImpl: VariantImpl, VTFloat
{
  public new DocumentFormat.OpenXml.VariantTypes.VTFloat? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.VariantTypes.VTFloat?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }

  public VTFloatImpl()
  {
    OpenXmlElement = new DocumentFormat.OpenXml.VariantTypes.VTFloat();
  }

  public VTFloatImpl(DocumentFormat.OpenXml.VariantTypes.VTFloat element)
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
        if (value is Single val)
          OpenXmlElement.Text = XmlConvert.ToString(val);
        else if (value is null)
          OpenXmlElement.Text = string.Empty;
        else
          OpenXmlElement.Text = XmlConvert.ToString(Convert.ToSingle(value));
      }
      if (value is null)
        _value = null;
      else
        _value = Convert.ToSingle(value);
    }
  }
  private Single? _value;

  public override TypeCode GetTypeCode()
  {
    return TypeCode.Single;
  }

  public override bool ToBoolean(IFormatProvider? provider)
  {
    return (Value is Single val) ? val != 0 : throw new InvalidOperationException("Variant is empty but Single expected");
  }

  public override byte ToByte(IFormatProvider? provider)
  {
    return (Value is Single val) ? Convert.ToByte(val) : throw new InvalidOperationException("Variant is empty but Single expected");
  }

  public override char ToChar(IFormatProvider? provider)
  {
    return (Value is Single val) ? Convert.ToChar(val) : throw new InvalidOperationException("Variant is empty but Single expected");
  }

  public override DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Single variant to DateTime");
  }

  public override decimal ToDecimal(IFormatProvider? provider)
  {
    return (Value is Single val) ? Convert.ToDecimal(val) : throw new InvalidOperationException("Variant is empty but Single expected");
  }

  public override double ToDouble(IFormatProvider? provider)
  {
    return (Value is Single val) ? val : throw new InvalidOperationException("Variant is empty but Single expected");
  }

  public override short ToInt16(IFormatProvider? provider)
  {
    return (Value is Single val) ? Convert.ToInt16(val) : throw new InvalidOperationException("Variant is empty but Single expected");
  }

  public override int ToInt32(IFormatProvider? provider)
  {
    return (Value is Single val) ? Convert.ToInt32(val) : throw new InvalidOperationException("Variant is empty but Single expected");
  }

  public override long ToInt64(IFormatProvider? provider)
  {
    return (Value is Single val) ? Convert.ToInt64(val) : throw new InvalidOperationException("Variant is empty but Single expected");
  }

  public override sbyte ToSByte(IFormatProvider? provider)
  {
    return (Value is Single val) ? Convert.ToSByte(val) : throw new InvalidOperationException("Variant is empty but Single expected");
  }

  public override float ToSingle(IFormatProvider? provider)
  {
    return (Value is Single val) ? val : throw new InvalidOperationException("Variant is empty but Single expected");
  }

  public override string ToString(IFormatProvider? provider)
  {
    return (Value is Single val) ? XmlConvert.ToString(val) : throw new InvalidOperationException("Variant is empty but Single expected");
  }

  public override ushort ToUInt16(IFormatProvider? provider)
  {
    return (Value is Single val) ? Convert.ToUInt16(val) : throw new InvalidOperationException("Variant is empty but Single expected");
  }

  public override uint ToUInt32(IFormatProvider? provider)
  {
    return (Value is Single val) ? Convert.ToUInt32(val) : throw new InvalidOperationException("Variant is empty but Single expected");
  }

  public override ulong ToUInt64(IFormatProvider? provider)
  {
    return (Value is Single val) ? Convert.ToUInt64(val) : throw new InvalidOperationException("Variant is empty but Single expected");
  }

}
