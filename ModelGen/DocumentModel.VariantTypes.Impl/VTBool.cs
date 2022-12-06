using System;
using System.Xml;

namespace DocumentModel.VariantTypes;

/// <summary>
/// Boolean.
/// </summary>
public class VTBoolImpl: ModelElement<DocumentFormat.OpenXml.VariantTypes.VTBool>, VTBool
{
  public VTBoolImpl()
  {
    OpenXmlElement = new DocumentFormat.OpenXml.VariantTypes.VTBool();
  }

  public VTBoolImpl(DocumentFormat.OpenXml.VariantTypes.VTBool element)
  {
    OpenXmlElement = element;
  }

  public object? Value
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

  public TypeCode GetTypeCode()
  {
    return TypeCode.Boolean;
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
    throw new InvalidOperationException($"Can't convert Boolean Variant to {conversionType} type");
  }

  public Boolean ToBoolean(IFormatProvider? provider)
  {
    return (Value is Boolean val) ? val : throw new InvalidOperationException("Variant is empty but Boolean expected");
  }

  public byte ToByte(IFormatProvider? provider)
  {
    return (Value is Boolean val) ? (val ? (Byte)1 : (Byte)0) : throw new InvalidOperationException("Variant is empty but Boolean expected");
  }

  public char ToChar(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Boolean variant to Char");
  }

  public DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Boolean variant to DateTime");
  }

  public decimal ToDecimal(IFormatProvider? provider)
  {
    return (Value is Boolean val) ? (val ? (Decimal)1 : (Decimal)0) : throw new InvalidOperationException("Variant is empty but Boolean expected");
  }

  public double ToDouble(IFormatProvider? provider)
  {
    return (Value is Boolean val) ? (val ? (Double)1 : (Double)0) : throw new InvalidOperationException("Variant is empty but Boolean expected");
  }

  public short ToInt16(IFormatProvider? provider)
  {
    return (Value is Boolean val) ? (val ? (Int16)1 : (Int16)0) : throw new InvalidOperationException("Variant is empty but Boolean expected");
  }

  public int ToInt32(IFormatProvider? provider)
  {
    return (Value is Boolean val) ? (val ? (Int32)1 : (Int32)0) : throw new InvalidOperationException("Variant is empty but Boolean expected");
  }

  public long ToInt64(IFormatProvider? provider)
  {
    return (Value is Boolean val) ? (val ? (Int64)1 : (Int64)0) : throw new InvalidOperationException("Variant is empty but Boolean expected");
  }

  public sbyte ToSByte(IFormatProvider? provider)
  {
    return (Value is Boolean val) ? (val ? (SByte)1 : (SByte)0) : throw new InvalidOperationException("Variant is empty but Boolean expected");
  }

  public float ToSingle(IFormatProvider? provider)
  {
    return (Value is Boolean val) ? (val ? (Single)1 : (Single)0) : throw new InvalidOperationException("Variant is empty but Boolean expected");
  }

  public string ToString(IFormatProvider? provider)
  {
    return (Value is Boolean val) ? (val ? "true" : "false") : throw new InvalidOperationException("Variant is empty but Boolean expected");
  }

  public ushort ToUInt16(IFormatProvider? provider)
  {
    return (Value is Boolean val) ? (val ? (UInt16)1 : (UInt16)0) : throw new InvalidOperationException("Variant is empty but Boolean expected");
  }

  public uint ToUInt32(IFormatProvider? provider)
  {
    return (Value is Boolean val) ? (val ? (UInt32)1 : (UInt32)0) : throw new InvalidOperationException("Variant is empty but Boolean expected");
  }

  public ulong ToUInt64(IFormatProvider? provider)
  {
    return (Value is Boolean val) ? (val ? (UInt64)1 : (UInt64)0) : throw new InvalidOperationException("Variant is empty but Boolean expected");
  }
}
