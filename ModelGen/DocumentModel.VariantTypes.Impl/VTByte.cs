using System;
using System.Xml;

using DocumentFormat.OpenXml;

namespace DocumentModel.VariantTypes;

/// <summary>
/// 1-Byte Signed Integer variant implementation. Value is of Byte type.
/// </summary>
public class VTByteImpl: VariantImpl, VTByte
{
  public new DocumentFormat.OpenXml.VariantTypes.VTUnsignedByte? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.VariantTypes.VTUnsignedByte?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }

  public VTByteImpl()
  {
    OpenXmlElement = new DocumentFormat.OpenXml.VariantTypes.VTUnsignedByte();
  }

  public VTByteImpl(DocumentFormat.OpenXml.VariantTypes.VTUnsignedByte element)
  {
    OpenXmlElement = element;
  }

  public override object? Value
  {
    get
    {
      if (OpenXmlElement != null)
        return (OpenXmlElement.InnerText != string.Empty) ? XmlConvert.ToByte(OpenXmlElement.InnerText) : null;
      else
        return _value;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value is Byte val)
          OpenXmlElement.Text = XmlConvert.ToString(val);
        else if (value is null)
          OpenXmlElement.Text = string.Empty;
        else
          OpenXmlElement.Text = XmlConvert.ToString(Convert.ToByte(value));
      }
      if (value is null)
        _value = null;
      else
        _value = Convert.ToByte(value);
    }
  }
  private Byte? _value;

  public override TypeCode GetTypeCode()
  {
    return TypeCode.Byte;
  }

  public override bool ToBoolean(IFormatProvider? provider)
  {
    return (Value is Byte val) ? val != 0 : throw new InvalidOperationException("Variant is empty but Byte expected");
  }

  public override byte ToByte(IFormatProvider? provider)
  {
    return (Value is Byte val) ? val : throw new InvalidOperationException("Variant is empty but Byte expected");
  }

  public override char ToChar(IFormatProvider? provider)
  {
    return (Value is Byte val) ? Convert.ToChar(val) : throw new InvalidOperationException("Variant is empty but Byte expected");
  }

  public override DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Byte variant to DateTime");
  }

  public override decimal ToDecimal(IFormatProvider? provider)
  {
    return (Value is Byte val) ? val : throw new InvalidOperationException("Variant is empty but Byte expected");
  }

  public override double ToDouble(IFormatProvider? provider)
  {
    return (Value is Byte val) ? val : throw new InvalidOperationException("Variant is empty but Byte expected");
  }

  public override short ToInt16(IFormatProvider? provider)
  {
    return (Value is Byte val) ? val : throw new InvalidOperationException("Variant is empty but Byte expected");
  }

  public override int ToInt32(IFormatProvider? provider)
  {
    return (Value is Byte val) ? val : throw new InvalidOperationException("Variant is empty but Byte expected");
  }

  public override long ToInt64(IFormatProvider? provider)
  {
    return (Value is Byte val) ? val : throw new InvalidOperationException("Variant is empty but Byte expected");
  }

  public override sbyte ToSByte(IFormatProvider? provider)
  {
    return (Value is Byte val) ? Convert.ToSByte(val) : throw new InvalidOperationException("Variant is empty but Byte expected");
  }

  public override float ToSingle(IFormatProvider? provider)
  {
    return (Value is Byte val) ? val : throw new InvalidOperationException("Variant is empty but Byte expected");
  }

  public override string ToString(IFormatProvider? provider)
  {
    return (Value is Byte val) ? val.ToString() : throw new InvalidOperationException("Variant is empty but Byte expected");
  }

  public override ushort ToUInt16(IFormatProvider? provider)
  {
    return (Value is Byte val) ? val : throw new InvalidOperationException("Variant is empty but Byte expected");
  }

  public override uint ToUInt32(IFormatProvider? provider)
  {
    return (Value is Byte val) ? val : throw new InvalidOperationException("Variant is empty but Byte expected");
  }

  public override ulong ToUInt64(IFormatProvider? provider)
  {
    return (Value is Byte val) ? val : throw new InvalidOperationException("Variant is empty but Byte expected");
  }

}
