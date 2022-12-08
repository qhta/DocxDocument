using System;

using DocumentFormat.OpenXml.Vml;

namespace DocumentModel.VariantTypes;

/// <summary>
/// Binary Blob variant implementation. Value is of Byte[] type.
/// </summary>
public class VTBlobImpl: VariantImpl, VTBlob
{
  public new DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }

  public VTBlobImpl()
  {
    OpenXmlElement = new DocumentFormat.OpenXml.VariantTypes.VTBlob();
  }

  public VTBlobImpl(DocumentFormat.OpenXml.VariantTypes.VTBlob element)
  {
    OpenXmlElement = element;
  }

  public VTBlobImpl(DocumentFormat.OpenXml.VariantTypes.VTOBlob element)
  {
    OpenXmlElement = element;
  }

  public VTBlobImpl(DocumentFormat.OpenXml.VariantTypes.VTStorage element)
  {
    OpenXmlElement = element;
  }

  public VTBlobImpl(DocumentFormat.OpenXml.VariantTypes.VTOStorage element)
  {
    OpenXmlElement = element;
  }

  public VTBlobImpl(DocumentFormat.OpenXml.VariantTypes.VTStreamData element)
  {
    OpenXmlElement = element;
  }

  public VTBlobImpl(DocumentFormat.OpenXml.VariantTypes.VTOStreamData element)
  {
    OpenXmlElement = element;
  }

  public VTBlobImpl(DocumentFormat.OpenXml.VariantTypes.VTVStreamData element)
  {
    OpenXmlElement = element;
  }

  public VTBlobImpl(DocumentFormat.OpenXml.VariantTypes.VTClipboardData element)
  {
    OpenXmlElement = element;
  }

  public override object? Value
  {
    get
    {
      if (OpenXmlElement != null)
        return Convert.FromBase64String(OpenXmlElement.Text);
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
        else if (value is byte[] bytes)
          OpenXmlElement.Text = Convert.ToBase64String(bytes);
        else
          throw new InvalidOperationException($"Can't set value of {value.GetType()} type to VTBlob");
      }
      if (value is null)
        _value = null;
      else if (value is string str)
        _value = Convert.FromBase64String(str);
      else if (value is byte[] bytes)
        _value = bytes;
      else
        throw new InvalidOperationException($"Can't set value of {value.GetType()} type to VTBlob");
    }
  }
  private byte[]? _value;

  public override TypeCode GetTypeCode()
  {
    return TypeCode.String;
  }

  public override bool ToBoolean(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Blob variant to Boolean");
  }

  public override byte ToByte(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Blob variant to Byte");
  }

  public override char ToChar(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Blob variant to Char");
  }

  public override DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Blob variant to DateTime");
  }

  public override decimal ToDecimal(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Blob variant to Decimal");
  }

  public override double ToDouble(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Blob variant to Double");
  }

  public override short ToInt16(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Blob variant to Int16");
  }

  public override int ToInt32(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Blob variant to Int32");
  }

  public override long ToInt64(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Blob variant to Int64");
  }

  public override sbyte ToSByte(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Blob variant to SByte");
  }

  public override float ToSingle(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Blob variant to Single");
  }

  public override string ToString(IFormatProvider? provider)
  {
    return (Value is byte[] val) ? Convert.ToBase64String(val) : string.Empty;
  }

  public override ushort ToUInt16(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Blob variant to UInt16");
  }

  public override uint ToUInt32(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Blob variant to UInt32");
  }

  public override ulong ToUInt64(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Blob variant to UInt64");
  }

}
