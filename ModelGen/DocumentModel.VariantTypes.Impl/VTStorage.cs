using System;

using DocumentFormat.OpenXml;

namespace DocumentModel.VariantTypes;

/// <summary>
/// Storage variant. Value is of Object type.
/// </summary>
public class VTStorageImpl: ModelElement<DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement>, VTStorage
{
  public VTStorageImpl()
  {
    OpenXmlElement = new DocumentFormat.OpenXml.VariantTypes.VTStorage();
  }

  public VTStorageImpl(DocumentFormat.OpenXml.VariantTypes.VTStorage element)
  {
    OpenXmlElement = element;
  }

  public VTStorageImpl(DocumentFormat.OpenXml.VariantTypes.VTOStorage element)
  {
    OpenXmlElement = element;
  }

  public object? Value
  {
    get
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Text != String.Empty)
          _value = Convert.FromBase64String(OpenXmlElement.Text);
        else
          _value = null;
      }
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
        else if (value is byte[] bytes)
          OpenXmlElement.Text = Convert.ToBase64String(bytes);
        else
          throw new InvalidOperationException($"Can't set value of {value.GetType()} type to VTStorage");
      }
      if (value is null)
        _value = null;
      else if (value is string str)
        _value = Convert.FromBase64String(str);
      else if (value is byte[] bytes)
        _value = bytes;
      else
        throw new InvalidOperationException($"Can't set value of {value.GetType()} type to VTStorage");
    }
  }
  private object? _value;

  public TypeCode GetTypeCode()
  {
    return TypeCode.String;
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
    throw new InvalidOperationException($"Can't convert Storage Variant to {conversionType} type");
  }

  public bool ToBoolean(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Storage variant to Boolean");
  }

  public byte ToByte(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Storage variant to Byte");
  }

  public char ToChar(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Storage variant to Char");
  }

  public DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Storage variant to DateTime");
  }

  public decimal ToDecimal(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Storage variant to Decimal");
  }

  public double ToDouble(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Storage variant to Double");
  }

  public short ToInt16(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Storage variant to Int16");
  }

  public int ToInt32(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Storage variant to Int32");
  }

  public long ToInt64(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Storage variant to Int64");
  }

  public sbyte ToSByte(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Storage variant to SByte");
  }

  public float ToSingle(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Storage variant to Single");
  }

  public string ToString(IFormatProvider? provider)
  {
    return (Value is byte[] val) ? Convert.ToBase64String(val) : string.Empty;
  }

  public ushort ToUInt16(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Storage variant to UInt16");
  }

  public uint ToUInt32(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Storage variant to UInt32");
  }

  public ulong ToUInt64(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Storage variant to UInt64");
  }

}
