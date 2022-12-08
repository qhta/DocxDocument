using System.Xml;
using System;
using DocumentFormat.OpenXml;

namespace DocumentModel.VariantTypes;

/// <summary>
/// 2-Byte Unsigned Integer.
/// </summary>
public class VTUnsignedShortImpl: VariantImpl, VTUnsignedShort
{
  public new DocumentFormat.OpenXml.VariantTypes.VTUnsignedShort? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.VariantTypes.VTUnsignedShort?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }

  public VTUnsignedShortImpl()
  {
    OpenXmlElement = new DocumentFormat.OpenXml.VariantTypes.VTUnsignedShort();
  }

  public VTUnsignedShortImpl(DocumentFormat.OpenXml.VariantTypes.VTUnsignedShort element)
  {
    OpenXmlElement = element;
  }

  public override object? Value
  {
    get
    {
      if (OpenXmlElement != null)
        return (OpenXmlElement.InnerText != string.Empty) ? XmlConvert.ToUInt16(OpenXmlElement.InnerText) : null;
      else
        return _value;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value is UInt16 val)
          OpenXmlElement.Text = XmlConvert.ToString(val);
        else if (value is null)
          OpenXmlElement.Text = string.Empty;
        else
          OpenXmlElement.Text = XmlConvert.ToString(Convert.ToUInt16(value));
      }
      if (value is null)
        _value = null;
      else
        _value = Convert.ToUInt16(value);
    }
  }
  private UInt16? _value;

  public override TypeCode GetTypeCode()
  {
    return TypeCode.UInt16;
  }

  public override bool ToBoolean(IFormatProvider? provider)
  {
    return (Value is UInt16 val) ? val != 0 : throw new InvalidOperationException("Variant is empty but UInt16 expected");
  }

  public override byte ToByte(IFormatProvider? provider)
  {
    return (Value is UInt16 val) ? Convert.ToByte(val) : throw new InvalidOperationException("Variant is empty but UInt16 expected");
  }

  public override char ToChar(IFormatProvider? provider)
  {
    return (Value is UInt16 val) ? Convert.ToChar(val) : throw new InvalidOperationException("Variant is empty but UInt16 expected");
  }

  public override DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert UInt16 variant to DateTime");
  }

  public override decimal ToDecimal(IFormatProvider? provider)
  {
    return (Value is UInt16 val) ? val : throw new InvalidOperationException("Variant is empty but UInt16 expected");
  }

  public override double ToDouble(IFormatProvider? provider)
  {
    return (Value is UInt16 val) ? val : throw new InvalidOperationException("Variant is empty but UInt16 expected");
  }

  public override short ToInt16(IFormatProvider? provider)
  {
    return (Value is UInt16 val) ? Convert.ToInt16(val) : throw new InvalidOperationException("Variant is empty but UInt16 expected");
  }

  public override int ToInt32(IFormatProvider? provider)
  {
    return (Value is UInt16 val) ? val : throw new InvalidOperationException("Variant is empty but UInt16 expected");
  }

  public override long ToInt64(IFormatProvider? provider)
  {
    return (Value is UInt16 val) ? val : throw new InvalidOperationException("Variant is empty but UInt16 expected");
  }

  public override sbyte ToSByte(IFormatProvider? provider)
  {
    return (Value is UInt16 val) ? Convert.ToSByte(val) : throw new InvalidOperationException("Variant is empty but UInt16 expected");
  }

  public override float ToSingle(IFormatProvider? provider)
  {
    return (Value is UInt16 val) ? val : throw new InvalidOperationException("Variant is empty but UInt16 expected");
  }

  public override string ToString(IFormatProvider? provider)
  {
    return (Value is UInt16 val) ? val.ToString() : throw new InvalidOperationException("Variant is empty but UInt16 expected");
  }

  public override ushort ToUInt16(IFormatProvider? provider)
  {
    return (Value is UInt16 val) ? val : throw new InvalidOperationException("Variant is empty but UInt16 expected");
  }

  public override uint ToUInt32(IFormatProvider? provider)
  {
    return (Value is UInt16 val) ? val : throw new InvalidOperationException("Variant is empty but UInt16 expected");
  }

  public override ulong ToUInt64(IFormatProvider? provider)
  {
    return (Value is UInt16 val) ? Convert.ToUInt64(val) : throw new InvalidOperationException("Variant is empty but UInt16 expected");
  }

}
