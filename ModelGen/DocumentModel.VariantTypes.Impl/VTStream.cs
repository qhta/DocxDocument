using DocumentFormat.OpenXml;
using System;
using System.IO;

namespace DocumentModel.VariantTypes;

/// <summary>
/// Stream variant. Value is of MemoryStream type.
/// </summary>
public class VTStreamImpl : VariantImpl, VTStream
{
  public new DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }

  public VTStreamImpl()
  {
    OpenXmlElement = new DocumentFormat.OpenXml.VariantTypes.VTStreamData();
  }

  public VTStreamImpl(DocumentFormat.OpenXml.VariantTypes.VTStreamData element)
  {
    OpenXmlElement = element;
  }

  public VTStreamImpl(DocumentFormat.OpenXml.VariantTypes.VTOStreamData element)
  {
    OpenXmlElement = element;
  }

  public override object? Value
  {
    get
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Text != String.Empty)
          _value = new MemoryStream(Convert.FromBase64String(OpenXmlElement.Text));
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
          throw new InvalidOperationException($"Can't set value of {value.GetType()} type to VTStream");
      }
      if (value is null)
        _value = null;
      else if (value is string str)
        _value = new MemoryStream(Convert.FromBase64String(str));
      else if (value is byte[] bytes)
        _value = new MemoryStream(bytes);
      else
        throw new InvalidOperationException($"Can't set value of {value.GetType()} type to VTStream");
    }
  }
  private MemoryStream? _value;

  public override TypeCode GetTypeCode()
  {
    return TypeCode.String;
  }

  public override bool ToBoolean(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Stream variant to Boolean");
  }

  public override byte ToByte(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Stream variant to Byte");
  }

  public override char ToChar(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Stream variant to Char");
  }

  public override DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Stream variant to DateTime");
  }

  public override decimal ToDecimal(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Stream variant to Decimal");
  }

  public override double ToDouble(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Stream variant to Double");
  }

  public override short ToInt16(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Stream variant to Int16");
  }

  public override int ToInt32(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Stream variant to Int32");
  }

  public override long ToInt64(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Stream variant to Int64");
  }

  public override sbyte ToSByte(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Stream variant to SByte");
  }

  public override float ToSingle(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Stream variant to Single");
  }

  public override string ToString(IFormatProvider? provider)
  {
    return (Value is MemoryStream val) ? Convert.ToBase64String(val.GetBuffer()) : string.Empty;
  }

  public override ushort ToUInt16(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Stream variant to UInt16");
  }

  public override uint ToUInt32(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Stream variant to UInt32");
  }

  public override ulong ToUInt64(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Stream variant to UInt64");
  }

}
