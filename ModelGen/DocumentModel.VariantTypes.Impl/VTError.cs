using System.Xml;
using System;
using DocumentFormat.OpenXml;

namespace DocumentModel.VariantTypes;

/// <summary>
/// Error Status Code. Value is of HexInt type.
/// </summary>
public class VTErrorImpl : VariantImpl, VTError
{
  public new DocumentFormat.OpenXml.VariantTypes.VTError? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.VariantTypes.VTError?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }

  public VTErrorImpl()
  {
    OpenXmlElement = new DocumentFormat.OpenXml.VariantTypes.VTError();
  }

  public VTErrorImpl(DocumentFormat.OpenXml.VariantTypes.VTError element)
  {
    OpenXmlElement = element;
  }

  public override object? Value
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

  public override TypeCode GetTypeCode()
  {
    return TypeCode.Int32;
  }

  public override bool ToBoolean(IFormatProvider? provider)
  {
    return (Value is Int32 val) ? val != 0 : throw new InvalidOperationException("Variant is empty but Int32 expected");
  }

  public override byte ToByte(IFormatProvider? provider)
  {
    return (Value is Int32 val) ? Convert.ToByte(val) : throw new InvalidOperationException("Variant is empty but Int32 expected");
  }

  public override char ToChar(IFormatProvider? provider)
  {
    return (Value is Int32 val) ? Convert.ToChar(val) : throw new InvalidOperationException("Variant is empty but Int32 expected");
  }

  public override DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Int32 variant to DateTime");
  }

  public override decimal ToDecimal(IFormatProvider? provider)
  {
    return (Value is Int32 val) ? val : throw new InvalidOperationException("Variant is empty but Int32 expected");
  }

  public override double ToDouble(IFormatProvider? provider)
  {
    return (Value is Int32 val) ? val : throw new InvalidOperationException("Variant is empty but Int32 expected");
  }

  public override short ToInt16(IFormatProvider? provider)
  {
    return (Value is Int32 val) ? Convert.ToInt16(val) : throw new InvalidOperationException("Variant is empty but Int32 expected");
  }

  public override int ToInt32(IFormatProvider? provider)
  {
    return (Value is Int32 val) ? val : throw new InvalidOperationException("Variant is empty but Int32 expected");
  }

  public override long ToInt64(IFormatProvider? provider)
  {
    return (Value is Int32 val) ? val : throw new InvalidOperationException("Variant is empty but Int32 expected");
  }

  public override sbyte ToSByte(IFormatProvider? provider)
  {
    return (Value is Int32 val) ? Convert.ToSByte(val) : throw new InvalidOperationException("Variant is empty but Int32 expected");
  }

  public override float ToSingle(IFormatProvider? provider)
  {
    return (Value is Int32 val) ? val : throw new InvalidOperationException("Variant is empty but Int32 expected");
  }

  public override string ToString(IFormatProvider? provider)
  {
    return (Value is Int32 val) ? val.ToString() : throw new InvalidOperationException("Variant is empty but Int32 expected");
  }

  public override ushort ToUInt16(IFormatProvider? provider)
  {
    return (Value is Int32 val) ? Convert.ToUInt16(val) : throw new InvalidOperationException("Variant is empty but Int32 expected");
  }

  public override uint ToUInt32(IFormatProvider? provider)
  {
    return (Value is Int32 val) ? Convert.ToUInt32(val) : throw new InvalidOperationException("Variant is empty but Int32 expected");
  }

  public override ulong ToUInt64(IFormatProvider? provider)
  {
    return (Value is Int32 val) ? Convert.ToUInt64(val) : throw new InvalidOperationException("Variant is empty but Int32 expected");
  }

}
