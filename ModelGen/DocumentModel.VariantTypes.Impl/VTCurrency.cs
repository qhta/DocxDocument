using System.Xml;
using System;
using DocumentFormat.OpenXml;

namespace DocumentModel.VariantTypes;

/// <summary>
/// Currency variant implementation. Similar to Decimal variant, but format is fixed to 4 decimal digits.
/// </summary>
public class VTCurrencyImpl: VariantImpl, VTCurrency
{
  public new DocumentFormat.OpenXml.VariantTypes.VTCurrency? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.VariantTypes.VTCurrency?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }

  public VTCurrencyImpl()
  {
    OpenXmlElement = new DocumentFormat.OpenXml.VariantTypes.VTCurrency();
  }

  public VTCurrencyImpl(DocumentFormat.OpenXml.VariantTypes.VTCurrency element)
  {
    OpenXmlElement = element;
  }

  public override object? Value
  {
    get
    {
      if (OpenXmlElement != null)
        return (OpenXmlElement.InnerText != string.Empty) ? XmlConvert.ToDecimal(OpenXmlElement.InnerText) : null;
      else
        return _value;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value is Decimal val)
          OpenXmlElement.Text = XmlConvert.ToString(val);
        else if (value is null)
          OpenXmlElement.Text = string.Empty;
        else
          OpenXmlElement.Text = XmlConvert.ToString(Convert.ToDecimal(value));
      }
      if (value is null)
        _value = null;
      else
        _value = Convert.ToDecimal(value);
    }
  }
  private Decimal? _value;

  public override TypeCode GetTypeCode()
  {
    return TypeCode.Decimal;
  }

  public override bool ToBoolean(IFormatProvider? provider)
  {
    return (Value is Decimal val) ? val != 0 : throw new InvalidOperationException("Variant is empty but Decimal expected");
  }

  public override byte ToByte(IFormatProvider? provider)
  {
    return (Value is Decimal val) ? Convert.ToByte(val) : throw new InvalidOperationException("Variant is empty but Decimal expected");
  }

  public override char ToChar(IFormatProvider? provider)
  {
    return (Value is Decimal val) ? Convert.ToChar(val) : throw new InvalidOperationException("Variant is empty but Decimal expected");
  }

  public override DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert Decimal variant to DateTime");
  }

  public override decimal ToDecimal(IFormatProvider? provider)
  {
    return (Value is Decimal val) ? val : throw new InvalidOperationException("Variant is empty but Decimal expected");
  }

  public override double ToDouble(IFormatProvider? provider)
  {
    return (Value is Decimal val) ? Convert.ToDouble(val) : throw new InvalidOperationException("Variant is empty but Decimal expected");
  }

  public override short ToInt16(IFormatProvider? provider)
  {
    return (Value is Decimal val) ? Convert.ToInt16(val) : throw new InvalidOperationException("Variant is empty but Decimal expected");
  }

  public override int ToInt32(IFormatProvider? provider)
  {
    return (Value is Decimal val) ? Convert.ToInt32(val) : throw new InvalidOperationException("Variant is empty but Decimal expected");
  }

  public override long ToInt64(IFormatProvider? provider)
  {
    return (Value is Decimal val) ? Convert.ToInt64(val) : throw new InvalidOperationException("Variant is empty but Decimal expected");
  }

  public override sbyte ToSByte(IFormatProvider? provider)
  {
    return (Value is Decimal val) ? Convert.ToSByte(val) : throw new InvalidOperationException("Variant is empty but Decimal expected");
  }

  public override float ToSingle(IFormatProvider? provider)
  {
    return (Value is Decimal val) ? Convert.ToSingle(val) : throw new InvalidOperationException("Variant is empty but Decimal expected");
  }

  public override string ToString(IFormatProvider? provider)
  {
    return (Value is Decimal val) ? val.ToString("F4") : throw new InvalidOperationException("Variant is empty but Decimal expected");
  }

  public override ushort ToUInt16(IFormatProvider? provider)
  {
    return (Value is Decimal val) ? Convert.ToUInt16(val) : throw new InvalidOperationException("Variant is empty but Decimal expected");
  }

  public override uint ToUInt32(IFormatProvider? provider)
  {
    return (Value is Decimal val) ? Convert.ToUInt32(val) : throw new InvalidOperationException("Variant is empty but Decimal expected");
  }

  public override ulong ToUInt64(IFormatProvider? provider)
  {
    return (Value is Decimal val) ? Convert.ToUInt64(val) : throw new InvalidOperationException("Variant is empty but Decimal expected");
  }

}
