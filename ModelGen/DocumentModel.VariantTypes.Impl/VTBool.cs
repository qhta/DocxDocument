using System;
using System.Xml;

namespace DocumentModel.VariantTypes;

/// <summary>
/// Boolean.
/// </summary>
public class VTBoolImpl: VariantImpl, VTBool
{
  public new DocumentFormat.OpenXml.VariantTypes.VTBool? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.VariantTypes.VTBool?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }

  public VTBoolImpl()
  {
    OpenXmlElement = new DocumentFormat.OpenXml.VariantTypes.VTBool();
  }

  public VTBoolImpl(DocumentFormat.OpenXml.VariantTypes.VTBool element)
  {
    OpenXmlElement = element;
  }

  public override object? Value
  {
    get
    {
      if (OpenXmlElement != null)
        return (OpenXmlElement.InnerText != string.Empty) ? XmlConvert.ToBoolean(OpenXmlElement.InnerText) : null;
      else
        return _value;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value is Boolean val)
          OpenXmlElement.Text = XmlConvert.ToString(val);
        else if (value is null)
          OpenXmlElement.Text = string.Empty;
        else
          OpenXmlElement.Text = XmlConvert.ToString(Convert.ToBoolean(value));
      }
      if (value is null)
        _value = null;
      else
        _value = Convert.ToBoolean(value);
    }
  }
  private Boolean? _value;

  public override TypeCode GetTypeCode()
  {
    return TypeCode.Boolean;
  }

  public override bool ToBoolean(IFormatProvider? provider)
  {
    return (Value is Boolean val) ? val : throw new InvalidOperationException("Variant is empty but Boolean expected");
  }

  public override byte ToByte(IFormatProvider? provider)
  {
    return (Value is Boolean val) ? (val ? (Byte)1 : (Byte)0) : throw new InvalidOperationException("Variant is empty but Boolean expected");
  }

  public override char ToChar(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Boolean variant to Char");
  }

  public override DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Boolean variant to DateTime");
  }

  public override decimal ToDecimal(IFormatProvider? provider)
  {
    return (Value is Boolean val) ? (val ? (Decimal)1 : (Decimal)0) : throw new InvalidOperationException("Variant is empty but Boolean expected");
  }

  public override double ToDouble(IFormatProvider? provider)
  {
    return (Value is Boolean val) ? (val ? (Double)1 : (Double)0) : throw new InvalidOperationException("Variant is empty but Boolean expected");
  }

  public override short ToInt16(IFormatProvider? provider)
  {
    return (Value is Boolean val) ? (val ? (Int16)1 : (Int16)0) : throw new InvalidOperationException("Variant is empty but Boolean expected");
  }

  public override int ToInt32(IFormatProvider? provider)
  {
    return (Value is Boolean val) ? (val ? (Int32)1 : (Int32)0) : throw new InvalidOperationException("Variant is empty but Boolean expected");
  }

  public override long ToInt64(IFormatProvider? provider)
  {
    return (Value is Boolean val) ? (val ? (Int64)1 : (Int64)0) : throw new InvalidOperationException("Variant is empty but Boolean expected");
  }

  public override sbyte ToSByte(IFormatProvider? provider)
  {
    return (Value is Boolean val) ? (val ? (SByte)1 : (SByte)0) : throw new InvalidOperationException("Variant is empty but Boolean expected");
  }

  public override float ToSingle(IFormatProvider? provider)
  {
    return (Value is Boolean val) ? (val ? (Single)1 : (Single)0) : throw new InvalidOperationException("Variant is empty but Boolean expected");
  }

  public override string ToString(IFormatProvider? provider)
  {
    return (Value is Boolean val) ? (val ? "true" : "false") : throw new InvalidOperationException("Variant is empty but Boolean expected");
  }

  public override ushort ToUInt16(IFormatProvider? provider)
  {
    return (Value is Boolean val) ? (val ? (UInt16)1 : (UInt16)0) : throw new InvalidOperationException("Variant is empty but Boolean expected");
  }

  public override uint ToUInt32(IFormatProvider? provider)
  {
    return (Value is Boolean val) ? (val ? (UInt32)1 : (UInt32)0) : throw new InvalidOperationException("Variant is empty but Boolean expected");
  }

  public override ulong ToUInt64(IFormatProvider? provider)
  {
    return (Value is Boolean val) ? (val ? (UInt64)1 : (UInt64)0) : throw new InvalidOperationException("Variant is empty but Boolean expected");
  }
}
