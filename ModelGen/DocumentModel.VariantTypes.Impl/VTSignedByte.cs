using System.Xml;
using System;
using DocumentFormat.OpenXml;

namespace DocumentModel.VariantTypes;

/// <summary>
/// 1-SByte Unsigned Integer.
/// </summary>
public class VTSignedByteImpl: VariantImpl, VTSignedByte
{
  public new DocumentFormat.OpenXml.VariantTypes.VTByte? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.VariantTypes.VTByte?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }

  public VTSignedByteImpl()
  {
    OpenXmlElement = new DocumentFormat.OpenXml.VariantTypes.VTByte();
  }

  public VTSignedByteImpl(DocumentFormat.OpenXml.VariantTypes.VTByte element)
  {
    OpenXmlElement = element;
  }

  public override object? Value
  {
    get
    {
      if (OpenXmlElement != null)
        return (OpenXmlElement.InnerText != string.Empty) ? XmlConvert.ToSByte(OpenXmlElement.InnerText) : null;
      else
        return _value;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value is SByte val)
          OpenXmlElement.Text = XmlConvert.ToString(val);
        else if (value is null)
          OpenXmlElement.Text = string.Empty;
        else
          OpenXmlElement.Text = XmlConvert.ToString(Convert.ToSByte(value));
      }
      if (value is null)
        _value = null;
      else
        _value = Convert.ToSByte(value);
    }
  }
  private SByte? _value;

  public override TypeCode GetTypeCode()
  {
    return TypeCode.SByte;
  }

  public override bool ToBoolean(IFormatProvider? provider)
  {
    return (Value is SByte val) ? val != 0 : throw new InvalidOperationException("Variant is empty but SByte expected");
  }

  public override byte ToByte(IFormatProvider? provider)
  {
    return (Value is SByte val) ? Convert.ToByte(val) : throw new InvalidOperationException("Variant is empty but SByte expected");
  }

  public override char ToChar(IFormatProvider? provider)
  {
    return (Value is SByte val) ? Convert.ToChar(val) : throw new InvalidOperationException("Variant is empty but SByte expected");
  }

  public override DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert SByte variant to DateTime");
  }

  public override decimal ToDecimal(IFormatProvider? provider)
  {
    return (Value is SByte val) ? val : throw new InvalidOperationException("Variant is empty but SByte expected");
  }

  public override double ToDouble(IFormatProvider? provider)
  {
    return (Value is SByte val) ? val : throw new InvalidOperationException("Variant is empty but SByte expected");
  }

  public override short ToInt16(IFormatProvider? provider)
  {
    return (Value is SByte val) ? val : throw new InvalidOperationException("Variant is empty but SByte expected");
  }

  public override int ToInt32(IFormatProvider? provider)
  {
    return (Value is SByte val) ? val : throw new InvalidOperationException("Variant is empty but SByte expected");
  }

  public override long ToInt64(IFormatProvider? provider)
  {
    return (Value is SByte val) ? val : throw new InvalidOperationException("Variant is empty but SByte expected");
  }

  public override sbyte ToSByte(IFormatProvider? provider)
  {
    return (Value is SByte val) ? val : throw new InvalidOperationException("Variant is empty but SByte expected");
  }

  public override float ToSingle(IFormatProvider? provider)
  {
    return (Value is SByte val) ? val : throw new InvalidOperationException("Variant is empty but SByte expected");
  }

  public override string ToString(IFormatProvider? provider)
  {
    return (Value is SByte val) ? val.ToString() : throw new InvalidOperationException("Variant is empty but SByte expected");
  }

  public override ushort ToUInt16(IFormatProvider? provider)
  {
    return (Value is SByte val) ? Convert.ToUInt16(val) : throw new InvalidOperationException("Variant is empty but SByte expected");
  }

  public override uint ToUInt32(IFormatProvider? provider)
  {
    return (Value is SByte val) ? Convert.ToUInt32(val) : throw new InvalidOperationException("Variant is empty but SByte expected");
  }

  public override ulong ToUInt64(IFormatProvider? provider)
  {
    return (Value is SByte val) ? Convert.ToUInt64(val) : throw new InvalidOperationException("Variant is empty but SByte expected");
  }


}
