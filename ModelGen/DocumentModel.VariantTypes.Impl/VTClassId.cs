using System.Xml;
using System;

namespace DocumentModel.VariantTypes;

/// <summary>
/// Class ID variant implementation. Value is of Guid type. Format is "{xxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}.
/// </summary>
public class VTClassIdImpl: ModelElement<DocumentFormat.OpenXml.VariantTypes.VTClassId>, VTClassId
{
  public VTClassIdImpl()
  {
    OpenXmlElement = new DocumentFormat.OpenXml.VariantTypes.VTClassId();
  }

  public VTClassIdImpl(DocumentFormat.OpenXml.VariantTypes.VTClassId element)
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
        else if (value is Guid gv)
          OpenXmlElement.Text = gv.ToString("B");
        else if (value is byte[] bytes)
          OpenXmlElement.Text = new Guid(bytes).ToString("B");
        else if (value is VTClassId classId)
          OpenXmlElement.Text = Guid.Parse(classId.ToString() ?? "").ToString("B");
        else
          throw new InvalidOperationException($"Can't set value of {value.GetType()} type to VTClassId");
      }
      if (value is null)
        _value = null;
      else if (value is Guid val)
        _value = val;
      else if (value is string str)
        _value = Guid.Parse(str);
      else if (value is byte[] bytes)
        _value = new Guid(bytes);
      else if (value is VTClassId classId)
        _value = Guid.Parse(classId.ToString() ?? "");
      else
        throw new InvalidOperationException($"Can't set value of {value.GetType()} type to VTClassId");
    }
  }
  private Guid? _value;

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
    throw new InvalidOperationException($"Can't convert Byte Variant to {conversionType} type");
  }

  public bool ToBoolean(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert ClassId variant to Boolean");
  }

  public byte ToByte(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert ClassId variant to Byte");
  }

  public char ToChar(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert ClassId variant to Char");
  }

  public DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert ClassId variant to DateTime");
  }

  public decimal ToDecimal(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert ClassId variant to Decimal");
  }

  public double ToDouble(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert ClassId variant to Double");
  }

  public short ToInt16(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert ClassId variant to Int16");
  }

  public int ToInt32(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert ClassId variant to Int32");
  }

  public long ToInt64(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert ClassId variant to Int64");
  }

  public sbyte ToSByte(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert ClassId variant to SByte");
  }

  public float ToSingle(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert ClassId variant to Single");
  }

  public string ToString(IFormatProvider? provider)
  {
    return (Value is Guid val) ? val.ToString("B") : string.Empty;
  }

  public ushort ToUInt16(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert ClassId variant to UInt16");
  }

  public uint ToUInt32(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert ClassId variant to UInt32");
  }

  public ulong ToUInt64(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert ClassId variant to UInt64");
  }

}
