using System.Xml;
using System;
using DocumentFormat.OpenXml;

namespace DocumentModel.VariantTypes;

/// <summary>
/// Date Time variant implementation
/// </summary>
public class VTDateTimeImpl: VariantImpl, VTDateTime
{
  public new DocumentFormat.OpenXml.VariantTypes.VTFileTime? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.VariantTypes.VTFileTime?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }

  public VTDateTimeImpl()
  {
    OpenXmlElement = new DocumentFormat.OpenXml.VariantTypes.VTFileTime();
  }

  public VTDateTimeImpl(DocumentFormat.OpenXml.VariantTypes.VTFileTime element)
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
        if (value is string str)
          OpenXmlElement.Text = str;
        if (value is null)
          OpenXmlElement.Text = string.Empty;
        else if (value is DateTime dt)
          OpenXmlElement.Text = XmlConvert.ToString(dt, XmlDateTimeSerializationMode.Unspecified);
        else if (value is IConvertible conv)
          OpenXmlElement.Text = XmlConvert.ToString(conv.ToDateTime(System.Globalization.CultureInfo.InvariantCulture), 
            XmlDateTimeSerializationMode.Unspecified);
        else
          throw new InvalidOperationException($"Can't set value of {value.GetType()} type to VTDateTime");
      }
      if (value is null)
        _value = null;
      else if (value is DateTime val)
        _value = val;
      else if (value is string str)
        _value = DateTime.Parse(str);
      else if (value is IConvertible conv)
        _value = conv.ToDateTime(System.Globalization.CultureInfo.InvariantCulture);
      else
        throw new InvalidOperationException($"Can't set value of {value.GetType()} type to VTDateTime");
    }
  }
  private DateTime? _value;

  public override TypeCode GetTypeCode()
  {
    return TypeCode.DateTime;
  }

  public override bool ToBoolean(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert VTDateTime Variant to Boolean type");
  }

  public override byte ToByte(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert VTDateTime Variant to Byte type");
  }

  public override char ToChar(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert VTDateTime Variant to Char type");
  }

  public override DateTime ToDateTime(IFormatProvider? provider)
  {
    return (Value is String val) ? XmlConvert.ToDateTime(val, XmlDateTimeSerializationMode.Unspecified) : throw new InvalidOperationException("Variant is empty but DateOnly expected");
  }

  public override decimal ToDecimal(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert VTDateTime Variant to Decimal type");
  }

  public override double ToDouble(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert VTDateTime Variant to Double type");
  }

  public override short ToInt16(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert VTDateTime Variant to Int16 type");
  }

  public override int ToInt32(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert VTDateTime Variant to Int32 type");
  }

  public override long ToInt64(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert VTDateTime Variant to Int64 type");
  }

  public override sbyte ToSByte(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert VTDateTime Variant to SByte type");
  }

  public override float ToSingle(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert VTDateTime Variant to Single type");
  }

  public override string ToString(IFormatProvider? provider)
  {
    return (Value is String val) ? val : throw new InvalidOperationException("Variant is empty but DateOnly expected");
  }

  public override ushort ToUInt16(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert VTDateTime Variant to UInt16 type");
  }

  public override uint ToUInt32(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert VTDateTime Variant to UInt32 type");
  }

  public override ulong ToUInt64(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert VTDateTime Variant to UInt64 type");
  }
}
