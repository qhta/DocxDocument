using System.Xml;
using System;

namespace DocumentModel.VariantTypes;

/// <summary>
/// Date Time variant implementation
/// </summary>
public class VTDateTimeImpl: ModelElement<DocumentFormat.OpenXml.VariantTypes.VTFileTime>, VTDateTime
{
  public VTDateTimeImpl()
  {
    OpenXmlElement = new DocumentFormat.OpenXml.VariantTypes.VTFileTime();
  }

  public VTDateTimeImpl(DocumentFormat.OpenXml.VariantTypes.VTFileTime element)
  {
    OpenXmlElement = element;
  }

  public object? Value
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

  public TypeCode GetTypeCode()
  {
    return TypeCode.DateTime;
  }

  public object ToType(Type conversionType, IFormatProvider? provider)
  {
    if (conversionType == typeof(Boolean)) return ToBoolean(provider);
    else if (conversionType == typeof(Byte)) return ToByte(provider);
    else if (conversionType == typeof(Char)) return ToChar(provider);
    else if (conversionType == typeof(DateTime)) return ToDateTime(provider);
    else if (conversionType == typeof(Decimal)) return ToDecimal(provider);
    else if (conversionType == typeof(Double)) return ToDouble(provider);
    else if (conversionType == typeof(Int16)) return ToInt16(provider);
    else if (conversionType == typeof(Int32)) return ToInt32(provider);
    else if (conversionType == typeof(Int64)) return ToInt64(provider);
    else if (conversionType == typeof(SByte)) return ToSByte(provider);
    else if (conversionType == typeof(Single)) return ToSingle(provider);
    else if (conversionType == typeof(String)) return ToString(provider);
    else if (conversionType == typeof(UInt16)) return ToUInt16(provider);
    else if (conversionType == typeof(UInt32)) return ToUInt32(provider);
    else if (conversionType == typeof(UInt64)) return ToUInt64(provider);
    throw new InvalidOperationException($"Can't convert VTDateTime Variant to {conversionType} type");
  }

  public bool ToBoolean(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert VTDateTime Variant to Boolean type");
  }

  public byte ToByte(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert VTDateTime Variant to Byte type");
  }

  public char ToChar(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert VTDateTime Variant to Char type");
  }

  public DateTime ToDateTime(IFormatProvider? provider)
  {
    return (Value is String val) ? XmlConvert.ToDateTime(val, XmlDateTimeSerializationMode.Unspecified) : throw new InvalidOperationException("Variant is empty but DateOnly expected");
  }

  public decimal ToDecimal(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert VTDateTime Variant to Decimal type");
  }

  public double ToDouble(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert VTDateTime Variant to Double type");
  }

  public short ToInt16(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert VTDateTime Variant to Int16 type");
  }

  public int ToInt32(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert VTDateTime Variant to Int32 type");
  }

  public long ToInt64(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert VTDateTime Variant to Int64 type");
  }

  public sbyte ToSByte(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert VTDateTime Variant to SByte type");
  }

  public float ToSingle(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert VTDateTime Variant to Single type");
  }

  public string ToString(IFormatProvider? provider)
  {
    return (Value is String val) ? val : throw new InvalidOperationException("Variant is empty but DateOnly expected");
  }

  public ushort ToUInt16(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert VTDateTime Variant to UInt16 type");
  }

  public uint ToUInt32(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert VTDateTime Variant to UInt32 type");
  }

  public ulong ToUInt64(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert VTDateTime Variant to UInt64 type");
  }
}
