using System.Xml;
using System;

namespace DocumentModel.VariantTypes;

/// <summary>
/// Error Status Code. Value is of HexInt type.
/// </summary>
public class VTErrorImpl : ModelElement<DocumentFormat.OpenXml.VariantTypes.VTError>, VTError
{
  public VTErrorImpl()
  {
    OpenXmlElement = new DocumentFormat.OpenXml.VariantTypes.VTError();
  }

  public VTErrorImpl(DocumentFormat.OpenXml.VariantTypes.VTError element)
  {
    OpenXmlElement = element;
  }

  public object? Value
  {
    get
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.InnerText != string.Empty)
          _value = new HexInt(OpenXmlElement.InnerText);
        else
          _value = null;
      }
      return _value;
    }
    set
    {
      if (value is null)
        _value = null;
      else if (value is Int32 val)
        _value = new HexInt(val);
      else if (value is string str)
        _value = new HexInt(str);
      if (OpenXmlElement != null)
      {
        if (_value == null)
          OpenXmlElement.Text = string.Empty;
        else
          OpenXmlElement.Text = _value.ToString() ?? "";
      }
    }
  }
  private HexInt? _value;

  public TypeCode GetTypeCode()
  {
    return TypeCode.Int32;
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
    throw new InvalidOperationException($"Can't convert Int32 Variant to {conversionType} type");
  }

  public bool ToBoolean(IFormatProvider? provider)
  {
    return (Value is Int32 val) ? val != 0 : throw new InvalidOperationException("Variant is empty but Int32 expected");
  }

  public byte ToByte(IFormatProvider? provider)
  {
    return (Value is Int32 val) ? Convert.ToByte(val) : throw new InvalidOperationException("Variant is empty but Int32 expected");
  }

  public char ToChar(IFormatProvider? provider)
  {
    return (Value is Int32 val) ? Convert.ToChar(val) : throw new InvalidOperationException("Variant is empty but Int32 expected");
  }

  public DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Int32 variant to DateTime");
  }

  public decimal ToDecimal(IFormatProvider? provider)
  {
    return (Value is Int32 val) ? val : throw new InvalidOperationException("Variant is empty but Int32 expected");
  }

  public double ToDouble(IFormatProvider? provider)
  {
    return (Value is Int32 val) ? val : throw new InvalidOperationException("Variant is empty but Int32 expected");
  }

  public short ToInt16(IFormatProvider? provider)
  {
    return (Value is Int32 val) ? Convert.ToInt16(val) : throw new InvalidOperationException("Variant is empty but Int32 expected");
  }

  public int ToInt32(IFormatProvider? provider)
  {
    return (Value is Int32 val) ? val : throw new InvalidOperationException("Variant is empty but Int32 expected");
  }

  public long ToInt64(IFormatProvider? provider)
  {
    return (Value is Int32 val) ? val : throw new InvalidOperationException("Variant is empty but Int32 expected");
  }

  public sbyte ToSByte(IFormatProvider? provider)
  {
    return (Value is Int32 val) ? Convert.ToSByte(val) : throw new InvalidOperationException("Variant is empty but Int32 expected");
  }

  public float ToSingle(IFormatProvider? provider)
  {
    return (Value is Int32 val) ? val : throw new InvalidOperationException("Variant is empty but Int32 expected");
  }

  public string ToString(IFormatProvider? provider)
  {
    return (Value is Int32 val) ? val.ToString() : throw new InvalidOperationException("Variant is empty but Int32 expected");
  }

  public ushort ToUInt16(IFormatProvider? provider)
  {
    return (Value is Int32 val) ? Convert.ToUInt16(val) : throw new InvalidOperationException("Variant is empty but Int32 expected");
  }

  public uint ToUInt32(IFormatProvider? provider)
  {
    return (Value is Int32 val) ? Convert.ToUInt32(val) : throw new InvalidOperationException("Variant is empty but Int32 expected");
  }

  public ulong ToUInt64(IFormatProvider? provider)
  {
    return (Value is Int32 val) ? Convert.ToUInt64(val) : throw new InvalidOperationException("Variant is empty but Int32 expected");
  }

}
