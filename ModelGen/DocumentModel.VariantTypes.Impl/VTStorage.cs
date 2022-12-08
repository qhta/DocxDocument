using System;

using DocumentFormat.OpenXml;

namespace DocumentModel.VariantTypes;

/// <summary>
/// Storage variant. Value is of Object type.
/// </summary>
public class VTStorageImpl: VariantImpl, VTStorage
{
  public new DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }

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

  public override object? Value
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

  public override TypeCode GetTypeCode()
  {
    return TypeCode.String;
  }

  public override bool ToBoolean(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Storage variant to Boolean");
  }

  public override byte ToByte(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Storage variant to Byte");
  }

  public override char ToChar(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Storage variant to Char");
  }

  public override DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Storage variant to DateTime");
  }

  public override decimal ToDecimal(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Storage variant to Decimal");
  }

  public override double ToDouble(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Storage variant to Double");
  }

  public override short ToInt16(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Storage variant to Int16");
  }

  public override int ToInt32(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Storage variant to Int32");
  }

  public override long ToInt64(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Storage variant to Int64");
  }

  public override sbyte ToSByte(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Storage variant to SByte");
  }

  public override float ToSingle(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Storage variant to Single");
  }

  public override string ToString(IFormatProvider? provider)
  {
    return (Value is byte[] val) ? Convert.ToBase64String(val) : string.Empty;
  }

  public override ushort ToUInt16(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Storage variant to UInt16");
  }

  public override uint ToUInt32(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Storage variant to UInt32");
  }

  public override ulong ToUInt64(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Storage variant to UInt64");
  }

}
