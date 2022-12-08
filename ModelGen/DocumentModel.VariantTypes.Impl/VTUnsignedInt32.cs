using System.Xml;
using System;
using DocumentFormat.OpenXml;

namespace DocumentModel.VariantTypes;

/// <summary>
/// 4-Byte Unsigned Integer.
/// </summary>
public class VTUnsignedInt32Impl: VariantImpl, VTUnsignedInt32
{
  public new DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }

  public VTUnsignedInt32Impl()
  {
    OpenXmlElement = new DocumentFormat.OpenXml.VariantTypes.VTUnsignedInt32();
  }

  public VTUnsignedInt32Impl(DocumentFormat.OpenXml.VariantTypes.VTUnsignedInt32 element)
  {
    OpenXmlElement = element;
  }

  public VTUnsignedInt32Impl(DocumentFormat.OpenXml.VariantTypes.VTUnsignedInteger element)
  {
    OpenXmlElement = element;
  }

  public override object? Value
  {
    get
    {
      if (OpenXmlElement != null)
        return (OpenXmlElement.InnerText != string.Empty) ? XmlConvert.ToUInt32(OpenXmlElement.InnerText) : null;
      else
        return _value;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value is UInt32 val)
          OpenXmlElement.Text = XmlConvert.ToString(val);
        else if (value is null)
          OpenXmlElement.Text = string.Empty;
        else
          OpenXmlElement.Text = XmlConvert.ToString(Convert.ToUInt32(value));
      }
      if (value is null)
        _value = null;
      else
        _value = Convert.ToUInt32(value);
    }
  }
  private UInt32? _value;

  public override TypeCode GetTypeCode()
  {
    return TypeCode.UInt32;
  }

  public override bool ToBoolean(IFormatProvider? provider)
  {
    return (Value is UInt32 val) ? val != 0 : throw new InvalidOperationException("Variant is empty but UInt32 expected");
  }

  public override byte ToByte(IFormatProvider? provider)
  {
    return (Value is UInt32 val) ? Convert.ToByte(val) : throw new InvalidOperationException("Variant is empty but UInt32 expected");
  }

  public override char ToChar(IFormatProvider? provider)
  {
    return (Value is UInt32 val) ? Convert.ToChar(val) : throw new InvalidOperationException("Variant is empty but UInt32 expected");
  }

  public override DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert UInt32 variant to DateTime");
  }

  public override decimal ToDecimal(IFormatProvider? provider)
  {
    return (Value is UInt32 val) ? val : throw new InvalidOperationException("Variant is empty but UInt32 expected");
  }

  public override double ToDouble(IFormatProvider? provider)
  {
    return (Value is UInt32 val) ? val : throw new InvalidOperationException("Variant is empty but UInt32 expected");
  }

  public override short ToInt16(IFormatProvider? provider)
  {
    return (Value is UInt32 val) ? Convert.ToInt16(val) : throw new InvalidOperationException("Variant is empty but UInt32 expected");
  }

  public override int ToInt32(IFormatProvider? provider)
  {
    return (Value is UInt32 val) ? Convert.ToInt32(val) : throw new InvalidOperationException("Variant is empty but UInt32 expected");
  }

  public override long ToInt64(IFormatProvider? provider)
  {
    return (Value is UInt32 val) ? val : throw new InvalidOperationException("Variant is empty but UInt32 expected");
  }

  public override sbyte ToSByte(IFormatProvider? provider)
  {
    return (Value is UInt32 val) ? Convert.ToSByte(val) : throw new InvalidOperationException("Variant is empty but UInt32 expected");
  }

  public override float ToSingle(IFormatProvider? provider)
  {
    return (Value is UInt32 val) ? val : throw new InvalidOperationException("Variant is empty but UInt32 expected");
  }

  public override string ToString(IFormatProvider? provider)
  {
    return (Value is UInt32 val) ? val.ToString() : throw new InvalidOperationException("Variant is empty but UInt32 expected");
  }

  public override ushort ToUInt16(IFormatProvider? provider)
  {
    return (Value is UInt32 val) ? Convert.ToUInt16(val) : throw new InvalidOperationException("Variant is empty but UInt32 expected");
  }

  public override uint ToUInt32(IFormatProvider? provider)
  {
    return (Value is UInt32 val) ? val : throw new InvalidOperationException("Variant is empty but UInt32 expected");
  }

  public override ulong ToUInt64(IFormatProvider? provider)
  {
    return (Value is UInt32 val) ? val : throw new InvalidOperationException("Variant is empty but UInt32 expected");
  }

}
