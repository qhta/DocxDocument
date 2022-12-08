using System.Xml;
using System;
using DocumentFormat.OpenXml;

namespace DocumentModel.VariantTypes;

/// <summary>
/// 2-Byte Signed Integer.
/// </summary>
public class VTShortImpl: VariantImpl, VTShort
{
  public new DocumentFormat.OpenXml.VariantTypes.VTShort? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.VariantTypes.VTShort?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }

  public VTShortImpl()
  {
    OpenXmlElement = new DocumentFormat.OpenXml.VariantTypes.VTShort();
  }

  public VTShortImpl(DocumentFormat.OpenXml.VariantTypes.VTShort element)
  {
    OpenXmlElement = element;
  }

  public override object? Value
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

  public override TypeCode GetTypeCode()
  {
    return TypeCode.Int16;
  }

  public override bool ToBoolean(IFormatProvider? provider)
  {
    return (Value is Int16 val) ? val != 0 : throw new InvalidOperationException("Variant is empty but Int16 expected");
  }

  public override byte ToByte(IFormatProvider? provider)
  {
    return (Value is Int16 val) ? Convert.ToByte(val) : throw new InvalidOperationException("Variant is empty but Int16 expected");
  }

  public override char ToChar(IFormatProvider? provider)
  {
    return (Value is Int16 val) ? Convert.ToChar(val) : throw new InvalidOperationException("Variant is empty but Int16 expected");
  }

  public override DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Int16 variant to DateTime");
  }

  public override decimal ToDecimal(IFormatProvider? provider)
  {
    return (Value is Int16 val) ? val : throw new InvalidOperationException("Variant is empty but Int16 expected");
  }

  public override double ToDouble(IFormatProvider? provider)
  {
    return (Value is Int16 val) ? val : throw new InvalidOperationException("Variant is empty but Int16 expected");
  }

  public override short ToInt16(IFormatProvider? provider)
  {
    return (Value is Int16 val) ? val : throw new InvalidOperationException("Variant is empty but Int16 expected");
  }

  public override int ToInt32(IFormatProvider? provider)
  {
    return (Value is Int16 val) ? val : throw new InvalidOperationException("Variant is empty but Int16 expected");
  }

  public override long ToInt64(IFormatProvider? provider)
  {
    return (Value is Int16 val) ? val : throw new InvalidOperationException("Variant is empty but Int16 expected");
  }

  public override sbyte ToSByte(IFormatProvider? provider)
  {
    return (Value is Int16 val) ? Convert.ToSByte(val) : throw new InvalidOperationException("Variant is empty but Int16 expected");
  }

  public override float ToSingle(IFormatProvider? provider)
  {
    return (Value is Int16 val) ? val : throw new InvalidOperationException("Variant is empty but Int16 expected");
  }

  public override string ToString(IFormatProvider? provider)
  {
    return (Value is Int16 val) ? val.ToString() : throw new InvalidOperationException("Variant is empty but Int16 expected");
  }

  public override ushort ToUInt16(IFormatProvider? provider)
  {
    return (Value is Int16 val) ? Convert.ToUInt16(val) : throw new InvalidOperationException("Variant is empty but Int16 expected");
  }

  public override uint ToUInt32(IFormatProvider? provider)
  {
    return (Value is Int16 val) ? Convert.ToUInt32(val) : throw new InvalidOperationException("Variant is empty but Int16 expected");
  }

  public override ulong ToUInt64(IFormatProvider? provider)
  {
    return (Value is Int16 val) ? Convert.ToUInt64(val) : throw new InvalidOperationException("Variant is empty but Int16 expected");
  }

}
